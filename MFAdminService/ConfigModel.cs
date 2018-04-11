using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MFAdminService
{
    public class ConfigModel
    {
        public int Interval { get; set; }
        public IPAddress KmsServer { get; set; }
    }
}
