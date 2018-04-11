namespace MFAdminService
{
    partial class ProjectInstaller
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

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.MFAdminServiceProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.MFAdminServiceInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // MFAdminServiceProcessInstaller
            // 
            this.MFAdminServiceProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalService;
            this.MFAdminServiceProcessInstaller.Password = null;
            this.MFAdminServiceProcessInstaller.Username = null;
            // 
            // MFAdminServiceInstaller
            // 
            this.MFAdminServiceInstaller.Description = "MFunction集群化管理服务";
            this.MFAdminServiceInstaller.DisplayName = "MFAdminService";
            this.MFAdminServiceInstaller.ServiceName = "MFAdminService";
            this.MFAdminServiceInstaller.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.MFAdminServiceProcessInstaller,
            this.MFAdminServiceInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller MFAdminServiceProcessInstaller;
        private System.ServiceProcess.ServiceInstaller MFAdminServiceInstaller;
    }
}