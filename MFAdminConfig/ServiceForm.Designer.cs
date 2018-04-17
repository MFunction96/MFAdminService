namespace MFAdminConfig
{
    partial class ServiceForm
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
            this.CbItems = new System.Windows.Forms.ComboBox();
            this.BtnNewItem = new System.Windows.Forms.Button();
            this.BtnDelItem = new System.Windows.Forms.Button();
            this.LbServices = new System.Windows.Forms.ListBox();
            this.BtnAddSerivce = new System.Windows.Forms.Button();
            this.BtnEditService = new System.Windows.Forms.Button();
            this.BtnDelService = new System.Windows.Forms.Button();
            this.BtnEditItem = new System.Windows.Forms.Button();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.CbEnabled = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CbItems
            // 
            this.CbItems.FormattingEnabled = true;
            this.CbItems.Location = new System.Drawing.Point(41, 27);
            this.CbItems.Name = "CbItems";
            this.CbItems.Size = new System.Drawing.Size(269, 20);
            this.CbItems.Sorted = true;
            this.CbItems.TabIndex = 0;
            this.CbItems.SelectedIndexChanged += new System.EventHandler(this.CbItems_SelectedIndexChanged);
            // 
            // BtnNewItem
            // 
            this.BtnNewItem.Location = new System.Drawing.Point(316, 27);
            this.BtnNewItem.Name = "BtnNewItem";
            this.BtnNewItem.Size = new System.Drawing.Size(75, 23);
            this.BtnNewItem.TabIndex = 1;
            this.BtnNewItem.Text = "新建项目";
            this.BtnNewItem.UseVisualStyleBackColor = true;
            this.BtnNewItem.Click += new System.EventHandler(this.BtnNewItem_Click);
            // 
            // BtnDelItem
            // 
            this.BtnDelItem.Enabled = false;
            this.BtnDelItem.Location = new System.Drawing.Point(478, 27);
            this.BtnDelItem.Name = "BtnDelItem";
            this.BtnDelItem.Size = new System.Drawing.Size(75, 23);
            this.BtnDelItem.TabIndex = 3;
            this.BtnDelItem.Text = "删除项目";
            this.BtnDelItem.UseVisualStyleBackColor = true;
            this.BtnDelItem.Click += new System.EventHandler(this.BtnDelItem_Click);
            // 
            // LbServices
            // 
            this.LbServices.FormattingEnabled = true;
            this.LbServices.ItemHeight = 12;
            this.LbServices.Location = new System.Drawing.Point(41, 66);
            this.LbServices.Name = "LbServices";
            this.LbServices.Size = new System.Drawing.Size(431, 256);
            this.LbServices.Sorted = true;
            this.LbServices.TabIndex = 3;
            // 
            // BtnAddSerivce
            // 
            this.BtnAddSerivce.Enabled = false;
            this.BtnAddSerivce.Location = new System.Drawing.Point(477, 131);
            this.BtnAddSerivce.Name = "BtnAddSerivce";
            this.BtnAddSerivce.Size = new System.Drawing.Size(75, 23);
            this.BtnAddSerivce.TabIndex = 4;
            this.BtnAddSerivce.Text = "新建服务";
            this.BtnAddSerivce.UseVisualStyleBackColor = true;
            this.BtnAddSerivce.Click += new System.EventHandler(this.BtnAddSerivce_Click);
            // 
            // BtnEditService
            // 
            this.BtnEditService.Enabled = false;
            this.BtnEditService.Location = new System.Drawing.Point(477, 174);
            this.BtnEditService.Name = "BtnEditService";
            this.BtnEditService.Size = new System.Drawing.Size(75, 23);
            this.BtnEditService.TabIndex = 5;
            this.BtnEditService.Text = "编辑服务";
            this.BtnEditService.UseVisualStyleBackColor = true;
            this.BtnEditService.Click += new System.EventHandler(this.BtnEditService_Click);
            // 
            // BtnDelService
            // 
            this.BtnDelService.Enabled = false;
            this.BtnDelService.Location = new System.Drawing.Point(477, 218);
            this.BtnDelService.Name = "BtnDelService";
            this.BtnDelService.Size = new System.Drawing.Size(75, 23);
            this.BtnDelService.TabIndex = 6;
            this.BtnDelService.Text = "删除服务";
            this.BtnDelService.UseVisualStyleBackColor = true;
            this.BtnDelService.Click += new System.EventHandler(this.BtnDelService_Click);
            // 
            // BtnEditItem
            // 
            this.BtnEditItem.Enabled = false;
            this.BtnEditItem.Location = new System.Drawing.Point(397, 27);
            this.BtnEditItem.Name = "BtnEditItem";
            this.BtnEditItem.Size = new System.Drawing.Size(75, 23);
            this.BtnEditItem.TabIndex = 2;
            this.BtnEditItem.Text = "编辑项目";
            this.BtnEditItem.UseVisualStyleBackColor = true;
            this.BtnEditItem.Click += new System.EventHandler(this.BtnEditItem_Click);
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnConfirm.Location = new System.Drawing.Point(134, 340);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(75, 23);
            this.BtnConfirm.TabIndex = 7;
            this.BtnConfirm.Text = "确认";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(349, 340);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 8;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // CbEnabled
            // 
            this.CbEnabled.AutoSize = true;
            this.CbEnabled.Enabled = false;
            this.CbEnabled.Location = new System.Drawing.Point(478, 92);
            this.CbEnabled.Name = "CbEnabled";
            this.CbEnabled.Size = new System.Drawing.Size(48, 16);
            this.CbEnabled.TabIndex = 9;
            this.CbEnabled.Text = "启用";
            this.CbEnabled.UseVisualStyleBackColor = true;
            // 
            // ServiceForm
            // 
            this.AcceptButton = this.BtnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(564, 383);
            this.ControlBox = false;
            this.Controls.Add(this.CbEnabled);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.BtnEditItem);
            this.Controls.Add(this.BtnDelService);
            this.Controls.Add(this.BtnEditService);
            this.Controls.Add(this.BtnAddSerivce);
            this.Controls.Add(this.LbServices);
            this.Controls.Add(this.BtnDelItem);
            this.Controls.Add(this.BtnNewItem);
            this.Controls.Add(this.CbItems);
            this.Name = "ServiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServiceForm";
            this.Load += new System.EventHandler(this.ServiceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbItems;
        private System.Windows.Forms.Button BtnNewItem;
        private System.Windows.Forms.Button BtnDelItem;
        private System.Windows.Forms.ListBox LbServices;
        private System.Windows.Forms.Button BtnAddSerivce;
        private System.Windows.Forms.Button BtnEditService;
        private System.Windows.Forms.Button BtnEditItem;
        private System.Windows.Forms.Button BtnDelService;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.CheckBox CbEnabled;
    }
}