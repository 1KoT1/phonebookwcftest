using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputValidation
{
    public class PhoneValidator
    {
        public static bool PhoneValidate(string phone)
        {
            return phone.All(ch => Char.IsDigit(ch));
        }
    }
}
