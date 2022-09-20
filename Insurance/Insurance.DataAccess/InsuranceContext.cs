using Insurance.ApplicationCore.Interfaces;
using Insurance.Common.Models;
using JsonFlatFileDataStore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Insurance.Infrastructure
{
    public class InsuranceContext
    {
        private IEnumerable<Customer> _customers;
        private IConfigReader _configReader;
        public InsuranceContext(IConfigReader configReader)
        {
            _configReader = configReader;

            string filePath = _configReader.RetrieveStringByKey("TempDirectory");
            filePath = Path.Combine(AppContext.BaseDirectory, filePath);
            var store = new DataStore(filePath);
            _customers = store.GetCollection<Customer>("Customer").AsQueryable();
        }

        public List<T> GetCollection<T>()
        {
            string type = typeof(T).Name;
            switch (type)
            {
                case "Customer": return _customers.ToList() as List<T>;
                default: return null;

            }
        }
    }
}
