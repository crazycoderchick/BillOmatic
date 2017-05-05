using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillOmatic.Classes
{
    [Serializable]
    public class CreditorInformation
    {
        private string _creditorName;
        private string _creditorAddress;
        private string _creditorPhoneNumber;
        private string _creditorURL;
        private string _username;
        private string _password;

        public string creditorName
        {
            get { return _creditorName; }
            set { _creditorName = value; }
        }

        public string creditorAddress
        {
            get { return _creditorAddress; }
            set { _creditorAddress = value; }
        }

        public string creditorPhoneNumber
        {
            get { return _creditorPhoneNumber; }
            set { _creditorPhoneNumber = value; }
        }

        public string creditorURL
        {
            get { return _creditorURL; }
            set { _creditorURL = value; }
        }

        public string username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string password
        {
            get { return _password; }
            set { _password = value; }
        }
    }
}
