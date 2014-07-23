using phonebookwcftest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookHost
{
    class Program
    {
        private const string exitCode = "EXIT";
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:8000/NoteBook/");

            ServiceHost selfHost = new ServiceHost(typeof(PhoneBook), baseAddress);

            try
            {
                selfHost.AddServiceEndpoint(typeof(IPhoneBook), new WSHttpBinding(), "PhoneBook");

                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                selfHost.Description.Behaviors.Add(smb);

                selfHost.Open();
                Console.WriteLine("Служба запущена.");
                Console.WriteLine("Для остановки службы введите \"{0}\"", exitCode);
                Console.WriteLine();
                string userCommand;
                do
                {
                    userCommand = Console.ReadLine();
                }
                while (userCommand == exitCode);

                selfHost.Close();
            }
            catch (CommunicationException ce)
            {
                Console.WriteLine("Ошибка: {0}", ce.Message);
                selfHost.Abort();
            }
        }
    }
}
