using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFAdminPanel.Controllers
{
    public class ServiceController
    {
        public string StoreFilePath { get; }

        public string AccessFilePath { get; }

        public ServiceController()
        {
            AccessFilePath = $"{Environment.CurrentDirectory}\\ServiceStatus.json";
            StoreFilePath = $"{Environment.CurrentDirectory}\\ServiceConfig.json";
        }

        public Task SendStart(string service)
        {
            return Task.Run(() =>
            {

            });
        }
    }
}
