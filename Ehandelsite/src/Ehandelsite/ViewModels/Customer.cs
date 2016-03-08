using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ehandelsite.ViewModels
{
    public class Customer
    {
        public Customer(string email, string pword, string ssn, int userType) : base(email, pword, ssn, userType)
        {
            OrderHistory = new List<Order>();
        }
        public int CompanyID { get; set; }
        public List<Order> OrderHistory { get; set; }
    }
}
