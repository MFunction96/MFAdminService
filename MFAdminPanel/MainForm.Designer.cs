namespace MFAdminPanel
{
    partial class MainForm
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
            this.LblEnabled = new System.Windows.Forms.Label();
            this.LblInterval = new System.Windows.Forms.Label();
            this.LblCheck = new System.Windows.Forms.Label();
            this.LbSqlServer = new System.Windows.Forms.Label();
            this.BtnSqlServer = new System.Windows.Forms.Button();
            this.BtnMySql = new System.Windows.Forms.Button();
            this.LblMySql = new System.Windows.Forms.Label();
            this.BtnOracle = new System.Windows.Forms.Button();
            this.LblOracle = new System.Windows.Forms.Label();
            this.BtnTomcat = new System.Windows.Forms.Button();
            this.LblTomcat = new System.Windows.Forms.Label();
            this.LblPwd = new System.Windows.Forms.Label();
            this.TbPwd = new System.Windows.Forms.TextBox();
            this.LblKmsServer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblEnabled
            // 
            this.LblEnabled.AutoSize = true;
            this.LblEnabled.Location = new System.Drawing.Point(54, 34);
            this.LblEnabled.Name = "LblEnabled";
            this.LblEnabled.Size = new System.Drawing.Size(55, 15);
            this.LblEnabled.TabIndex = 0;
            this.LblEnabled.Text = "label1";
            // 
            // LblInterval
            // 
            this.LblInterval.AutoSize = true;
            this.LblInterval.Location = new System.Drawing.Point(54, 69);
            this.LblInterval.Name = "LblInterval";
            this.LblInterval.Size = new System.Drawing.Size(55, 15);
            this.LblInterval.TabIndex = 1;
            this.LblInterval.Text = "label1";
            // 
            // LblCheck
            // 
            this.LblCheck.AutoSize = true;
            this.LblCheck.Location = new System.Drawing.Point(55, 105);
            this.LblCheck.Name = "LblCheck";
            this.LblCheck.Size = new System.Drawing.Size(55, 15);
            this.LblCheck.TabIndex = 2;
            this.LblCheck.Text = "label1";
            // 
            // LbSqlServer
            // 
            this.LbSqlServer.AutoSize = true;
            this.LbSqlServer.Location = new System.Drawing.Point(54, 223);
            this.LbSqlServer.Name = "LbSqlServer";
            this.LbSqlServer.Size = new System.Drawing.Size(79, 15);
            this.LbSqlServer.TabIndex = 3;
            this.LbSqlServer.Text = "SQLServer";
            // 
            // BtnSqlServer
            // 
            this.BtnSqlServer.Enabled = false;
            this.BtnSqlServer.Location = new System.Drawing.Point(170, 219);
            this.BtnSqlServer.Name = "BtnSqlServer";
            this.BtnSqlServer.Size = new System.Drawing.Size(75, 23);
            this.BtnSqlServer.TabIndex = 4;
            this.BtnSqlServer.Text = "不可用";
            this.BtnSqlServer.UseVisualStyleBackColor = true;
            // 
            // BtnMySql
            // 
            this.BtnMySql.Enabled = false;
            this.BtnMySql.Location = new System.Drawing.Point(170, 267);
            this.BtnMySql.Name = "BtnMySql";
            this.BtnMySql.Size = new System.Drawing.Size(75, 23);
            this.BtnMySql.TabIndex = 6;
            this.BtnMySql.Text = "不可用";
            this.BtnMySql.UseVisualStyleBackColor = true;
            // 
            // LblMySql
            // 
            this.LblMySql.AutoSize = true;
            this.LblMySql.Location = new System.Drawing.Point(54, 271);
            this.LblMySql.Name = "LblMySql";
            this.LblMySql.Size = new System.Drawing.Size(47, 15);
            this.LblMySql.TabIndex = 5;
            this.LblMySql.Text = "MySQL";
            // 
            // BtnOracle
            // 
            this.BtnOracle.Enabled = false;
            this.BtnOracle.Location = new System.Drawing.Point(170, 318);
            this.BtnOracle.Name = "BtnOracle";
            this.BtnOracle.Size = new System.Drawing.Size(75, 23);
            this.BtnOracle.TabIndex = 8;
            this.BtnOracle.Text = "不可用";
            this.BtnOracle.UseVisualStyleBackColor = true;
            // 
            // LblOracle
            // 
            this.LblOracle.AutoSize = true;
            this.LblOracle.Location = new System.Drawing.Point(54, 322);
            this.LblOracle.Name = "LblOracle";
            this.LblOracle.Size = new System.Drawing.Size(55, 15);
            this.LblOracle.TabIndex = 7;
            this.LblOracle.Text = "Oracle";
            // 
            // BtnTomcat
            // 
            this.BtnTomcat.Enabled = false;
            this.BtnTomcat.Location = new System.Drawing.Point(170, 368);
            this.BtnTomcat.Name = "BtnTomcat";
            this.BtnTomcat.Size = new System.Drawing.Size(75, 23);
            this.BtnTomcat.TabIndex = 10;
            this.BtnTomcat.Text = "不可用";
            this.BtnTomcat.UseVisualStyleBackColor = true;
            // 
            // LblTomcat
            // 
            this.LblTomcat.AutoSize = true;
            this.LblTomcat.Location = new System.Drawing.Point(54, 372);
            this.LblTomcat.Name = "LblTomcat";
            this.LblTomcat.Size = new System.Drawing.Size(55, 15);
            this.LblTomcat.TabIndex = 9;
            this.LblTomcat.Text = "Tomcat";
            // 
            // LblPwd
            // 
            this.LblPwd.AutoSize = true;
            this.LblPwd.Location = new System.Drawing.Point(54, 179);
            this.LblPwd.Name = "LblPwd";
            this.LblPwd.Size = new System.Drawing.Size(82, 15);
            this.LblPwd.TabIndex = 11;
            this.LblPwd.Text = "数据库密码";
            // 
            // TbPwd
            // 
            this.TbPwd.Location = new System.Drawing.Point(156, 176);
            this.TbPwd.Name = "TbPwd";
            this.TbPwd.ReadOnly = true;
            this.TbPwd.Size = new System.Drawing.Size(127, 25);
            this.TbPwd.TabIndex = 12;
            this.TbPwd.Text = "Cugb123456";
            // 
            // LblKmsServer
            // 
            this.LblKmsServer.AutoSize = true;
            this.LblKmsServer.Location = new System.Drawing.Point(55, 142);
            this.LblKmsServer.Name = "LblKmsServer";
            this.LblKmsServer.Size = new System.Drawing.Size(55, 15);
            this.LblKmsServer.TabIndex = 13;
            this.LblKmsServer.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 412);
            this.Controls.Add(this.LblKmsServer);
            this.Controls.Add(this.TbPwd);
            this.Controls.Add(this.LblPwd);
            this.Controls.Add(this.BtnTomcat);
            this.Controls.Add(this.LblTomcat);
            this.Controls.Add(this.BtnOracle);
            this.Controls.Add(this.LblOracle);
            this.Controls.Add(this.BtnMySql);
            this.Controls.Add(this.LblMySql);
            this.Controls.Add(this.BtnSqlServer);
            this.Controls.Add(this.LbSqlServer);
            this.Controls.Add(this.LblCheck);
            this.Controls.Add(this.LblInterval);
            this.Controls.Add(this.LblEnabled);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblEnabled;
        private System.Windows.Forms.Label LblInterval;
        private System.Windows.Forms.Label LblCheck;
        private System.Windows.Forms.Label LbSqlServer;
        private System.Windows.Forms.Button BtnSqlServer;
        private System.Windows.Forms.Button BtnMySql;
        private System.Windows.Forms.Label LblMySql;
        private System.Windows.Forms.Button BtnOracle;
        private System.Windows.Forms.Label LblOracle;
        private System.Windows.Forms.Button BtnTomcat;
        private System.Windows.Forms.Label LblTomcat;
        private System.Windows.Forms.Label LblPwd;
        private System.Windows.Forms.TextBox TbPwd;
        private System.Windows.Forms.Label LblKmsServer;
    }
}