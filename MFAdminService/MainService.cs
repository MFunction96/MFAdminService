using System.IO;
using System.ServiceProcess;
using System.Threading;
using Newtonsoft.Json;

namespace MFAdminService
{
    public partial class MainService : ServiceBase
    {

        private string FilePath { get; set; }
        private Thread Reader { get; set; }

        public MainService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {

            FilePath = $"{System.Environment.CurrentDirectory}\\ServiceStatus.json";
            File.Create(FilePath);
            Reader = new Thread(SolveRequest);
            Reader.Start();
        }

        protected override void OnStop()
        {
            Reader.Interrupt();
            File.Delete(FilePath);
        }

        private void SolveRequest()
        {
            var sm = JsonConvert.DeserializeObject<ServiceModel>(FilePath);
            foreach (var serivce in sm.Serivces)
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
