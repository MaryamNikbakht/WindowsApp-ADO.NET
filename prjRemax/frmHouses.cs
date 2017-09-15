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
    public partial class frmHouses : MetroFramework.Forms.MetroForm
    {
        clsListHouse house;
        clsHouse aHouse;
        clsListUser agents;
    
     
        DataRow myRow;
        string mode;
        Int64 idAgentFromLog;
        int current;
        frmLogin log;
        string type;
  

        public frmHouses()
        {
            InitializeComponent();
        }

        private void frmHouses_Load(object sender, EventArgs e)
        {
            log = new frmLogin();
            gridResultHouses.Columns.Clear();


             type = frmLogin.gettypeUser.ToString();
             idAgentFromLog = Convert.ToInt64(frmLogin.getIdUser.ToString());
       

            house = new clsListHouse();
           
           cboTypeHouse.DataSource = Enum.GetValues(typeof(clsEnumStatus.Status));
           fillAgentName();
            
     



        }


        private void fillAgentName()
        {
            agents = new clsListUser();
          
            if (type == "admins")
            {

                gridResultHouses.DataSource = house.showAllHouse();
                var agentCombo = (from ag in agents.showAllUser().AsEnumerable()
                                  where ag.Field<string>("Type")=="agents".Trim()
                                  select new
                                  {
                                      refAgent = ag.Field<int>("ID"),
                                      agName = ag.Field<string>("name")
                                  }).ToList();

                cboAgent.DisplayMember = "agName";
                cboAgent.ValueMember = "refAgent";
                cboAgent.DataSource = agentCombo;



            }
            if (type == "agents")
            {
                
                gridResultHouses.DataSource = house.showSpecificHouse(idAgentFromLog);
                cboAgent.Items.Add(frmLogin.getuserName.ToString());
            }


        }
       

        private void btbAdd_Click(object sender, EventArgs e)
        {
            mode = "add";
            clearTXT();
            btbAdd.Enabled = btbDelete.Enabled = btbEdit.Enabled = btbExit.Enabled = false;
        }

        private void btbEdit_Click(object sender, EventArgs e)
        {
            mode = "edit";
            txtHouseTYp.BackColor = txtAddress.BackColor = txtLocation.BackColor = txtPrice.BackColor = txtSurface.BackColor = txtNbRoom.BackColor = System.Drawing.Color.LightSkyBlue;
            btbAdd.Enabled = btbDelete.Enabled = btbEdit.Enabled = btbExit.Enabled = false;
        }

        private void btbSave_Click(object sender, EventArgs e)
        {
            house = new clsListHouse();
            current=gridResultHouses.SelectedRows[0].Index;

            try
            {
                

            myRow = (mode == "add".Trim()) ? house.showAllHouse().NewRow() : house.showAllHouse().Rows[current];


            clsHouse myhouse = new clsHouse();
            current = house.NbOfHouses;
            current++;

            myhouse.HouseID = current;

            myhouse.HouseAddress = txtAddress.Text;
            myhouse.Location = txtLocation.Text;
            myhouse.HousePrice = Convert.ToInt32(txtPrice.Text);
            myhouse.HouseSize = Convert.ToInt64(txtSurface.Text);
            myhouse.HouseType = txtHouseTYp.Text;
            myhouse.NbRoom = Convert.ToInt32(txtNbRoom.Text);
            myhouse.Pool = Convert.ToBoolean(chkPool.Checked);
            myhouse.Status = cboTypeHouse.Text;
            string refAgentName = cboAgent.Text;

            DataRow[] agentRowID = agents.showAllUser().Select("name='" + refAgentName + "'");

            myhouse.AgentId = Convert.ToInt64(agentRowID[0]["ID"]);

            //   myRow["ReferAgent"] = Convert.ToInt64(agentID);

            house.Add(myhouse);

      

            //==================================
            myRow["HouseType"] = myhouse.HouseType;
            myRow["HouseNumber"] = myhouse.HouseAddress;
            myRow["Location"] = myhouse.Location;
            myRow["Surface"] = myhouse.HouseSize;
            myRow["NbRooms"] = myhouse.NbRoom;
            myRow["Price"] = myhouse.HousePrice;
            myRow["Status"] = myhouse.Status;


            myRow["ReferAgent"] = myhouse.AgentId;
            myRow["Pool"] = myhouse.Pool;




            if (mode == "add".Trim())
            {
               
                house.addToDB(myRow);
                MessageBox.Show("House added successfully!", "ADD", MessageBoxButtons.OK);

            }

            else if (mode == "edit".Trim())
            {
                
                house.EditToDB(myRow); 
                MessageBox.Show("House updated successfully!", "Update", MessageBoxButtons.OK);
            }


            btbAdd.Enabled = btbDelete.Enabled = btbEdit.Enabled = btbExit.Enabled = true;
            txtHouseTYp.BackColor = txtAddress.BackColor = txtLocation.BackColor = txtPrice.BackColor = txtSurface.BackColor = txtNbRoom.BackColor = System.Drawing.Color.White;
                clearTXT();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }





        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btbDelete_Click(object sender, EventArgs e)
        {
            current = gridResultHouses.SelectedRows[0].Index;
            if (MessageBox.Show("Are you sure you want to delet this House?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                //tHouse.Rows[current].Delete();

                //// for deleting from database
                //OleDbCommandBuilder mybuild = new OleDbCommandBuilder(clsDataSource.myAdpHouse);
                //clsDataSource.myAdpHouse.Update(tHouse);
                house.Delete(current);
               
            }
          
        }
        private void clearTXT()
        {
            txtAddress.Clear();
            txtLocation.Clear();
            txtPrice.Clear();
            txtSurface.Clear();
            txtNbRoom.Clear();
            txtHouseTYp.Clear();

            chkPool.Checked = false;
        }
        private void btbCancel_Click(object sender, EventArgs e)
        {
            btbAdd.Enabled = btbDelete.Enabled = btbEdit.Enabled = btbExit.Enabled = true;
            txtHouseTYp.BackColor = txtAddress.BackColor = txtLocation.BackColor = txtPrice.BackColor = txtSurface.BackColor = txtNbRoom.BackColor = System.Drawing.Color.White;
            clearTXT();
        }

        private void btbExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void gridResultHouses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.gridResultHouses.Rows[e.RowIndex];
               
                txtHouseTYp.Text = row.Cells[1].Value.ToString();
                
                txtAddress.Text = row.Cells[2].Value.ToString();
                txtLocation.Text = row.Cells[3].Value.ToString();
                txtSurface.Text = row.Cells[4].Value.ToString();
                txtPrice.Text = row.Cells[7].Value.ToString();
               
                txtNbRoom.Text = row.Cells[5].Value.ToString();
                
                cboTypeHouse.Text = row.Cells[8].Value.ToString();
                chkPool.Checked= Convert.ToBoolean(row.Cells[6].Value.ToString());
                
                long idAgent = Convert.ToInt64(row.Cells[9].Value.ToString());
                DataRow[] rows;
               
                agents = new clsListUser();
                rows = agents.nameAgents(idAgent);
               
                string nameAgent = rows[0]["name"].ToString();
                cboAgent.Text= nameAgent;             
  

               
            }
        }



        //======================================================
    }
}
