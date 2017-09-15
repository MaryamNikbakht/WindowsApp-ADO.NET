using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class clsUser:clsPerson
    {
       
        private string username;
        private string password;
        private string phone;
        private string email;
        private string typeUser;

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
        public string TypeUser
        {
            get { return typeUser; }
            set { typeUser = value; }
        }


        public clsUser(long id, string name, string username, string password,string email, string type, string phone)
            : base( id,name)
        {
            this.username = username;
            this.password = password;
            this.typeUser = type;
            this.email = email;
            this.phone = phone;
        }
        public clsUser():base()
        {
            this.username = "";
            this.password = "";
            this.typeUser = "";
            this.email = "";
            this.phone = "";
        }

    }
}
