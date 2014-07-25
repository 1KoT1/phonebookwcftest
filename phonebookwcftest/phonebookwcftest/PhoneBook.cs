using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookWcfTest
{
    class PhoneBookData : IDisposable
    {
        private OleDbConnection connection;
        public PhoneBookData(string conStr)
        {
            connection = new OleDbConnection(conStr);
        }
        public PhoneBookItem GetPhoneBookItemByPhone(string phone)
        {
            var cmdStr = String.Format("SELECT Name, Surname, Patronymic FROM PhoneBook WHERE Phone=\"{0}\";", phone);
            var cmd = new OleDbCommand(cmdStr, connection);
            using (connection)
            {
                connection.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    // Интересует только первая строка.
                    if (reader.Read())
                    {
                        return new PhoneBookItem { Name = reader.GetString(0), Surname = reader.GetString(1), Patronymic = reader.GetString(2), Phone = phone };
                    }
                }

            }
            return null;
        }

        private bool disposed = false;
        public void Dispose()
        {
            Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                }

                connection.Close();

                disposed = true;
            }
        }

        
        ~PhoneBookData ()
        {
            Dispose(false);
        }
    
    }
}
