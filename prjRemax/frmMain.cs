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

namespace prjRemax.GUI
{
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {
        frmLogin log;
        clsListUser lus;
        
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            log = new frmLogin();
            log.ShowDialog();
        }

        private void menuStripmain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
            string userT = frmLogin.gettypeUser.ToString().Trim();
           Int64 idAgent = Convert.ToInt64(frmLogin.getIdUser.ToString());
            
          
            // string clientT = frmLogin.gettypeClient.ToString().Trim();
            if (userT == "agents")
            {
               createUserToolStripMenuItem.Enabled = false;

            }
            if (userT == "admins")
            {
               

            }

            else if (userT == "clients")
            {
                createUserToolStripMenuItem.Enabled = createClientToolStripMenuItem.Enabled = usersToolStripMenuItem.Enabled =listToolStripMenuItem.Enabled=contractToolStripMenuItem.Enabled=saleListToolStripMenuItem.Enabled=manageHousesToolStripMenuItem.Enabled =false;

            }
        }

        private void manageHousesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHouses house = new frmHouses();
            house.MdiParent = this;
            house.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearch search = new frmSearch();
            search.MdiParent = this;
            search.Show();
        }

        private void agentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserCreate us = new frmUserCreate();
            us.MdiParent = this;
            us.Show();
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void createUserClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void createClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCreateClient client = new frmCreateClient();
            client.MdiParent = this;
            client.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
