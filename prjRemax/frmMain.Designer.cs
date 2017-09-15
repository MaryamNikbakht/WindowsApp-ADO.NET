namespace prjRemax.GUI
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.manageHousesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.submitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allSaleListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripmain = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripmain.SuspendLayout();
            this.SuspendLayout();
            // 
            // manageHousesToolStripMenuItem
            // 
            this.manageHousesToolStripMenuItem.Name = "manageHousesToolStripMenuItem";
            this.manageHousesToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.manageHousesToolStripMenuItem.Text = "Manage Houses";
            this.manageHousesToolStripMenuItem.Click += new System.EventHandler(this.manageHousesToolStripMenuItem_Click);
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.allToolStripMenuItem.Text = "All Houses";
            // 
            // submitToolStripMenuItem
            // 
            this.submitToolStripMenuItem.Name = "submitToolStripMenuItem";
            this.submitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.submitToolStripMenuItem.Text = "Submit";
            // 
            // allSaleListToolStripMenuItem
            // 
            this.allSaleListToolStripMenuItem.Name = "allSaleListToolStripMenuItem";
            this.allSaleListToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.allSaleListToolStripMenuItem.Text = "All Sale List";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // createUserToolStripMenuItem
            // 
            this.createUserToolStripMenuItem.Name = "createUserToolStripMenuItem";
            this.createUserToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.createUserToolStripMenuItem.Text = "Create User";
            this.createUserToolStripMenuItem.Click += new System.EventHandler(this.agentsToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createUserToolStripMenuItem,
            this.createClientToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // createClientToolStripMenuItem
            // 
            this.createClientToolStripMenuItem.Name = "createClientToolStripMenuItem";
            this.createClientToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.createClientToolStripMenuItem.Text = "Create Client";
            this.createClientToolStripMenuItem.Click += new System.EventHandler(this.createClientToolStripMenuItem_Click);
            // 
            // saleListToolStripMenuItem
            // 
            this.saleListToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allSaleListToolStripMenuItem});
            this.saleListToolStripMenuItem.Name = "saleListToolStripMenuItem";
            this.saleListToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.saleListToolStripMenuItem.Text = "Sale List";
            // 
            // contractToolStripMenuItem
            // 
            this.contractToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submitToolStripMenuItem});
            this.contractToolStripMenuItem.Name = "contractToolStripMenuItem";
            this.contractToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.contractToolStripMenuItem.Text = "Contract";
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allToolStripMenuItem});
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.listToolStripMenuItem.Text = "List";
            this.listToolStripMenuItem.Click += new System.EventHandler(this.listToolStripMenuItem_Click);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.manageHousesToolStripMenuItem});
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // menuStripmain
            // 
            this.menuStripmain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.listToolStripMenuItem,
            this.contractToolStripMenuItem,
            this.saleListToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStripmain.Location = new System.Drawing.Point(20, 60);
            this.menuStripmain.Name = "menuStripmain";
            this.menuStripmain.Size = new System.Drawing.Size(652, 24);
            this.menuStripmain.TabIndex = 1;
            this.menuStripmain.Text = "menuStrip1";
            this.menuStripmain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStripmain_ItemClicked);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 412);
            this.Controls.Add(this.menuStripmain);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.Text = "frmMain";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStripmain.ResumeLayout(false);
            this.menuStripmain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem manageHousesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem submitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allSaleListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStripmain;
        private System.Windows.Forms.ToolStripMenuItem createClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
    }
}