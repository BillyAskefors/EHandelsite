using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ehandelsite.ViewModels
{
    public class Company
    {
        public Company(string name, string webSite, string id)
        {
            Name = name;
            WebSite = webSite;
            ID = id;

            ProdcutList = new List<Product>();
            AddressList = new List<Address>();
        }
        public string Name { get; set; }
        public string WebSite { get; set; }
        public string ID { get; set; }
        public List<Product> ProdcutList { get; set; }
        public List<Address> AddressList { get; set; }
    }
}
