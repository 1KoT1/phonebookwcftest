using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookWcfTest
{
    class PhoneBookData
    {
        PhoneBookItem GetPhoneBookItemByPhone(string phone)
        {
            /// DoIt;
            return new PhoneBookItem { Surname = "test", Name = "test", Patronymic = "test", Phone = phone };
        }
    }
}
