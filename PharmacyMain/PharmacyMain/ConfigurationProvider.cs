using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using PharmacyMain.Core.Interfaces;

namespace PharmacyMain
    {
        public class ConfigurationProvider : IConfiguraionProvider
        {
            public Dictionary<string, object> Configuration { get; set; }

            public ConfigurationProvider()
            {
                DeserializeConfirguration();
            }

            private void DeserializeConfirguration()
            {
                try
                {
                    var data = File.ReadAllText(Environment.CurrentDirectory + "\\config.json");
                    Configuration = JsonConvert.DeserializeObject<Dictionary<string, object>>(data);
                }
                catch (Exception e)
                {
                    throw;
                }

            }
        }
    }

}
}
