using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;


namespace WebApplication1.Models
{
    public class Root
    {
        public List<ModelProduct> ModelProduct { get; set; }

        static public List<ModelProduct> getJson()
        {
            string strr = File.ReadAllText("user1.json");
            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(strr);
            return myDeserializedClass.ModelProduct;
        }
    }
}
