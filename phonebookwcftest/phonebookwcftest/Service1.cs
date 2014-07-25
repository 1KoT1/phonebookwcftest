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
        private PhoneBookData data = new PhoneBookData(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PhoneBookTestDb.accdb; Persist Security Info=False;");
        public string GetFullNameByPhone(string phone)
        {
            var phoneBookItem = data.GetPhoneBookItemByPhone(phone);
            if (phoneBookItem != null)
                return BuildFullName(phoneBookItem);
            else
                return "";
        }

        private string BuildFullName(PhoneBookItem phoneBookItem)
        {
            return String.Format("{0} {1} {2}", phoneBookItem.Name, phoneBookItem.Patronymic, phoneBookItem.Surname);
        }
    }
}
