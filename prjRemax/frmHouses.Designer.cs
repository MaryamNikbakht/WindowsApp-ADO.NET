namespace prjRemax.GUI
{
    partial class frmHouses
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtHouseTYp = new System.Windows.Forms.TextBox();
            this.btbExit = new MetroFramework.Controls.MetroButton();
            this.btbCancel = new MetroFramework.Controls.MetroButton();
            this.btbDelete = new MetroFramework.Controls.MetroButton();
            this.btbSave = new MetroFramework.Controls.MetroButton();
            this.btbEdit = new MetroFramework.Controls.MetroButton();
            this.btbAdd = new MetroFramework.Controls.MetroButton();
            this.cboAgent = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.chkPool = new MetroFramework.Controls.MetroCheckBox();
            this.txtNbRoom = new System.Windows.Forms.TextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtSurface = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.cboTypeHouse = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.gridResultHouses = new MetroFramework.Controls.MetroGrid();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResultHouses)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.txtHouseTYp);
            this.groupBox1.Controls.Add(this.btbExit);
            this.groupBox1.Controls.Add(this.btbCancel);
            this.groupBox1.Controls.Add(this.btbDelete);
            this.groupBox1.Controls.Add(this.btbSave);
            this.groupBox1.Controls.Add(this.btbEdit);
            this.groupBox1.Controls.Add(this.btbAdd);
            this.groupBox1.Controls.Add(this.cboAgent);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.chkPool);
            this.groupBox1.Controls.Add(this.txtNbRoom);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.txtSurface);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtLocation);
            this.groupBox1.Controls.Add(this.cboTypeHouse);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 349);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "House Info";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(32, 40);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(87, 19);
            this.metroLabel8.TabIndex = 60;
            this.metroLabel8.Text = "Type House: ";
            // 
            // txtHouseTYp
            // 
            this.txtHouseTYp.Location = new System.Drawing.Point(156, 32);
            this.txtHouseTYp.Multiline = true;
            this.txtHouseTYp.Name = "txtHouseTYp";
            this.txtHouseTYp.Size = new System.Drawing.Size(203, 29);
            this.txtHouseTYp.TabIndex = 59;
            // 
            // btbExit
            // 
            this.btbExit.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btbExit.Location = new System.Drawing.Point(411, 207);
            this.btbExit.Name = "btbExit";
            this.btbExit.Size = new System.Drawing.Size(190, 29);
            this.btbExit.TabIndex = 58;
            this.btbExit.Text = "Exit";
            this.btbExit.UseSelectable = true;
            this.btbExit.Click += new System.EventHandler(this.btbExit_Click);
            // 
            // btbCancel
            // 
            this.btbCancel.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btbCancel.Location = new System.Drawing.Point(411, 172);
            this.btbCancel.Name = "btbCancel";
            this.btbCancel.Size = new System.Drawing.Size(190, 29);
            this.btbCancel.TabIndex = 57;
            this.btbCancel.Text = "Cancel";
            this.btbCancel.UseSelectable = true;
            this.btbCancel.Click += new System.EventHandler(this.btbCancel_Click);
            // 
            // btbDelete
            // 
            this.btbDelete.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btbDelete.Location = new System.Drawing.Point(411, 137);
            this.btbDelete.Name = "btbDelete";
            this.btbDelete.Size = new System.Drawing.Size(190, 29);
            this.btbDelete.TabIndex = 56;
            this.btbDelete.Text = "Delete";
            this.btbDelete.UseSelectable = true;
            this.btbDelete.Click += new System.EventHandler(this.btbDelete_Click);
            // 
            // btbSave
            // 
            this.btbSave.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btbSave.Location = new System.Drawing.Point(411, 102);
            this.btbSave.Name = "btbSave";
            this.btbSave.Size = new System.Drawing.Size(190, 29);
            this.btbSave.TabIndex = 55;
            this.btbSave.Text = "Save";
            this.btbSave.UseSelectable = true;
            this.btbSave.Click += new System.EventHandler(this.btbSave_Click);
            // 
            // btbEdit
            // 
            this.btbEdit.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btbEdit.Location = new System.Drawing.Point(411, 67);
            this.btbEdit.Name = "btbEdit";
            this.btbEdit.Size = new System.Drawing.Size(190, 29);
            this.btbEdit.TabIndex = 54;
            this.btbEdit.Text = "Edit";
            this.btbEdit.UseSelectable = true;
            this.btbEdit.Click += new System.EventHandler(this.btbEdit_Click);
            // 
            // btbAdd
            // 
            this.btbAdd.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btbAdd.Location = new System.Drawing.Point(411, 32);
            this.btbAdd.Name = "btbAdd";
            this.btbAdd.Size = new System.Drawing.Size(190, 29);
            this.btbAdd.TabIndex = 53;
            this.btbAdd.Text = "Add";
            this.btbAdd.UseSelectable = true;
            this.btbAdd.Click += new System.EventHandler(this.btbAdd_Click);
            // 
            // cboAgent
            // 
            this.cboAgent.FormattingEnabled = true;
            this.cboAgent.ItemHeight = 23;
            this.cboAgent.Location = new System.Drawing.Point(156, 241);
            this.cboAgent.Name = "cboAgent";
            this.cboAgent.Size = new System.Drawing.Size(203, 29);
            this.cboAgent.TabIndex = 52;
            this.cboAgent.UseSelectable = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(32, 251);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(49, 19);
            this.metroLabel7.TabIndex = 51;
            this.metroLabel7.Text = "Agent:";
            // 
            // chkPool
            // 
            this.chkPool.AutoSize = true;
            this.chkPool.Location = new System.Drawing.Point(37, 325);
            this.chkPool.Name = "chkPool";
            this.chkPool.Size = new System.Drawing.Size(47, 15);
            this.chkPool.TabIndex = 50;
            this.chkPool.Text = "Pool";
            this.chkPool.UseSelectable = true;
            // 
            // txtNbRoom
            // 
            this.txtNbRoom.Location = new System.Drawing.Point(156, 275);
            this.txtNbRoom.Multiline = true;
            this.txtNbRoom.Name = "txtNbRoom";
            this.txtNbRoom.Size = new System.Drawing.Size(56, 29);
            this.txtNbRoom.TabIndex = 49;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(32, 285);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(118, 19);
            this.metroLabel6.TabIndex = 48;
            this.metroLabel6.Text = "Number Of Room";
            // 
            // txtSurface
            // 
            this.txtSurface.Location = new System.Drawing.Point(156, 170);
            this.txtSurface.Multiline = true;
            this.txtSurface.Name = "txtSurface";
            this.txtSurface.Size = new System.Drawing.Size(203, 29);
            this.txtSurface.TabIndex = 47;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(156, 136);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(203, 29);
            this.txtPrice.TabIndex = 46;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(156, 101);
            this.txtLocation.Multiline = true;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(203, 29);
            this.txtLocation.TabIndex = 45;
            // 
            // cboTypeHouse
            // 
            this.cboTypeHouse.FormattingEnabled = true;
            this.cboTypeHouse.ItemHeight = 23;
            this.cboTypeHouse.Location = new System.Drawing.Point(156, 205);
            this.cboTypeHouse.Name = "cboTypeHouse";
            this.cboTypeHouse.Size = new System.Drawing.Size(203, 29);
            this.cboTypeHouse.TabIndex = 44;
            this.cboTypeHouse.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(32, 215);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(40, 19);
            this.metroLabel5.TabIndex = 43;
            this.metroLabel5.Text = "Type:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(32, 180);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(56, 19);
            this.metroLabel4.TabIndex = 42;
            this.metroLabel4.Text = "Surface:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(37, 146);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(45, 19);
            this.metroLabel3.TabIndex = 41;
            this.metroLabel3.Text = "Price: ";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(32, 111);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(72, 19);
            this.metroLabel2.TabIndex = 40;
            this.metroLabel2.Text = "Location:  ";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(32, 74);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(65, 19);
            this.metroLabel1.TabIndex = 39;
            this.metroLabel1.Text = "Address: ";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(156, 66);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(203, 29);
            this.txtAddress.TabIndex = 29;
            // 
            // gridResultHouses
            // 
            this.gridResultHouses.AllowUserToResizeRows = false;
            this.gridResultHouses.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridResultHouses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridResultHouses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridResultHouses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridResultHouses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridResultHouses.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridResultHouses.EnableHeadersVisualStyles = false;
            this.gridResultHouses.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridResultHouses.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridResultHouses.Location = new System.Drawing.Point(23, 434);
            this.gridResultHouses.Name = "gridResultHouses";
            this.gridResultHouses.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridResultHouses.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridResultHouses.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridResultHouses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridResultHouses.Size = new System.Drawing.Size(633, 150);
            this.gridResultHouses.TabIndex = 4;
            this.gridResultHouses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridResultHouses_CellContentClick);
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
            // frmHouses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 607);
            this.Controls.Add(this.gridResultHouses);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmHouses";
            this.Text = "Create House -REMAX";
            this.Load += new System.EventHandler(this.frmHouses_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResultHouses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAddress;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cboTypeHouse;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.TextBox txtSurface;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtNbRoom;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroComboBox cboAgent;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroCheckBox chkPool;
        private MetroFramework.Controls.MetroButton btbExit;
        private MetroFramework.Controls.MetroButton btbCancel;
        private MetroFramework.Controls.MetroButton btbDelete;
        private MetroFramework.Controls.MetroButton btbSave;
        private MetroFramework.Controls.MetroButton btbEdit;
        private MetroFramework.Controls.MetroButton btbAdd;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.TextBox txtHouseTYp;
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