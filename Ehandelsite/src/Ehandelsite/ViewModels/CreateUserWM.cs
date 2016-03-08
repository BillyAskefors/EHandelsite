using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ehandelsite.ViewModels
{
    public class CreateUserWM
    {
        public CreateUserWM(string email, string pword, string ssn, int userType)
        {
            EMail = email;
            PWord = pword;
            SSN = ssn;
            UserType = userType;

            AddressList = new List<Address>();
        }
        public string EMail { get; set; }
        public string PWord { get; set; }
        public string SSN { get; set; }
        public int UserType { get; set; }
        public List<Address> AddressList { get; set; } 
    }
}
