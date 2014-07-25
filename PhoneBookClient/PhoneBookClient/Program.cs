using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneBookClient.PhoneBookServiceReference;
using log4net;
using log4net.Config;
using InputValidation;

namespace PhoneBookClient
{
    class Program
    {
        const string exitCode = "EXIT";

        private static readonly ILog log = LogManager.GetLogger(typeof(Program));
        static void Main(string[] args)
        {
            XmlConfigurator.Configure(new System.IO.FileInfo("log4net.config"));
            try
            {
                var phoneBook = new PhoneBookClient.PhoneBookServiceReference.PhoneBookClient();

                Console.WriteLine(Messages.InputPhoneOrExit, exitCode);
                var userInPut = Console.ReadLine();
                while (userInPut != exitCode)
                {
                    if (PhoneValidator.PhoneValidate(userInPut))
                    {
                        try
                        {
                            Console.WriteLine(phoneBook.GetFullNameByPhone(userInPut));
                        }
                        catch (Exception ex)
                        {
                            log.Error(String.Format(Messages.RequestNameByPhoneErrLog, ex.Message));
                            Console.WriteLine(Messages.RequestErr);
                        }
                    }
                    else
                    {
                        Console.WriteLine(Messages.PhoneUnvalidate);
                    }
                    userInPut = Console.ReadLine();

                }
            }
            catch(Exception ex)
            {
                log.Error(String.Format(Messages.Err, ex.Message));
            }
        }
    }
}
