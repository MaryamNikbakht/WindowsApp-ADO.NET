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
    public partial class frmUserCreate : MetroFramework.Forms.MetroForm
    {
       string flag;
        DataTable tbUsers;
       
        DataRow myRowUser;
        clsListUser usersList;
        int current;
        Int64 idUs;
        public frmUserCreate()
        {
            InitializeComponent();
        }

        private void frmUserCreate_Load(object sender, EventArgs e)
        {
          

            usersList = new clsListUser();
            tbUsers=usersList.showAllUser();
            cboTypeUser.DataSource = Enum.GetValues(typeof(clsEnumUserType.UserType));
            grdListUsers.DataSource = tbUsers;

        }


        private void btbAdd_Click(object sender, EventArgs e)
        {
            clearTXT();
            btbAdd.Enabled = btbDelete.Enabled = btbEdit.Enabled = btbExit.Enabled = false;
            txtName.BackColor = txtUserName.BackColor = txtPassword.BackColor = txtEmail.BackColor = cboTypeUser.BackColor = txtPhone.BackColor = System.Drawing.Color.White;
            flag = "add";
        }

        private void btbEdit_Click(object sender, EventArgs e)
        {
            flag = "edit";
            btbAdd.Enabled = btbDelete.Enabled = btbEdit.Enabled = btbExit.Enabled = false;
            txtName.BackColor = txtUserName.BackColor = txtPassword.BackColor = txtEmail.BackColor = cboTypeUser.BackColor = txtPhone.BackColor = System.Drawing.Color.LightSkyBlue;
            cboTypeUser.Focus();
        }

        private void btbCancel_Click(object sender, EventArgs e)
        {
            btbAdd.Enabled = btbDelete.Enabled = btbEdit.Enabled = btbExit.Enabled = true;
            txtName.BackColor = txtUserName.BackColor = txtPassword.BackColor = txtEmail.BackColor = cboTypeUser.BackColor = txtPhone.BackColor = System.Drawing.Color.White;
            clearTXT();
        }
        private void clearTXT()
        {
            txtName.Text = "";

            txtUserName.Text = "";
            txtPassword.Text = "";
            txtEmail.Text = "";
            cboTypeUser.Text = "";

            txtPhone.Text = "";
        }
        private void grdListUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.grdListUsers.Rows[e.RowIndex];
                idUs= Convert.ToInt64(row.Cells[0].Value.ToString());
                txtName.Text = row.Cells[1].Value.ToString();

                txtUserName.Text = row.Cells[2].Value.ToString();
                txtPassword.Text = row.Cells[3].Value.ToString();
                txtEmail.Text = row.Cells[4].Value.ToString();
                cboTypeUser.Text = row.Cells[5].Value.ToString();

                txtPhone.Text = row.Cells[6].Value.ToString();
                

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btbExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btbSave_Click(object sender, EventArgs e)
        {
            usersList = new clsListUser();
           current = grdListUsers.SelectedRows[0].Index;
          

            myRowUser = (flag == "add".Trim()) ? tbUsers.NewRow() : usersList.showAllUser().Rows[current];


                clsUser myUser = new clsUser();

            current = usersList.NumberOfAgents;
            current++;

                myUser.Id = current;
                myUser.Name = txtName.Text;
                myUser.Username = txtUserName.Text;
                myUser.Password = txtPassword.Text;
                myUser.TypeUser = cboTypeUser.Text;
                myUser.Phone = txtPhone.Text;
                myUser.Email = txtEmail.Text;

                usersList.Add(myUser);




            //==================================
            myRowUser["name"] = myUser.Name;
            myRowUser["userName"] = myUser.Username;
            myRowUser["password"] = myUser.Password;
            myRowUser["email"] = myUser.Email;
            myRowUser["Type"] = myUser.TypeUser;
            myRowUser["phone"] = myUser.Phone;



                if (flag == "add".Trim())
                {               
                    usersList.addToDB(myRowUser);
                    MessageBox.Show("User added successfully!", "ADD", MessageBoxButtons.OK);

                }

                else if (flag == "edit".Trim())
                {

               // current = Convert.ToInt32(idUs);
                usersList.EditToDB(myRowUser);
                    MessageBox.Show("User updated successfully!", "Update", MessageBoxButtons.OK);
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

        private void btbDelete_Click(object sender, EventArgs e)
        {
            current = grdListUsers.SelectedRows[0].Index;
            if (MessageBox.Show("Are you sure you want to delet this user?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                
                usersList.Delete(current);

            }
        }
    }
}
