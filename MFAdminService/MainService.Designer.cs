namespace MFAdminService
{
    partial class MainService
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
            this.ProcProcessor = new System.Diagnostics.Process();
            this.ScSrvCtrl = new System.ServiceProcess.ServiceController();
            // 
            // ProcProcessor
            // 
            this.ProcProcessor.StartInfo.Domain = "";
            this.ProcProcessor.StartInfo.LoadUserProfile = false;
            this.ProcProcessor.StartInfo.Password = null;
            this.ProcProcessor.StartInfo.StandardErrorEncoding = null;
            this.ProcProcessor.StartInfo.StandardOutputEncoding = null;
            this.ProcProcessor.StartInfo.UserName = "";
            // 
            // MainService
            // 
            this.ServiceName = "Service1";

        }

        #endregion

        private System.Diagnostics.Process ProcProcessor;
        private System.ServiceProcess.ServiceController ScSrvCtrl;
    }
}
