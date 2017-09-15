namespace prjRemax.GUI
{
    partial class frmSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxSearchAgent = new System.Windows.Forms.GroupBox();
            this.radAgentByName = new System.Windows.Forms.RadioButton();
            this.radAgentNumber = new System.Windows.Forms.RadioButton();
            this.radAllAgents = new System.Windows.Forms.RadioButton();
            this.txtNUmberAgent = new MetroFramework.Controls.MetroTextBox();
            this.cboAgents = new System.Windows.Forms.ComboBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.radHouse = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radAgent = new System.Windows.Forms.RadioButton();
            this.groupBoxSearchHouse = new System.Windows.Forms.GroupBox();
            this.radHouseNumber = new System.Windows.Forms.RadioButton();
            this.radAllHous = new System.Windows.Forms.RadioButton();
            this.txtHouseNumber = new MetroFramework.Controls.MetroTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btbClear = new System.Windows.Forms.Button();
            this.tabList = new MetroFramework.Controls.MetroTabControl();
            this.ListHouse = new MetroFramework.Controls.MetroTabPage();
            this.gridResultHouses = new MetroFramework.Controls.MetroGrid();
            this.listAgent = new MetroFramework.Controls.MetroTabPage();
            this.gridListAgents = new MetroFramework.Controls.MetroGrid();
            this.IDUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ddresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surface = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbOfRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pool = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxSearchAgent.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxSearchHouse.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabList.SuspendLayout();
            this.ListHouse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResultHouses)).BeginInit();
            this.listAgent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridListAgents)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxSearchAgent
            // 
            this.groupBoxSearchAgent.Controls.Add(this.radAgentByName);
            this.groupBoxSearchAgent.Controls.Add(this.radAgentNumber);
            this.groupBoxSearchAgent.Controls.Add(this.radAllAgents);
            this.groupBoxSearchAgent.Controls.Add(this.txtNUmberAgent);
            this.groupBoxSearchAgent.Controls.Add(this.cboAgents);
            this.groupBoxSearchAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSearchAgent.Location = new System.Drawing.Point(23, 157);
            this.groupBoxSearchAgent.Name = "groupBoxSearchAgent";
            this.groupBoxSearchAgent.Size = new System.Drawing.Size(318, 160);
            this.groupBoxSearchAgent.TabIndex = 26;
            this.groupBoxSearchAgent.TabStop = false;
            this.groupBoxSearchAgent.Text = "Search By Agent";
            // 
            // radAgentByName
            // 
            this.radAgentByName.AutoSize = true;
            this.radAgentByName.Location = new System.Drawing.Point(16, 112);
            this.radAgentByName.Name = "radAgentByName";
            this.radAgentByName.Size = new System.Drawing.Size(133, 20);
            this.radAgentByName.TabIndex = 20;
            this.radAgentByName.TabStop = true;
            this.radAgentByName.Text = "Agent By Name";
            this.radAgentByName.UseVisualStyleBackColor = true;
            // 
            // radAgentNumber
            // 
            this.radAgentNumber.AutoSize = true;
            this.radAgentNumber.Location = new System.Drawing.Point(16, 74);
            this.radAgentNumber.Name = "radAgentNumber";
            this.radAgentNumber.Size = new System.Drawing.Size(133, 20);
            this.radAgentNumber.TabIndex = 18;
            this.radAgentNumber.TabStop = true;
            this.radAgentNumber.Text = "Agent\'s number";
            this.radAgentNumber.UseVisualStyleBackColor = true;
            // 
            // radAllAgents
            // 
            this.radAllAgents.AutoSize = true;
            this.radAllAgents.Location = new System.Drawing.Point(16, 35);
            this.radAllAgents.Name = "radAllAgents";
            this.radAllAgents.Size = new System.Drawing.Size(96, 20);
            this.radAllAgents.TabIndex = 17;
            this.radAllAgents.TabStop = true;
            this.radAllAgents.Text = "All Agents";
            this.radAllAgents.UseVisualStyleBackColor = true;
           
            // 
            // txtNUmberAgent
            // 
            // 
            // 
            // 
            this.txtNUmberAgent.CustomButton.Image = null;
            this.txtNUmberAgent.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.txtNUmberAgent.CustomButton.Name = "";
            this.txtNUmberAgent.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNUmberAgent.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNUmberAgent.CustomButton.TabIndex = 1;
            this.txtNUmberAgent.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNUmberAgent.CustomButton.UseSelectable = true;
            this.txtNUmberAgent.CustomButton.Visible = false;
            this.txtNUmberAgent.Lines = new string[0];
            this.txtNUmberAgent.Location = new System.Drawing.Point(155, 74);
            this.txtNUmberAgent.MaxLength = 32767;
            this.txtNUmberAgent.Name = "txtNUmberAgent";
            this.txtNUmberAgent.PasswordChar = '\0';
            this.txtNUmberAgent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNUmberAgent.SelectedText = "";
            this.txtNUmberAgent.SelectionLength = 0;
            this.txtNUmberAgent.SelectionStart = 0;
            this.txtNUmberAgent.ShortcutsEnabled = true;
            this.txtNUmberAgent.Size = new System.Drawing.Size(154, 23);
            this.txtNUmberAgent.TabIndex = 16;
            this.txtNUmberAgent.UseSelectable = true;
            this.txtNUmberAgent.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNUmberAgent.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cboAgents
            // 
            this.cboAgents.FormattingEnabled = true;
            this.cboAgents.Location = new System.Drawing.Point(155, 112);
            this.cboAgents.Name = "cboAgents";
            this.cboAgents.Size = new System.Drawing.Size(154, 24);
            this.cboAgents.TabIndex = 9;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(1, 11);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(132, 34);
            this.btnFind.TabIndex = 12;
            this.btnFind.Text = "Find House";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // radHouse
            // 
            this.radHouse.AutoSize = true;
            this.radHouse.Location = new System.Drawing.Point(457, 35);
            this.radHouse.Name = "radHouse";
            this.radHouse.Size = new System.Drawing.Size(93, 20);
            this.radHouse.TabIndex = 1;
            this.radHouse.TabStop = true;
            this.radHouse.Text = "By House";
            this.radHouse.UseVisualStyleBackColor = true;
            this.radHouse.CheckedChanged += new System.EventHandler(this.radHouse_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radAgent);
            this.groupBox2.Controls.Add(this.radHouse);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(23, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(686, 87);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Search ";
            // 
            // radAgent
            // 
            this.radAgent.AutoSize = true;
            this.radAgent.Location = new System.Drawing.Point(95, 35);
            this.radAgent.Name = "radAgent";
            this.radAgent.Size = new System.Drawing.Size(96, 20);
            this.radAgent.TabIndex = 1;
            this.radAgent.TabStop = true;
            this.radAgent.Text = "By Agents";
            this.radAgent.UseVisualStyleBackColor = true;
            this.radAgent.CheckedChanged += new System.EventHandler(this.radAgent_CheckedChanged);
            // 
            // groupBoxSearchHouse
            // 
            this.groupBoxSearchHouse.Controls.Add(this.radHouseNumber);
            this.groupBoxSearchHouse.Controls.Add(this.radAllHous);
            this.groupBoxSearchHouse.Controls.Add(this.txtHouseNumber);
            this.groupBoxSearchHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSearchHouse.Location = new System.Drawing.Point(359, 157);
            this.groupBoxSearchHouse.Name = "groupBoxSearchHouse";
            this.groupBoxSearchHouse.Size = new System.Drawing.Size(350, 160);
            this.groupBoxSearchHouse.TabIndex = 29;
            this.groupBoxSearchHouse.TabStop = false;
            this.groupBoxSearchHouse.Text = "Search By House";
            // 
            // radHouseNumber
            // 
            this.radHouseNumber.AutoSize = true;
            this.radHouseNumber.Location = new System.Drawing.Point(26, 77);
            this.radHouseNumber.Name = "radHouseNumber";
            this.radHouseNumber.Size = new System.Drawing.Size(141, 20);
            this.radHouseNumber.TabIndex = 20;
            this.radHouseNumber.TabStop = true;
            this.radHouseNumber.Text = "House\'s Number";
            this.radHouseNumber.UseVisualStyleBackColor = true;
            // 
            // radAllHous
            // 
            this.radAllHous.AutoSize = true;
            this.radAllHous.Location = new System.Drawing.Point(25, 35);
            this.radAllHous.Name = "radAllHous";
            this.radAllHous.Size = new System.Drawing.Size(93, 20);
            this.radAllHous.TabIndex = 19;
            this.radAllHous.TabStop = true;
            this.radAllHous.Text = "All House";
            this.radAllHous.UseVisualStyleBackColor = true;
            // 
            // txtHouseNumber
            // 
            // 
            // 
            // 
            this.txtHouseNumber.CustomButton.Image = null;
            this.txtHouseNumber.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.txtHouseNumber.CustomButton.Name = "";
            this.txtHouseNumber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtHouseNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHouseNumber.CustomButton.TabIndex = 1;
            this.txtHouseNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHouseNumber.CustomButton.UseSelectable = true;
            this.txtHouseNumber.CustomButton.Visible = false;
            this.txtHouseNumber.Lines = new string[0];
            this.txtHouseNumber.Location = new System.Drawing.Point(173, 77);
            this.txtHouseNumber.MaxLength = 32767;
            this.txtHouseNumber.Name = "txtHouseNumber";
            this.txtHouseNumber.PasswordChar = '\0';
            this.txtHouseNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHouseNumber.SelectedText = "";
            this.txtHouseNumber.SelectionLength = 0;
            this.txtHouseNumber.SelectionStart = 0;
            this.txtHouseNumber.ShortcutsEnabled = true;
            this.txtHouseNumber.Size = new System.Drawing.Size(154, 23);
            this.txtHouseNumber.TabIndex = 18;
            this.txtHouseNumber.UseSelectable = true;
            this.txtHouseNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHouseNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btbClear);
            this.groupBox3.Controls.Add(this.btnFind);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(211, 323);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(277, 49);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            // 
            // btbClear
            // 
            this.btbClear.Location = new System.Drawing.Point(144, 10);
            this.btbClear.Name = "btbClear";
            this.btbClear.Size = new System.Drawing.Size(132, 34);
            this.btbClear.TabIndex = 13;
            this.btbClear.Text = "Clear";
            this.btbClear.UseVisualStyleBackColor = true;
            this.btbClear.Click += new System.EventHandler(this.btbClear_Click);
            // 
            // tabList
            // 
            this.tabList.Controls.Add(this.ListHouse);
            this.tabList.Controls.Add(this.listAgent);
            this.tabList.Location = new System.Drawing.Point(23, 374);
            this.tabList.Name = "tabList";
            this.tabList.SelectedIndex = 0;
            this.tabList.Size = new System.Drawing.Size(686, 217);
            this.tabList.TabIndex = 31;
            this.tabList.UseSelectable = true;
            // 
            // ListHouse
            // 
            this.ListHouse.Controls.Add(this.gridResultHouses);
            this.ListHouse.HorizontalScrollbarBarColor = true;
            this.ListHouse.HorizontalScrollbarHighlightOnWheel = false;
            this.ListHouse.HorizontalScrollbarSize = 10;
            this.ListHouse.Location = new System.Drawing.Point(4, 38);
            this.ListHouse.Name = "ListHouse";
            this.ListHouse.Size = new System.Drawing.Size(678, 175);
            this.ListHouse.TabIndex = 0;
            this.ListHouse.Text = "List Of Houses";
            this.ListHouse.VerticalScrollbarBarColor = true;
            this.ListHouse.VerticalScrollbarHighlightOnWheel = false;
            this.ListHouse.VerticalScrollbarSize = 10;
            // 
            // gridResultHouses
            // 
            this.gridResultHouses.AllowUserToResizeRows = false;
            this.gridResultHouses.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridResultHouses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridResultHouses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridResultHouses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridResultHouses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridResultHouses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResultHouses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Type,
            this.agentName,
            this.ddresse,
            this.Location,
            this.Surface,
            this.nbOfRoom,
            this.Pool,
            this.Price,
            this.Status});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridResultHouses.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridResultHouses.EnableHeadersVisualStyles = false;
            this.gridResultHouses.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridResultHouses.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridResultHouses.Location = new System.Drawing.Point(4, 4);
            this.gridResultHouses.Name = "gridResultHouses";
            this.gridResultHouses.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridResultHouses.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridResultHouses.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridResultHouses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridResultHouses.Size = new System.Drawing.Size(671, 150);
            this.gridResultHouses.TabIndex = 3;
  
            // 
            // listAgent
            // 
            this.listAgent.Controls.Add(this.gridListAgents);
            this.listAgent.HorizontalScrollbarBarColor = true;
            this.listAgent.HorizontalScrollbarHighlightOnWheel = false;
            this.listAgent.HorizontalScrollbarSize = 10;
            this.listAgent.Location = new System.Drawing.Point(4, 38);
            this.listAgent.Name = "listAgent";
            this.listAgent.Size = new System.Drawing.Size(678, 175);
            this.listAgent.TabIndex = 1;
            this.listAgent.Text = "List Of Agents";
            this.listAgent.VerticalScrollbarBarColor = true;
            this.listAgent.VerticalScrollbarHighlightOnWheel = false;
            this.listAgent.VerticalScrollbarSize = 10;
            // 
            // gridListAgents
            // 
            this.gridListAgents.AllowUserToResizeRows = false;
            this.gridListAgents.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridListAgents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridListAgents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridListAgents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridListAgents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridListAgents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridListAgents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDUser,
            this.name,
            this.email,
            this.phone});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridListAgents.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridListAgents.EnableHeadersVisualStyles = false;
            this.gridListAgents.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridListAgents.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridListAgents.Location = new System.Drawing.Point(4, 4);
            this.gridListAgents.Name = "gridListAgents";
            this.gridListAgents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridListAgents.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridListAgents.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridListAgents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridListAgents.Size = new System.Drawing.Size(671, 150);
            this.gridListAgents.TabIndex = 2;
            // 
            // IDUser
            // 
            this.IDUser.HeaderText = "ID";
            this.IDUser.Name = "IDUser";
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // phone
            // 
            this.phone.HeaderText = "Phone";
            this.phone.Name = "phone";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            // 
            // agentName
            // 
            this.agentName.HeaderText = "Agent\'s Name";
            this.agentName.Name = "agentName";
            // 
            // ddresse
            // 
            this.ddresse.HeaderText = "Addresse";
            this.ddresse.Name = "ddresse";
            // 
            // Location
            // 
            this.Location.HeaderText = "Location";
            this.Location.Name = "Location";
            // 
            // Surface
            // 
            this.Surface.HeaderText = "Surface";
            this.Surface.Name = "Surface";
            // 
            // nbOfRoom
            // 
            this.nbOfRoom.HeaderText = "Number Of Room";
            this.nbOfRoom.Name = "nbOfRoom";
            // 
            // Pool
            // 
            this.Pool.HeaderText = "Pool";
            this.Pool.Name = "Pool";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 614);
            this.Controls.Add(this.tabList);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxSearchHouse);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxSearchAgent);
            this.Name = "frmSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.Text = "SEARCH - HOUSE";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.frmSearch_Load);
            this.groupBoxSearchAgent.ResumeLayout(false);
            this.groupBoxSearchAgent.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxSearchHouse.ResumeLayout(false);
            this.groupBoxSearchHouse.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tabList.ResumeLayout(false);
            this.ListHouse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridResultHouses)).EndInit();
            this.listAgent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridListAgents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxSearchAgent;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ComboBox cboAgents;
        private System.Windows.Forms.RadioButton radHouse;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radAgent;
        private System.Windows.Forms.GroupBox groupBoxSearchHouse;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btbClear;
        private MetroFramework.Controls.MetroTextBox txtNUmberAgent;
        private MetroFramework.Controls.MetroTextBox txtHouseNumber;
        private System.Windows.Forms.RadioButton radAgentNumber;
        private System.Windows.Forms.RadioButton radAllAgents;
        private System.Windows.Forms.RadioButton radHouseNumber;
        private System.Windows.Forms.RadioButton radAllHous;
        private MetroFramework.Controls.MetroTabControl tabList;
        private MetroFramework.Controls.MetroTabPage ListHouse;
        private MetroFramework.Controls.MetroTabPage listAgent;
        private MetroFramework.Controls.MetroGrid gridListAgents;
        private System.Windows.Forms.RadioButton radAgentByName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private MetroFramework.Controls.MetroGrid gridResultHouses;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ddresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surface;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbOfRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pool;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}