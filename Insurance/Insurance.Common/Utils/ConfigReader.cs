using Insurance.ApplicationCore.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.ApplicationCore.Utils
{
    public class ConfigReader : IConfigReader
    {
        private IConfiguration Configuration { get; set; }
        public ConfigReader(IConfiguration configurationRoot)
        {
            Configuration = configurationRoot;
        }
        public string RetrieveStringByKey(string key)
        {
            return $"{Configuration[$"AppSettings:{key}"]}";
        }
    }
}
