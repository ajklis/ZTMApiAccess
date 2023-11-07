using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTMApiAccess.Models
{
    class ServiceConfig
    {
        public string ApiKey { get; set; }

        public ServiceConfig(IConfiguration config)
        {
            ApiKey = config["ApiKey"];
        }
    }
}
