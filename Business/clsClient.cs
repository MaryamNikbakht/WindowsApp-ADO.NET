using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class clsClient : clsPerson
    {
        private string address;
        private string postalCode;
        private string email;
        private string username;
        private string password;
        private string city;
        private string typeUser;
        private string phone;
        private long refAgent;

        public string PostalCode
        {
            get { return postalCode; }
            set { postalCode = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string TypeClient
        {
            get { return typeUser; }
            set { typeUser = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public long RefAgent
        {
            get { return refAgent; }
            set { refAgent = value; }
        }
        public clsClient(long id, string name, string addresse, string postalCode, string email, string username, string password, string city, string type, string phone, long refAgent)
            : base( id,name)
        {
            this.username = username;
            this.password = password;
            this.typeUser = type;
            this.email = email;
            this.phone = phone;
            this.address = addresse;
            this.postalCode = postalCode;
            this.city = city;
            this.refAgent = refAgent;
        }
        public clsClient():base()
        {
            this.username = "";
            this.password = "";
            this.typeUser = "";
            this.email = "";
            this.phone = "";
            this.address = "";
            this.postalCode = "";
            this.city = "";
            this.refAgent = -1;
        }
    }
}
