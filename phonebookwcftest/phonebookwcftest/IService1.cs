using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PhoneBookWcfTest
{
    [ServiceContract(Namespace = "http://Microsoft.ServiceModel.Samples")]
    public interface IPhoneBook
    {
        [OperationContract]
        string GetFullNameByPhone(string phone);
    }
}
