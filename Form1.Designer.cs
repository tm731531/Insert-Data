namespace Data_Insert_Tools
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label8 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.GetFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtTable = new System.Windows.Forms.TextBox();
            this.txtConn = new System.Windows.Forms.TextBox();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.btnGetData = new System.Windows.Forms.Button();
            this.txtExcelTable = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.ForeColor = System.Drawing.Color.Red;
            this.Label8.Location = new System.Drawing.Point(185, 178);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(550, 17);
            this.Label8.TabIndex = 28;
            this.Label8.Text = "Sample : Server=192.168.1.4;Database=Farmdata;User ID=ubuntu;Password=ubuntu;";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(188, 374);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(533, 133);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Text = "送出";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // GetFileDialog
            // 
            this.GetFileDialog.FileName = "GetFileDialog";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.ForeColor = System.Drawing.Color.Red;
            this.Label9.Location = new System.Drawing.Point(185, 277);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(231, 17);
            this.Label9.TabIndex = 29;
            this.Label9.Text = "Sample : PRO_CATEGORY_TRAIN";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.ForeColor = System.Drawing.Color.Red;
            this.Label7.Location = new System.Drawing.Point(185, 99);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(402, 17);
            this.Label7.TabIndex = 27;
            this.Label7.Text = "Sample : C:/Users/ext_tomt/Desktop/0510problemcategory.xlsx";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.ForeColor = System.Drawing.Color.Red;
            this.Label6.Location = new System.Drawing.Point(185, 14);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(100, 17);
            this.Label6.TabIndex = 26;
            this.Label6.Text = "Sample : Excel";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(12, 374);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(109, 17);
            this.Label5.TabIndex = 25;
            this.Label5.Text = "Step5 : 案\"送出\"";
            // 
            // txtTable
            // 
            this.txtTable.Location = new System.Drawing.Point(188, 297);
            this.txtTable.Name = "txtTable";
            this.txtTable.Size = new System.Drawing.Size(526, 22);
            this.txtTable.TabIndex = 24;
            // 
            // txtConn
            // 
            this.txtConn.Location = new System.Drawing.Point(188, 198);
            this.txtConn.Name = "txtConn";
            this.txtConn.Size = new System.Drawing.Size(526, 22);
            this.txtConn.TabIndex = 23;
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(188, 126);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(417, 22);
            this.txtFilePath.TabIndex = 22;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(12, 277);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(155, 17);
            this.Label4.TabIndex = 21;
            this.Label4.Text = "Step4 : 設定目標資料表";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(12, 178);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(155, 17);
            this.Label3.TabIndex = 20;
            this.Label3.Text = "Step3 : 設定目標資料庫";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(12, 99);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(113, 17);
            this.Label2.TabIndex = 19;
            this.Label2.Text = "Step2 : 選擇檔案";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 19);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(113, 17);
            this.Label1.TabIndex = 18;
            this.Label1.Text = "Step1 : 選擇型態";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Excel",
            "Log",
            "Txt",
            "Csv",
            "Tsv"});
            this.cbType.Location = new System.Drawing.Point(188, 34);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(526, 24);
            this.cbType.TabIndex = 17;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(611, 111);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(103, 67);
            this.btnGetData.TabIndex = 16;
            this.btnGetData.Text = "檔案 謝謝";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // txtExcelTable
            // 
            this.txtExcelTable.Location = new System.Drawing.Point(188, 346);
            this.txtExcelTable.Name = "txtExcelTable";
            this.txtExcelTable.Size = new System.Drawing.Size(526, 22);
            this.txtExcelTable.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(185, 322);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 17);
            this.label10.TabIndex = 31;
            this.label10.Text = "Sample : Sheet1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 322);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 17);
            this.label11.TabIndex = 32;
            this.label11.Text = "Step4 .1: 設定Excel的表格";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 527);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtExcelTable);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.txtTable);
            this.Controls.Add(this.txtConn);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.btnGetData);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Data Insert Tools";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Button btnSubmit;
        internal System.Windows.Forms.OpenFileDialog GetFileDialog;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtTable;
        internal System.Windows.Forms.TextBox txtConn;
        internal System.Windows.Forms.TextBox txtFilePath;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox cbType;
        internal System.Windows.Forms.Button btnGetData;
        internal System.Windows.Forms.TextBox txtExcelTable;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Label label11;
    }
}

