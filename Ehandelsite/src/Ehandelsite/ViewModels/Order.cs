using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ehandelsite.ViewModels
{
    public class Order
    {
        public Order(int id, int number, string status, DateTime date, int vat)
        {
            ID = id;
            Number = number;
            Status = status;
            Date = date;
            VAT = vat;

            ProdcutList = new List<Product>();
        }
        public int ID { get; set; }
        public int Number { get; set; }
        public string Status { get; set; }
        public DateTime Date { get; set; }
        public int VAT { get; set; }
        public List<Product> ProdcutList { get; set; }
    }
}
