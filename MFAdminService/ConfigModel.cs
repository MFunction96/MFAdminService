using System.Net;

namespace MFAdminService
{
    public class ConfigModel
    {
        public int Interval { get; set; }
        public IPAddress KmsServer { get; set; }
    }
}
