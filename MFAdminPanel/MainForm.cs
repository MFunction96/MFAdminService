using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MFAdminPanel
{
    /// <inheritdoc />
    /// <summary>
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// 
        /// </summary>
        private IList<ServiceModel> Services { get; set; }
        /// <summary>
        /// 
        /// </summary>
        private IDictionary<string, bool> Status { get; }
        /// <summary>
        /// 
        /// </summary>
        public SettingModel Setting { get; set; }
        /// <summary>
        /// 
        /// </summary>
        private string FilePath { get; }
        /// <summary>
        /// 
        /// </summary>
        private string ErrorLog { get; }
        /// <summary>
        /// 
        /// </summary>
        private Thread Check { get; }
        /// <inheritdoc />
        /// <summary>
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            FilePath = @"C:\ProgramData\MFAdmin";
            ErrorLog = $"{FilePath}\\error.log";
            Check = new Thread(UpdateStatus);
            Status = new Dictionary<string, bool>();
            try
            {
                ReadConfig();
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
        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateSettings();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        private void WriteErrorLog(Exception e)
        {
            var json = $"{DateTime.Now} {Environment.CommandLine}\n{JsonConvert.SerializeObject(e, Formatting.Indented)}";
            File.AppendAllText(ErrorLog, json);
        }
        /// <summary>
        /// 
        /// </summary>
        private async void UpdateStatus()
        {
            try
            {
                if (Setting.Enabled)
                {
                    foreach (var service in Services)
                    {
                        Status[service.Nickname] = await CheckStatus(service.Nickname);
                        if (service.Nickname == @"SQLServer")
                        {
                            BtnSqlServer.Text = Status[service.Nickname] ? @"停止" : @"启动";
                        }
                    }
                }
                Thread.Sleep(Setting.Interval);
            }
            catch (Exception e)
            {
                WriteErrorLog(e);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nickName"></param>
        /// <returns></returns>
        private Task<bool> CheckStatus(string nickName)
        {
            return Task.Run(() =>
            {
                try
                {
                    ReadConfig();
                    UpdateSettings();
                    var services = ServiceController.GetServices();
                    var item = Services.First(tmp => tmp.Nickname == nickName);
                    if (item.Enabled)
                    {

                    }
                }
                catch (Exception e)
                {
                    WriteErrorLog(e);
                }
                
                return true;
            });
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Check.Interrupt();
        }
        /// <summary>
        /// 
        /// </summary>
        private void ReadConfig()
        {
            var json = File.ReadAllText($"{FilePath}\\settings.json");
            Setting = JsonConvert.DeserializeObject<SettingModel>(json);
            json = File.ReadAllText($"{FilePath}\\services.json");
            Services = JsonConvert.DeserializeObject<List<ServiceModel>>(json) ?? new List<ServiceModel>();
        }
        /// <summary>
        /// 
        /// </summary>
        private void UpdateSettings()
        {
            LblEnabled.Text = Setting.Enabled ? @"服务管控：启用" : @"服务管控：禁用";
            LblInterval.Text = $@"查询/操作间隔：{Setting.Interval}毫秒";
            LblCheck.Text = $@"查询次数上限：{Setting.Check}";
            LblKmsServer.Text = $@"KMS服务器：{Setting.KmsServer}";
        }
    }
}
