using System.IO;
using System.ServiceProcess;
using System.Threading;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MFAdminService
{
    /// <inheritdoc />
    /// <summary>
    /// </summary>
    public partial class MainService : ServiceBase
    {
        /// <summary>
        /// 
        /// </summary>
        private string ErrorLog { get; }
        /// <summary>
        /// 
        /// </summary>
        private SettingModel Settings { get; }
        /// <summary>
        /// 
        /// </summary>
        private string FilePath { get; }
        /// <summary>
        /// 
        /// </summary>
        private Thread Reader { get; }
        /// <summary>
        /// 
        /// </summary>
        private Thread Activation { get; }
        /// <inheritdoc />
        /// <summary>
        /// </summary>
        public MainService()
        {
            InitializeComponent();
            FilePath = @"C:\ProgramData\MFAdmin";
            ErrorLog = $"{FilePath}\\error.json";
            Settings = JsonConvert.DeserializeObject<SettingModel>(File.ReadAllText($"{FilePath}\\settings.json"));
            Reader = new Thread(SolveRequest);
            Activation = new Thread(Activate);
        }
        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="args"></param>
        protected override void OnStart(string[] args)
        {
            try
            {
                Reader.Start();
                Activation.Start();
            }
            catch (Exception e)
            {
                WriteErrorLog(e);
            }
        }
        /// <inheritdoc />
        /// <summary>
        /// </summary>
        protected override void OnStop()
        {
            Reader.Interrupt();
        }
        /// <summary>
        /// 
        /// </summary>
        private void SolveRequest()
        {
            try
            {
                var items = JsonConvert.DeserializeObject<IEnumerable<ServiceModel>>($"{FilePath}\\services.json");
                var services = ServiceController.GetServices();
                foreach (var item in items)
                {
                    foreach (var service in item.Services)
                    {
                        var s = services.First(tmp => tmp.ServiceName == service);
                        if (s is null) throw new NullReferenceException();
                        if (item.Switch && s.Status != ServiceControllerStatus.Running)
                        {
                            s.Start();
                        }
                        else if (!item.Switch && s.Status != ServiceControllerStatus.Stopped)
                        {
                            s.Stop();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                WriteErrorLog(e);
            }

            Thread.Sleep(Settings.Interval);
        }
        /// <summary>
        /// 
        /// </summary>
        private void Activate()
        {
            try
            {
                var winact = new Process
                {
                    StartInfo =
                {
                    CreateNoWindow = true,
                    FileName = "cscript",
                    Arguments = $"slmgr.vbs /skms {Settings.KmsServer}"
                }
                };
                winact.Start();
                int i;
                for (i = 0; i < 5; i++)
                {
                    Thread.Sleep(5000);
                    if (!winact.HasExited) break;
                }
                if (i == 5) throw new Exception("Windows Activation Timeout!");
                winact.Dispose();
                winact = new Process
                {
                    StartInfo =
                {
                    CreateNoWindow = true,
                    FileName = "cscript",
                    Arguments = "slmgr.vbs /ato"
                }
                };
                winact.Start();
                for (i = 0; i < 5; i++)
                {
                    Thread.Sleep(5000);
                    if (!winact.HasExited) break;
                }
                if (i == 5) throw new Exception("Windows Activation Timeout!");
                var officeact = new Process
                {
                    StartInfo =
                {
                    CreateNoWindow = true,
                    FileName = "cscript",
                    Arguments = $"\"C:\\Program Files\\Microsoft Office\\Office16\\ospp.vbs\" /sethst:{Settings.KmsServer}"
                }
                };
                officeact.Start();
                for (i = 0; i < 5; i++)
                {
                    Thread.Sleep(5000);
                    if (!officeact.HasExited) break;
                }
                if (i == 5) throw new Exception("Office Activation Timeout!");
                officeact.Dispose();
                officeact = new Process
                {
                    StartInfo =
                {
                    CreateNoWindow = true,
                    FileName = "cscript",
                    Arguments = "\"C:\\Program Files\\Microsoft Office\\Office16\\ospp.vbs\" /act"
                }
                };
                officeact.Start();
                for (i = 0; i < 5; i++)
                {
                    Thread.Sleep(5000);
                    if (!officeact.HasExited) break;
                }
                if (i == 5) throw new Exception("Office Activation Timeout!");
            }
            catch (Exception e)
            {
                WriteErrorLog(e);
            }
        }

        private void WriteErrorLog(Exception e)
        {
            var json = JsonConvert.SerializeObject(e, Formatting.Indented);
            File.AppendAllText(ErrorLog, json);
        }
        /// <inheritdoc />
        /// <summary>
        /// </summary>
        protected override void OnPause()
        {
            Reader.Interrupt();
        }
        /// <inheritdoc />
        /// <summary>
        /// </summary>
        protected override void OnContinue()
        {
            Reader.Start();
        }
    }
}
