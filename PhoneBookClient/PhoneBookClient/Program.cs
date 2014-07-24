using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneBookClient.PhoneBookServiceReference;

namespace PhoneBookClient
{
    class Program
    {
        const string exitCode = "EXIT";
        static void Main(string[] args)
        {
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
