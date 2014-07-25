using PhoneBookWcfTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;

namespace PhoneBookHost
{
    class Program
    {
        private const string exitCode = "EXIT";
        static void Main(string[] args)
        {
            XmlConfigurator.Configure(new System.IO.FileInfo("log4net.config"));

            Uri baseAddress = new Uri("http://localhost:8000/PhoneBook/Service");

            ServiceHost selfHost = new ServiceHost(typeof(PhoneBook), baseAddress);

            try
            {
                selfHost.AddServiceEndpoint(typeof(IPhoneBook), new WSHttpBinding(), "PhoneBook");

                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                selfHost.Description.Behaviors.Add(smb);

                selfHost.Open();
                Console.WriteLine(Messages.ServiceStart);
                Console.WriteLine(Messages.StopService, exitCode);
                Console.WriteLine();
                string userCommand;
                do
                {
                    userCommand = Console.ReadLine();
                }
                while (userCommand != exitCode);

                selfHost.Close();
            }
            catch (CommunicationException ce)
            {
                Console.WriteLine(Messages.ErrorOutPut, ce.Message);
                selfHost.Abort();
            }
        }
    }
}
