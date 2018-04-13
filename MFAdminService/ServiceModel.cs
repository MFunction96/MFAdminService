using System.Collections.Generic;

namespace MFAdminService
{
    public class ServiceModel
    {
        public string Nickname { get; set; }
        public IEnumerable<string> Services { get; set; }
        public bool Switch { get; set; }
    }
}
