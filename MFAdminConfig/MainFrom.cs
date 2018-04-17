﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.AccessControl;
using System.Windows.Forms;

namespace MFAdminConfig
{
    /// <inheritdoc />
    /// <summary>
    /// </summary>
    public partial class MainFrom : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public IList<ServiceModel> Services { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public SettingModel Setting { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        private string Path { get; }
        /// <summary>
        /// 
        /// </summary>
        private string ErrorLog { get; }
        /// <inheritdoc />
        /// <summary>
        /// </summary>
        public MainFrom()
        {
            InitializeComponent();
            Path = @"C:\ProgramData\MFAdmin";
            var dict = new DirectoryInfo(Path);
            if (!dict.Exists) dict.Create();
            ErrorLog = $"{Path}\\error.log";
            try
            {
                var json = File.ReadAllText($"{Path}\\settings.json");
                Setting = JsonConvert.DeserializeObject<SettingModel>(json);
                json = File.ReadAllText($"{Path}\\services.json");
                Services = JsonConvert.DeserializeObject<List<ServiceModel>>(json) ?? new List<ServiceModel>();
                /*var list = JObject.Parse(File.ReadAllText($"{Path}\\services.json")).Properties();
                foreach (var obj in list)
                {
                    // JToken.ToObject is a helper method that uses JsonSerializer internally
                    var service = obj.ToObject<ServiceModel>();
                    Services.Add(service);
                }*/
            }
            catch (Exception e)
            {
                WriteErrorLog(e);
                Services = new List<ServiceModel>();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            Setting = new SettingModel
            {
                Enabled = CbEnabled.Checked,
                Interval = int.Parse(TbInterval.Text),
                Check = int.Parse(TbCheck.Text),
                KmsServer = TbKmsAddress.Text
            };
            var dir = new DirectoryInfo(Path);
            if (!dir.Exists) dir.Create();
            var json = JsonConvert.SerializeObject(Setting, Formatting.Indented);
            File.WriteAllText($"{Path}\\settings.json", json);
            json = Services.Count == 0 ? string.Empty : JsonConvert.SerializeObject(Services, Formatting.Indented);
            File.WriteAllText($"{Path}\\services.json", json);
            var fileInfo = new FileInfo($"{Path}\\services.json");
            var fileSecurity = fileInfo.GetAccessControl();
            fileSecurity.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.FullControl, AccessControlType.Allow));
            fileInfo.SetAccessControl(fileSecurity);
            MessageBox.Show(@"操作成功完成", @"提示", MessageBoxButtons.OK);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnService_Click(object sender, EventArgs e)
        {
            var form = new ServiceForm(Services)
            {
                ServiceAction = services => Services = services
            };
            form.ShowDialog(this);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbEnabled_CheckedChanged(object sender, EventArgs e)
        {
            BtnService.Enabled = CbEnabled.Enabled;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        private void WriteErrorLog(Exception e)
        {
            var json = $"{DateTime.Now}\n{JsonConvert.SerializeObject(e, Formatting.Indented)}";
            File.AppendAllText(ErrorLog, json);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainFrom_Load(object sender, EventArgs e)
        {
            if (Setting is null) return;
            CbEnabled.Checked = Setting.Enabled;
            TbCheck.Text = Setting.Check.ToString();
            TbInterval.Text = Setting.Interval.ToString();
            TbKmsAddress.Text = Setting.KmsServer;
        }
    }
}
