using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;

using System.Data.OleDb;

namespace prjRemax.GUI
{
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        private static string userType;
        
        public static string gettypeUser
        {
            get { return userType; }
        }
        private static string userName;

        public static string getuserName
        {
            get { return userName; }
        }
        private static long userID;

        public static long getIdUser
        {
            get { return userID; }
        }
        private static string clientType;

        public static string gettypeClient
        {
            get { return clientType; }
        }
        private static string clientName;

        public static string getClientName
        {
            get { return clientName; }
        }
        private static long clientID;

        public static long getIdClient
        {
            get { return clientID; }
        }
       
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        
        }




        private void buttonLogInMain_Click(object sender, EventArgs e)
        {
          //  tbUser = clsDataSource.mySet.Tables["Users"];

            bool code = false;
            //===================================================================

          clsListUser listUs = new clsListUser();
            clsUser us = new clsUser();
            clsListClient listCl = new clsListClient();
            clsClient cl = new clsClient();
            if (listUs.Find_user_pass(textBoxUserName.Text, textBoxPassword.Text))
            {
                
               us= listUs.Get_ID_user_pass(textBoxUserName.Text, textBoxPassword.Text);
               
                userType = us.TypeUser;
               
                userID = Convert.ToInt64(us.Id);
                userName = us.Name;
             
                code = true;
                this.Hide();
            }
            if (listCl.Find_user_pass(textBoxUserName.Text, textBoxPassword.Text))
            {

                cl = listCl.Get_ID_user_pass(textBoxUserName.Text, textBoxPassword.Text);

                userType = "clients";

                clientID = Convert.ToInt64(cl.Id);
                clientName = cl.Name;
                code = true;
                this.Hide();
            }
            if (code==false)
            {
                MessageBox.Show("Enter corect username and password!");
            }

        }
    }
}
