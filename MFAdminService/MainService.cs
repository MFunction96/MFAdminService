using System.IO;
using System.ServiceProcess;
using System.Threading;
using Newtonsoft.Json;
using System;
using System.Diagnostics;

namespace MFAdminService
{
    public partial class MainService : ServiceBase
    {
        private ConfigModel Config { get; }
        private string FilePath { get; }
        private Thread Reader { get; }

        public MainService()
        {
            InitializeComponent();
            //Reader = new Thread(SolveRequest);
            FilePath = "C:\\Users\\User\\AppData\\Local\\MFAdminSerivce\\";
            //Config = JsonConvert.DeserializeObject<ConfigModel>($"{Environment.CurrentDirectory}\\MFServiceConfig.json");
        }

        protected override void OnStart(string[] args)
        {
            try
            {
                //var activation = new Process();
                //activation.StartInfo.CreateNoWindow = true;
                //activation.StartInfo.FileName = "cscript";
                //activation.StartInfo.Arguments = "slmgr.vbs /skms 192.168.4.253";
            }
            catch (Exception)
            {
            }
        }

        protected override void OnStop()
        {
            Reader.Interrupt();
            File.Delete(FilePath);
        }

        private void SolveRequest()
        {
            try
            {
                var sm = JsonConvert.DeserializeObject<ServiceModel[]>(FilePath);
                foreach (var item in sm)
                {
                    foreach (var serivce in item.Serivces)
                    {
                        ScSrvCtrl.ServiceName = serivce.Item1;
                        if (ScSrvCtrl.Status != ServiceControllerStatus.Running && serivce.Item2)
                        {
                            ScSrvCtrl.Start();
                        }
                        else if (ScSrvCtrl.Status != ServiceControllerStatus.Stopped && !serivce.Item2)
                        {
                            ScSrvCtrl.Stop();
                        }
                    }
                }
            }
            catch (Exception) { }
            Thread.Sleep(5000);
        }

        protected override void OnPause()
        {
            Reader.Interrupt();
        }

        protected override void OnContinue()
        {
            Reader.Start();
        }
    }
}
