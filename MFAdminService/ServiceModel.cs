using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace MFAdminService
{
    public class ServiceModel
    {
        public string Nickname { get; set; }
        public IEnumerable<(string, bool)> Serivces { get; set; }
    }
}
