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
            this.SuspendLayout();
            // 
            // TbKmsAddress
            // 
            this.TbKmsAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbKmsAddress.Location = new System.Drawing.Point(116, 90);
            this.TbKmsAddress.Name = "TbKmsAddress";
            this.TbKmsAddress.Size = new System.Drawing.Size(173, 21);
            this.TbKmsAddress.TabIndex = 1;
            // 
            // TbInterval
            // 
            this.TbInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbInterval.Location = new System.Drawing.Point(116, 44);
            this.TbInterval.Name = "TbInterval";
            this.TbInterval.Size = new System.Drawing.Size(173, 21);
            this.TbInterval.TabIndex = 0;
            // 
            // LblInterval
            // 
            this.LblInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblInterval.AutoSize = true;
            this.LblInterval.Location = new System.Drawing.Point(43, 47);
            this.LblInterval.Name = "LblInterval";
            this.LblInterval.Size = new System.Drawing.Size(53, 12);
            this.LblInterval.TabIndex = 2;
            this.LblInterval.Text = "查询间隔";
            // 
            // LblKmsAddress
            // 
            this.LblKmsAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblKmsAddress.AutoSize = true;
            this.LblKmsAddress.Location = new System.Drawing.Point(49, 93);
            this.LblKmsAddress.Name = "LblKmsAddress";
            this.LblKmsAddress.Size = new System.Drawing.Size(47, 12);
            this.LblKmsAddress.TabIndex = 3;
            this.LblKmsAddress.Text = "KMS地址";
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnConfirm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnConfirm.Location = new System.Drawing.Point(54, 144);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(75, 23);
            this.BtnConfirm.TabIndex = 2;
            this.BtnConfirm.Text = "确认";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnExit.Location = new System.Drawing.Point(197, 144);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 9;
            this.BtnExit.Text = "退出";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // MainFrom
            // 
            this.AcceptButton = this.BtnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnExit;
            this.ClientSize = new System.Drawing.Size(332, 203);
            this.ControlBox = false;
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.LblKmsAddress);
            this.Controls.Add(this.LblInterval);
            this.Controls.Add(this.TbInterval);
            this.Controls.Add(this.TbKmsAddress);
            this.Name = "MainFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MF集群管控配置";
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
    }
}

