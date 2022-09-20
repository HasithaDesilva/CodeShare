using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.ApplicationCore.Interfaces
{
    public interface IConfigReader
    {
        string RetrieveStringByKey(string key);
    }
}
