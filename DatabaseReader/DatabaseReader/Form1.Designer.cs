namespace DatabaseReader
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtFirmName = new System.Windows.Forms.TextBox();
            this.txtJurCityName = new System.Windows.Forms.TextBox();
            this.txtPostCityName = new System.Windows.Forms.TextBox();
            this.chkFirm = new System.Windows.Forms.CheckBox();
            this.chkJurCity = new System.Windows.Forms.CheckBox();
            this.chkPostCity = new System.Windows.Forms.CheckBox();
            this.lblFirmName = new System.Windows.Forms.Label();
            this.lblJurCityName = new System.Windows.Forms.Label();
            this.lblPostCityName = new System.Windows.Forms.Label();
            this.btnExecuteQuery = new System.Windows.Forms.Button();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(361, 231);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtFirmName
            // 
            this.txtFirmName.Enabled = false;
            this.txtFirmName.Location = new System.Drawing.Point(377, 24);
            this.txtFirmName.Name = "txtFirmName";
            this.txtFirmName.Size = new System.Drawing.Size(176, 20);
            this.txtFirmName.TabIndex = 1;
            // 
            // txtJurCityName
            // 
            this.txtJurCityName.Enabled = false;
            this.txtJurCityName.Location = new System.Drawing.Point(377, 86);
            this.txtJurCityName.Name = "txtJurCityName";
            this.txtJurCityName.Size = new System.Drawing.Size(176, 20);
            this.txtJurCityName.TabIndex = 2;
            // 
            // txtPostCityName
            // 
            this.txtPostCityName.Enabled = false;
            this.txtPostCityName.Location = new System.Drawing.Point(377, 143);
            this.txtPostCityName.Name = "txtPostCityName";
            this.txtPostCityName.Size = new System.Drawing.Size(176, 20);
            this.txtPostCityName.TabIndex = 3;
            // 
            // chkFirm
            // 
            this.chkFirm.AutoSize = true;
            this.chkFirm.Location = new System.Drawing.Point(559, 27);
            this.chkFirm.Name = "chkFirm";
            this.chkFirm.Size = new System.Drawing.Size(15, 14);
            this.chkFirm.TabIndex = 4;
            this.chkFirm.UseVisualStyleBackColor = true;
            this.chkFirm.CheckedChanged += new System.EventHandler(this.chkFirm_CheckedChanged);
            // 
            // chkJurCity
            // 
            this.chkJurCity.AutoSize = true;
            this.chkJurCity.Location = new System.Drawing.Point(559, 89);
            this.chkJurCity.Name = "chkJurCity";
            this.chkJurCity.Size = new System.Drawing.Size(15, 14);
            this.chkJurCity.TabIndex = 5;
            this.chkJurCity.UseVisualStyleBackColor = true;
            this.chkJurCity.CheckedChanged += new System.EventHandler(this.chkJurCity_CheckedChanged);
            // 
            // chkPostCity
            // 
            this.chkPostCity.AutoSize = true;
            this.chkPostCity.Location = new System.Drawing.Point(559, 146);
            this.chkPostCity.Name = "chkPostCity";
            this.chkPostCity.Size = new System.Drawing.Size(15, 14);
            this.chkPostCity.TabIndex = 6;
            this.chkPostCity.UseVisualStyleBackColor = true;
            this.chkPostCity.CheckedChanged += new System.EventHandler(this.chkPostCity_CheckedChanged);
            // 
            // lblFirmName
            // 
            this.lblFirmName.AutoSize = true;
            this.lblFirmName.Location = new System.Drawing.Point(377, 4);
            this.lblFirmName.Name = "lblFirmName";
            this.lblFirmName.Size = new System.Drawing.Size(96, 13);
            this.lblFirmName.TabIndex = 7;
            this.lblFirmName.Text = "Название фирмы";
            // 
            // lblJurCityName
            // 
            this.lblJurCityName.AutoSize = true;
            this.lblJurCityName.Location = new System.Drawing.Point(377, 67);
            this.lblJurCityName.Name = "lblJurCityName";
            this.lblJurCityName.Size = new System.Drawing.Size(108, 13);
            this.lblJurCityName.TabIndex = 8;
            this.lblJurCityName.Text = "Юридический адрес";
            // 
            // lblPostCityName
            // 
            this.lblPostCityName.AutoSize = true;
            this.lblPostCityName.Location = new System.Drawing.Point(377, 124);
            this.lblPostCityName.Name = "lblPostCityName";
            this.lblPostCityName.Size = new System.Drawing.Size(90, 13);
            this.lblPostCityName.TabIndex = 9;
            this.lblPostCityName.Text = "Почтовый адрес";
            // 
            // btnExecuteQuery
            // 
            this.btnExecuteQuery.Location = new System.Drawing.Point(380, 190);
            this.btnExecuteQuery.Name = "btnExecuteQuery";
            this.btnExecuteQuery.Size = new System.Drawing.Size(173, 45);
            this.btnExecuteQuery.TabIndex = 10;
            this.btnExecuteQuery.Text = "Выполнить запрос";
            this.btnExecuteQuery.UseVisualStyleBackColor = true;
            this.btnExecuteQuery.Click += new System.EventHandler(this.btnExecuteQuery_Click);
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Task.mdf;Inte" +
    "grated Security=True;Connect Timeout=30";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 251);
            this.Controls.Add(this.btnExecuteQuery);
            this.Controls.Add(this.lblPostCityName);
            this.Controls.Add(this.lblJurCityName);
            this.Controls.Add(this.lblFirmName);
            this.Controls.Add(this.chkPostCity);
            this.Controls.Add(this.chkJurCity);
            this.Controls.Add(this.chkFirm);
            this.Controls.Add(this.txtPostCityName);
            this.Controls.Add(this.txtJurCityName);
            this.Controls.Add(this.txtFirmName);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "DatabaseReader";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtFirmName;
        private System.Windows.Forms.TextBox txtJurCityName;
        private System.Windows.Forms.TextBox txtPostCityName;
        private System.Windows.Forms.CheckBox chkFirm;
        private System.Windows.Forms.CheckBox chkJurCity;
        private System.Windows.Forms.CheckBox chkPostCity;
        private System.Windows.Forms.Label lblFirmName;
        private System.Windows.Forms.Label lblJurCityName;
        private System.Windows.Forms.Label lblPostCityName;
        private System.Windows.Forms.Button btnExecuteQuery;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
    }
}

