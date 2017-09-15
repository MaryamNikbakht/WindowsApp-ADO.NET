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
    public partial class frmSearch : MetroFramework.Forms.MetroForm
    {
       
        clsListHouse house;
        clsHouse aHouse;
        clsListUser agents;
        clsUser aUser;
        public frmSearch()
        {
            InitializeComponent();
        }
        ///// <summary>
        ///// Load Form
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        private void frmSearch_Load(object sender, EventArgs e)
        {
           groupBoxSearchAgent.Visible = groupBoxSearchHouse.Visible = radAgent.Checked = radHouse.Checked = false;

            gridListAgents.Columns.Clear();
            agents = new clsListUser();
            gridListAgents.DataSource = agents.showAgents();
            int i;
            for (i = 0; i < gridListAgents.Rows.Count - 1; i++)
            {
               cboAgents.Items.Add(gridListAgents[1, i].Value.ToString());
     
            }
            gridResultHouses.Columns.Clear();
           house = new clsListHouse();
            gridResultHouses.DataSource = house.showAllHouse();

        }



        private void radAgent_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxSearchHouse.Visible = false;
            groupBoxSearchAgent.Visible = true;
            btnFind.Text = "Find Agents";

        }

        private void radHouse_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxSearchAgent.Visible = false;
            groupBoxSearchHouse.Visible = true;
            btnFind.Text = "Find Houses";
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
           

           bool find = false;



            if (radAllAgents.Checked)
            {

              //  gridListAgents.Rows.Clear();
                tabList.SelectedIndex = 1;
                btnFind.Text = "Find Agents";
                agents = new clsListUser();
                gridListAgents.DataSource = agents.showAgents();



            }
            if (radAgentNumber.Checked)
            {

              //  gridListAgents.Rows.Clear();
                tabList.SelectedIndex = 1;
                btnFind.Text = "Find Agents";
                agents = new clsListUser();
               
                gridListAgents.DataSource = agents.showAnAgent(Convert.ToInt64(txtNUmberAgent.Text));


               

            }
            if (radAgentByName.Checked)
            {
               // gridListAgents.Rows.Clear();
                tabList.SelectedIndex = 1;


                string nameAg = cboAgents.Text;
                btnFind.Text = "Find Agents";
                agents = new clsListUser();

                gridListAgents.DataSource = agents.showAnAgent(nameAg);


            }
            if (radAllHous.Checked)
            {
                tabList.SelectedIndex = 0;
                ListHouse.Focus();

                house = new clsListHouse();
                gridResultHouses.DataSource = house.showAllHouse();

                
            }
            if (radHouseNumber.Checked)
            {
                tabList.SelectedIndex = 0;
                ListHouse.Focus();

                house = new clsListHouse();
                gridResultHouses.DataSource = house.showAHouse(Convert.ToInt64(txtHouseNumber.Text));


            }


            clearButton();
            groupBoxSearchAgent.Visible = groupBoxSearchHouse.Visible = false;
        }

        private void btbClear_Click(object sender, EventArgs e)
        {
            clearButton();
            groupBoxSearchAgent.Visible = groupBoxSearchHouse.Visible = false;
        }
        private void clearButton()
        {
            txtHouseNumber.Clear();
            txtNUmberAgent.Clear();
            radAgent.Checked = false;
            radAgentNumber.Checked = false;
            radAllAgents.Checked = false;
            radAllHous.Checked = false;
            radHouse.Checked = false;
            radHouseNumber.Checked = false;

            radAllAgents.Checked = false;

        }
    }
}
