namespace MFAdminConfig
{
    partial class MainFrom
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.TbKmsAddress = new System.Windows.Forms.TextBox();
            this.TbInterval = new System.Windows.Forms.TextBox();
            this.LblInterval = new System.Windows.Forms.Label();
            this.LblKmsAddress = new System.Windows.Forms.Label();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.LblCheck = new System.Windows.Forms.Label();
            this.TbCheck = new System.Windows.Forms.TextBox();
            this.BtnService = new System.Windows.Forms.Button();
            this.CbEnabled = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // TbKmsAddress
            // 
            this.TbKmsAddress.Location = new System.Drawing.Point(149, 206);
            this.TbKmsAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TbKmsAddress.Name = "TbKmsAddress";
            this.TbKmsAddress.Size = new System.Drawing.Size(229, 25);
            this.TbKmsAddress.TabIndex = 3;
            // 
            // TbInterval
            // 
            this.TbInterval.Location = new System.Drawing.Point(149, 99);
            this.TbInterval.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TbInterval.Name = "TbInterval";
            this.TbInterval.Size = new System.Drawing.Size(229, 25);
            this.TbInterval.TabIndex = 1;
            // 
            // LblInterval
            // 
            this.LblInterval.AutoSize = true;
            this.LblInterval.Location = new System.Drawing.Point(52, 102);
            this.LblInterval.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblInterval.Name = "LblInterval";
            this.LblInterval.Size = new System.Drawing.Size(67, 15);
            this.LblInterval.TabIndex = 2;
            this.LblInterval.Text = "查询间隔";
            // 
            // LblKmsAddress
            // 
            this.LblKmsAddress.AutoSize = true;
            this.LblKmsAddress.Location = new System.Drawing.Point(60, 210);
            this.LblKmsAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblKmsAddress.Name = "LblKmsAddress";
            this.LblKmsAddress.Size = new System.Drawing.Size(61, 15);
            this.LblKmsAddress.TabIndex = 3;
            this.LblKmsAddress.Text = "KMS地址";
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnConfirm.Location = new System.Drawing.Point(63, 269);
            this.BtnConfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(100, 34);
            this.BtnConfirm.TabIndex = 4;
            this.BtnConfirm.Text = "确认";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnExit.Location = new System.Drawing.Point(280, 269);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(100, 34);
            this.BtnExit.TabIndex = 6;
            this.BtnExit.Text = "退出";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LblCheck
            // 
            this.LblCheck.AutoSize = true;
            this.LblCheck.Location = new System.Drawing.Point(60, 155);
            this.LblCheck.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCheck.Name = "LblCheck";
            this.LblCheck.Size = new System.Drawing.Size(67, 15);
            this.LblCheck.TabIndex = 13;
            this.LblCheck.Text = "检测次数";
            // 
            // TbCheck
            // 
            this.TbCheck.Location = new System.Drawing.Point(149, 151);
            this.TbCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TbCheck.Name = "TbCheck";
            this.TbCheck.Size = new System.Drawing.Size(229, 25);
            this.TbCheck.TabIndex = 2;
            // 
            // BtnService
            // 
            this.BtnService.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnService.Location = new System.Drawing.Point(172, 269);
            this.BtnService.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnService.Name = "BtnService";
            this.BtnService.Size = new System.Drawing.Size(100, 34);
            this.BtnService.TabIndex = 5;
            this.BtnService.Text = "服务";
            this.BtnService.UseVisualStyleBackColor = true;
            this.BtnService.Click += new System.EventHandler(this.BtnService_Click);
            // 
            // CbEnabled
            // 
            this.CbEnabled.AutoSize = true;
            this.CbEnabled.Checked = true;
            this.CbEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbEnabled.Location = new System.Drawing.Point(59, 48);
            this.CbEnabled.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CbEnabled.Name = "CbEnabled";
            this.CbEnabled.Size = new System.Drawing.Size(119, 19);
            this.CbEnabled.TabIndex = 0;
            this.CbEnabled.Text = "启用服务功能";
            this.CbEnabled.UseVisualStyleBackColor = true;
            this.CbEnabled.CheckedChanged += new System.EventHandler(this.CbEnabled_CheckedChanged);
            // 
            // MainFrom
            // 
            this.AcceptButton = this.BtnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnExit;
            this.ClientSize = new System.Drawing.Size(443, 356);
            this.ControlBox = false;
            this.Controls.Add(this.CbEnabled);
            this.Controls.Add(this.BtnService);
            this.Controls.Add(this.LblCheck);
            this.Controls.Add(this.TbCheck);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.LblKmsAddress);
            this.Controls.Add(this.LblInterval);
            this.Controls.Add(this.TbInterval);
            this.Controls.Add(this.TbKmsAddress);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MF集群管控配置";
            this.Load += new System.EventHandler(this.MainFrom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbKmsAddress;
        private System.Windows.Forms.TextBox TbInterval;
        private System.Windows.Forms.Label LblInterval;
        private System.Windows.Forms.Label LblKmsAddress;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LblCheck;
        private System.Windows.Forms.TextBox TbCheck;
        private System.Windows.Forms.Button BtnService;
        private System.Windows.Forms.CheckBox CbEnabled;
    }
}

