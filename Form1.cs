using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Insert_Tools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Initial();
        }


        static List<object> colData = new List<object>();

        private void btnGetData_Click(object sender, EventArgs e)
        {
            var dialag = GetFileDialog.ShowDialog();
            if (dialag == DialogResult.OK)
            {
                txtFilePath.Text = GetFileDialog.FileName;
            }
            else
            {
                txtFilePath.Text = "";
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {

                switch (cbType.Text)
                {
                    case "CSV":
                        ReadCSVToDB(txtTable.Text, txtFilePath.Text, txtConn.Text);
                        break;
                    case "Excel":
                        string tableName = "[" + txtExcelTable.Text + "$]";//在頁簽名稱後加$，再用中括號[]包起來
                        string sql = "select * from " + tableName;//SQL查詢

                        ReadExcelToDB(txtTable.Text, txtFilePath.Text, txtConn.Text, sql);
                        break;
                    case "Log":
                        ReadTxtToDB(txtTable.Text, txtFilePath.Text, txtConn.Text);
                        break;
                    case "Txt":
                        ReadTxtToDB(txtTable.Text, txtFilePath.Text, txtConn.Text);
                        break;
                    case "Tsv":
                        ReadTSVToDB(txtTable.Text, txtFilePath.Text, txtConn.Text);
                        break;
                    default:
                        break;
                }
                UpdateAppConfig("cbType", cbType.Text.Trim());
                UpdateAppConfig("txtFilePath", txtFilePath.Text.Trim());
                UpdateAppConfig("txtConn", txtConn.Text.Trim());
                UpdateAppConfig("txtTable", txtTable.Text.Trim());
                UpdateAppConfig("txtExcelTable", txtExcelTable.Text.Trim());
                MessageBox.Show("Success", "Done");
            }
            catch(Exception ex ) {
                MessageBox.Show(ex.ToString(),"錯誤警告");
            }
                  
        }


        private DataTable GetExcelSheetNames(string filePath)
        {
            //Office 2003
            //OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + ";Extended Properties='Excel 8.0;HDR=YES;IMEX=1'");

            //Office 2007
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties='Excel 12.0 Xml;HDR=YES'");

            DataSet ds = new DataSet();
            conn.Open();
            DataTable dt = conn.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Tables, null);
            conn.Close();
            return dt;
        }
        private void ReadTSVToDB(string tableName, string filePath, string conn)
        {
            int counter = 0;
            string line;

            System.IO.StreamReader file =
               new System.IO.StreamReader(filePath);
            SqlConnection Bulkcn = new SqlConnection(conn);
            Bulkcn.Open();
            string targetTable = tableName;
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT top(0) * FROM " + targetTable, conn);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            SqlBulkCopy SBC = new SqlBulkCopy(Bulkcn);
            SBC.BulkCopyTimeout = 0;
            SBC.DestinationTableName = "dbo." + targetTable;

            try
            {
                while ((line = file.ReadLine()) != null)
                {
                    counter++;
                    colData.Clear();// = new List<object>();
                    foreach (var col in line.Split('\t'))
                    {
                        colData.Add(col);

                    }


                    datatable.Rows.Add(colData.ToArray());
                    Console.WriteLine(line);

                }
            }
            catch (Exception ex) { throw ex; }

            try
            {

                SBC.WriteToServer(datatable);
            }
            catch (Exception ex) { throw ex; }




            file.Close();
        }
        private void ReadTxtToDB(string tableName, string filePath, string conn)
        {
            int counter = 0;
            string line;

            System.IO.StreamReader file =
               new System.IO.StreamReader(filePath);
            SqlConnection Bulkcn = new SqlConnection(conn);
            Bulkcn.Open();
            string targetTable = tableName;
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT top(0) * FROM " + targetTable, conn);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            SqlBulkCopy SBC = new SqlBulkCopy(Bulkcn);
            SBC.BulkCopyTimeout = 0;
            SBC.DestinationTableName = "dbo." + targetTable;

            try
            {
                while ((line = file.ReadLine()) != null)
                {
                    counter++;
                    colData.Clear();// = new List<object>();
                    // colData.Add(counter);
                    // colData.Add(null);
                    colData.Add(line);
                    datatable.Rows.Add(colData.ToArray());
                    Console.WriteLine(line);

                }
            }
            catch (Exception ex) { throw ex; }

            try
            {

                SBC.WriteToServer(datatable);
            }
            catch (Exception ex) { throw ex; }




            file.Close();
        }
        private DataTable GetExcelDataTable(string filePath, string sql)
        {
            //Office 2003
            //OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + ";Extended Properties='Excel 8.0;HDR=YES;IMEX=1;Readonly=0'");

            //Office 2007
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties='Excel 12.0 Xml;HDR=YES'");

            OleDbDataAdapter da = new OleDbDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dt.TableName = "tmp";
            conn.Close();
            return dt;
        }
        void ReadCSVToDB(string tableName, string filePath, string conn)
        {
            int counter = 0;
            string line;

            System.IO.StreamReader file =
               new System.IO.StreamReader(filePath);
            SqlConnection Bulkcn = new SqlConnection(conn);
            Bulkcn.Open();
            string targetTable = tableName;
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT top(0) * FROM " + targetTable, conn);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            SqlBulkCopy SBC = new SqlBulkCopy(Bulkcn);
            SBC.BulkCopyTimeout = 0;
            SBC.DestinationTableName = "dbo." + targetTable;

            try
            {
                while ((line = file.ReadLine()) != null)
                {
                    counter++;
                    colData.Clear();// = new List<object>();
                    foreach (var col in line.Split(','))
                    {
                        colData.Add(col);

                    }
                    datatable.Rows.Add(colData.ToArray());
                    Console.WriteLine(line);

                }
            }
            catch (Exception ex) { throw ex; }

            try
            {

                SBC.WriteToServer(datatable);
            }
            catch (Exception ex) { throw ex; }




            file.Close();
        }
        void ReadExcelToDB(string tableName, string filePath, string conn, string sql)
        {
            SqlConnection Bulkcn = new SqlConnection(conn);
            Bulkcn.Open();
            string targetTable = tableName;
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT top(0) * FROM " + targetTable, conn);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            SqlBulkCopy SBC = new SqlBulkCopy(Bulkcn);
            SBC.BulkCopyTimeout = 0;
            SBC.DestinationTableName = "dbo." + targetTable;
            DataTable dt = GetExcelDataTable(filePath, sql);

            try
            {
                int counter = 0;

                foreach (DataRow row in dt.Rows)
                {
                    counter++;
                    colData.Clear();

                    foreach (var col in row.ItemArray)
                    {
                        colData.Add(col);

                    }
                    datatable.Rows.Add(colData.ToArray());
                    Console.WriteLine(counter);
                
                }
               
            }
            catch (Exception ex) { throw ex; }

            try
            {

                SBC.WriteToServer(datatable);
            }
            catch (Exception ex) { throw ex; }


        }
        private void Initial()
        {
            cbType.Text = GetConfigcbType();
            txtFilePath.Text = GetConfigtxtFilePath();
            txtConn.Text = GetConfigtxtConn();
            txtTable.Text = GetConfigtxtTable();
            txtExcelTable.Text = GetConfigtxtExcelTable();
            CheckExcel();
        }
        string GetConfigcbType()
        {
            return GetConfigValue("cbType");
        }
        string GetConfigtxtFilePath()
        {
            return GetConfigValue("txtFilePath");
        }
        string GetConfigtxtConn()
        {
            return GetConfigValue("txtConn");
        }
        string GetConfigtxtTable()
        {
            return GetConfigValue("txtTable");
        }
        string GetConfigtxtExcelTable()
        {
            return GetConfigValue("txtExcelTable");
        }

        string GetConfigValue(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        void UpdateAppConfig(string newKey, string newValue)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[newKey] == null)
                {
                    settings.Add(newKey, newValue);
                }
                else
                {
                    settings[newKey].Value = newValue;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Config is deleted.Please re-install your system");
                return;
            }

        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckExcel();
        }
        void CheckExcel() {
            if (cbType.Text.StartsWith("Excel"))
            {
                label10.Visible = true;
                label11.Visible = true;
                txtExcelTable.Visible = true;
            }
            else
            {
                label10.Visible = false;
                label11.Visible = false;
                txtExcelTable.Visible = false;
            }
        }

    }
}
