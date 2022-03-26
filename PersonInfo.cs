using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaValidate
{
    public class CustomerInfo
    {
        public string FirstName;
        public string LastName;
        public string Email;
        public string PhoneNumber;
        public string Password;
        public bool IsValidByLamda(CustomerInfo customerInfo)
        {
            List<Func<CustomerInfo, bool>> rules = new List<Func<CustomerInfo, bool>>
    {
        x => String.IsNullOrEmpty(x.FirstName),
        x => String.IsNullOrEmpty(x.LastName),
        x => string.IsNullOrEmpty(x.Email),
        x => String.IsNullOrEmpty(x.PhoneNumber),
        x => String.IsNullOrEmpty(x.Password)
    };

            return rules.All(x => x(customerInfo) == false);
        }
    }
}
