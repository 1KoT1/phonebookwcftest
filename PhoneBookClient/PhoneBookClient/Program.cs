using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneBookClient.PhoneBookServiceReference;
using log4net;
using log4net.Config;

namespace PhoneBookClient
{
    class Program
    {
        const string exitCode = "EXIT";
        static void Main(string[] args)
        {
            XmlConfigurator.Configure(new System.IO.FileInfo("log4net.config"));

            var phoneBook = new PhoneBookClient.PhoneBookServiceReference.PhoneBookClient();

            Console.WriteLine(Messages.InputPhoneOrExit, exitCode);
            var userInPut = Console.ReadLine();
            while (userInPut != exitCode)
            {
                Console.WriteLine(phoneBook.GetFullNameByPhone(userInPut));
                userInPut = Console.ReadLine();
            }
        }
    }
}
