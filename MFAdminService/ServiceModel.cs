﻿using System.Collections.Generic;

namespace MFAdminService
{
    public class ServiceModel
    {
        public string Nickname { get; set; }
        public IList<string> Services { get; set; }
        public bool Enabled { get; set; }

        public ServiceModel()
        {
            Services = new List<string>();
        }
    }
}
