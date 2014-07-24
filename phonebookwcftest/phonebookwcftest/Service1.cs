using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PhoneBookWcfTest
{
    public class PhoneBook : IPhoneBook
    {
        public string GetFullNameByPhone(string phone)
        {           
            return "test";
        }
    }
}
