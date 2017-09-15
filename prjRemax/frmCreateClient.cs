using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Business;

namespace prjRemax.GUI
{
    public partial class frmCreateClient : MetroFramework.Forms.MetroForm
    {
        string flag;
        DataTable tbClients;
        
        DataRow myRowClient;
         clsListClient clientList;
        int current;
        Int64 idAgent;
        string typeAgent;
        public frmCreateClient()
        {
            InitializeComponent();
        }

        private void frmCreateClient_Load(object sender, EventArgs e)
        {
            
            clientList = new clsListClient();
            cboTypeUser.DataSource = Enum.GetValues(typeof(clsEnumClientType.ClientType));
            typeAgent = frmLogin.gettypeUser.ToString().Trim();
            if (typeAgent == "admins")
            {
                tbClients = clientList.showAllClient();
                grdListUsers.DataSource = tbClients;
            }
            if (typeAgent == "agents")
            {
                idAgent = frmLogin.getIdUser;
                tbClients = clientList.showspecificClients(idAgent);
                grdListUsers.DataSource = tbClients;
                txtRefAgent.Enabled = false;
                txtRefAgent.Text = idAgent.ToString();
            }

        }

        private void btbSave_Click(object sender, EventArgs e)
        {
            clientList = new clsListClient();
            current = grdListUsers.SelectedRows[0].Index;
         
            ////try
            ////{


            myRowClient = (flag == "add".Trim()) ? tbClients.NewRow() : tbClients.Rows[current];


            clsClient myUser = new clsClient();

            current = clientList.NumberOfClients;
            current++;

            myUser.Id = current;

            myUser.Name = txtName.Text;
            myUser.Username = txtUserName.Text;
            myUser.Password = txtPassword.Text;
            myUser.TypeClient = cboTypeUser.Text;
            myUser.Phone = txtPhone.Text;
            myUser.Email = txtEmail.Text;
            myUser.Address = txtAddress.Text;
            myUser.City = txtCity.Text;
            myUser.RefAgent = Convert.ToInt64(txtRefAgent.Text);
            myUser.PostalCode = txtPostalCode.Text;

            clientList.Add(myUser);




            //==================================
            myRowClient["name"] = myUser.Name;
            myRowClient["userName"] = myUser.Username;
            myRowClient["password"] = myUser.Password;
            myRowClient["email"] = myUser.Email;
            myRowClient["Type"] = myUser.TypeClient;
            myRowClient["phone"] = myUser.Phone;
            myRowClient["addresse"] = myUser.Address;
            myRowClient["postalCode"] = myUser.PostalCode;
            myRowClient["city"] = myUser.City;
            myRowClient["refAgent"] = myUser.RefAgent;


            if (flag == "add".Trim())
            {
                clientList.addToDB(myRowClient);
                MessageBox.Show("User added successfully!", "ADD", MessageBoxButtons.OK);
                clearTXT();

                if (typeAgent == "admins")
                {
                    txtAddress.Clear();
                }
            }

            else if (flag == "edit".Trim())
            {

                clientList.EditToDB(myRowClient);
                MessageBox.Show("User updated successfully!", "Update", MessageBoxButtons.OK);
                clearTXT();
                if (typeAgent == "admins")
                {
                    txtAddress.Clear();
                }
            }


            btbAdd.Enabled = btbDelete.Enabled = btbEdit.Enabled = btbExit.Enabled = true;
            txtName.BackColor = txtUserName.BackColor = txtPassword.BackColor = txtEmail.BackColor = cboTypeUser.BackColor = txtPhone.BackColor = System.Drawing.Color.White;
            clearTXT();
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //}
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtPassword_Click(object sender, EventArgs e)
        {

        }

        private void grdListUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.grdListUsers.Rows[e.RowIndex];

                txtName.Text = row.Cells[1].Value.ToString();

                txtAddress.Text = row.Cells[2].Value.ToString();
                txtPostalCode.Text = row.Cells[3].Value.ToString();
                txtEmail.Text = row.Cells[4].Value.ToString();
                txtPassword.Text = row.Cells[6].Value.ToString();

                txtUserName.Text = row.Cells[5].Value.ToString();

                txtCity.Text = row.Cells[7].Value.ToString();
                cboTypeUser.Text = row.Cells[8].Value.ToString();
                txtPhone.Text = row.Cells[9].Value.ToString();
                txtRefAgent.Text = row.Cells[10].Value.ToString();




            }
        }
        private void clearTXT()
        {
            txtName.Text = txtAddress.Text = txtPostalCode.Text = txtEmail.Text = txtPassword.Text = txtUserName.Text = txtCity.Text = txtPhone.Text = "" ;
        }

        private void btbAdd_Click(object sender, EventArgs e)
        {
            if (typeAgent == "admins")
            {
                clearTXT();
                txtRefAgent.Clear();
                btbAdd.Enabled = btbDelete.Enabled = btbEdit.Enabled = btbExit.Enabled = false;
                flag = "add";

            }
            if (typeAgent == "agents")
            {
                clearTXT();
                btbAdd.Enabled = btbDelete.Enabled = btbEdit.Enabled = btbExit.Enabled = false;
                flag = "add";
            }
           
        }

        private void btbEdit_Click(object sender, EventArgs e)
        {
            if (typeAgent == "admins")
            {
                txtName.BackColor = txtAddress.BackColor = txtPostalCode.BackColor = txtEmail.BackColor = txtPassword.BackColor = txtUserName.BackColor = txtCity.BackColor = txtPhone.BackColor =txtRefAgent.BackColor= System.Drawing.Color.LightSkyBlue;
                btbAdd.Enabled = btbDelete.Enabled = btbEdit.Enabled = btbExit.Enabled = false;
                flag = "edit";
            }
            if (typeAgent == "agents")
            {
                txtName.BackColor = txtAddress.BackColor = txtPostalCode.BackColor = txtEmail.BackColor = txtPassword.BackColor = txtUserName.BackColor = txtCity.BackColor = txtPhone.BackColor = System.Drawing.Color.LightSkyBlue;
                btbAdd.Enabled = btbDelete.Enabled = btbEdit.Enabled = btbExit.Enabled = false;
                flag = "edit";
            }
           
        }

        private void btbDelete_Click(object sender, EventArgs e)
        {
            current = grdListUsers.SelectedRows[0].Index;
            if (MessageBox.Show("Are you sure you want to delet this client?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                clientList.Delete(current);
                if (typeAgent == "admins")
                {
                    txtAddress.Clear();
                }
            }
        }  
          

        private void btbCancel_Click(object sender, EventArgs e)
        {
            
            if (typeAgent == "admins")
            {
                clearTXT();
                txtRefAgent.Clear();
                btbAdd.Enabled = btbDelete.Enabled = btbEdit.Enabled = btbExit.Enabled = true;
                txtName.BackColor = txtAddress.BackColor = txtPostalCode.BackColor = txtEmail.BackColor = txtPassword.BackColor = txtUserName.BackColor = txtCity.BackColor = txtPhone.BackColor = txtRefAgent.BackColor = System.Drawing.Color.White;

            }
            if (typeAgent == "agents")
            {
                clearTXT();
                btbAdd.Enabled = btbDelete.Enabled = btbEdit.Enabled = btbExit.Enabled = true;
                txtName.BackColor = txtAddress.BackColor = txtPostalCode.BackColor = txtEmail.BackColor = txtPassword.BackColor = txtUserName.BackColor = txtCity.BackColor = txtPhone.BackColor = txtRefAgent.BackColor = System.Drawing.Color.White;
            }
        }

        private void btbExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
