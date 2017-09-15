namespace prjRemax.GUI
{
    partial class frmCreateClient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdListUsers = new MetroFramework.Controls.MetroGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtPostalCode = new MetroFramework.Controls.MetroTextBox();
            this.txtCity = new MetroFramework.Controls.MetroTextBox();
            this.txtAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.btbExit = new MetroFramework.Controls.MetroButton();
            this.txtRefAgent = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.btbCancel = new MetroFramework.Controls.MetroButton();
            this.btbDelete = new MetroFramework.Controls.MetroButton();
            this.btbSave = new MetroFramework.Controls.MetroButton();
            this.btbEdit = new MetroFramework.Controls.MetroButton();
            this.cboTypeUser = new MetroFramework.Controls.MetroComboBox();
            this.lblUserType = new MetroFramework.Controls.MetroLabel();
            this.btbAdd = new MetroFramework.Controls.MetroButton();
            this.txtPhone = new MetroFramework.Controls.MetroTextBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtUserName = new MetroFramework.Controls.MetroTextBox();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.grdListUsers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdListUsers
            // 
            this.grdListUsers.AllowUserToResizeRows = false;
            this.grdListUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdListUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdListUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdListUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdListUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.grdListUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdListUsers.DefaultCellStyle = dataGridViewCellStyle17;
            this.grdListUsers.EnableHeadersVisualStyles = false;
            this.grdListUsers.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdListUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdListUsers.Location = new System.Drawing.Point(23, 335);
            this.grdListUsers.Name = "grdListUsers";
            this.grdListUsers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdListUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.grdListUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdListUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdListUsers.Size = new System.Drawing.Size(744, 136);
            this.grdListUsers.TabIndex = 22;
            this.grdListUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdListUsers_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.txtPostalCode);
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Controls.Add(this.btbExit);
            this.groupBox1.Controls.Add(this.txtRefAgent);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.btbCancel);
            this.groupBox1.Controls.Add(this.btbDelete);
            this.groupBox1.Controls.Add(this.btbSave);
            this.groupBox1.Controls.Add(this.btbEdit);
            this.groupBox1.Controls.Add(this.cboTypeUser);
            this.groupBox1.Controls.Add(this.lblUserType);
            this.groupBox1.Controls.Add(this.btbAdd);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(744, 266);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client Info";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(376, 144);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(137, 23);
            this.txtEmail.TabIndex = 67;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(288, 144);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(48, 19);
            this.metroLabel6.TabIndex = 66;
            this.metroLabel6.Text = "Email: ";
            // 
            // txtPostalCode
            // 
            // 
            // 
            // 
            this.txtPostalCode.CustomButton.Image = null;
            this.txtPostalCode.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.txtPostalCode.CustomButton.Name = "";
            this.txtPostalCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPostalCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPostalCode.CustomButton.TabIndex = 1;
            this.txtPostalCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPostalCode.CustomButton.UseSelectable = true;
            this.txtPostalCode.CustomButton.Visible = false;
            this.txtPostalCode.Lines = new string[0];
            this.txtPostalCode.Location = new System.Drawing.Point(376, 110);
            this.txtPostalCode.MaxLength = 32767;
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.PasswordChar = '\0';
            this.txtPostalCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPostalCode.SelectedText = "";
            this.txtPostalCode.SelectionLength = 0;
            this.txtPostalCode.SelectionStart = 0;
            this.txtPostalCode.ShortcutsEnabled = true;
            this.txtPostalCode.Size = new System.Drawing.Size(137, 23);
            this.txtPostalCode.TabIndex = 65;
            this.txtPostalCode.UseSelectable = true;
            this.txtPostalCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPostalCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCity
            // 
            // 
            // 
            // 
            this.txtCity.CustomButton.Image = null;
            this.txtCity.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.txtCity.CustomButton.Name = "";
            this.txtCity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCity.CustomButton.TabIndex = 1;
            this.txtCity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCity.CustomButton.UseSelectable = true;
            this.txtCity.CustomButton.Visible = false;
            this.txtCity.Lines = new string[0];
            this.txtCity.Location = new System.Drawing.Point(376, 76);
            this.txtCity.MaxLength = 32767;
            this.txtCity.Name = "txtCity";
            this.txtCity.PasswordChar = '\0';
            this.txtCity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCity.SelectedText = "";
            this.txtCity.SelectionLength = 0;
            this.txtCity.SelectionStart = 0;
            this.txtCity.ShortcutsEnabled = true;
            this.txtCity.Size = new System.Drawing.Size(137, 23);
            this.txtCity.TabIndex = 64;
            this.txtCity.UseSelectable = true;
            this.txtCity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAddress
            // 
            // 
            // 
            // 
            this.txtAddress.CustomButton.Image = null;
            this.txtAddress.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.txtAddress.CustomButton.Name = "";
            this.txtAddress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddress.CustomButton.TabIndex = 1;
            this.txtAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddress.CustomButton.UseSelectable = true;
            this.txtAddress.CustomButton.Visible = false;
            this.txtAddress.Lines = new string[0];
            this.txtAddress.Location = new System.Drawing.Point(376, 38);
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.ShortcutsEnabled = true;
            this.txtAddress.Size = new System.Drawing.Size(137, 23);
            this.txtAddress.TabIndex = 63;
            this.txtAddress.UseSelectable = true;
            this.txtAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(288, 114);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(88, 19);
            this.metroLabel7.TabIndex = 62;
            this.metroLabel7.Text = "Postal Code: ";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(286, 79);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(40, 19);
            this.metroLabel8.TabIndex = 61;
            this.metroLabel8.Text = "City: ";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(286, 42);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(65, 19);
            this.metroLabel9.TabIndex = 60;
            this.metroLabel9.Text = "Address: ";
            // 
            // btbExit
            // 
            this.btbExit.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btbExit.Location = new System.Drawing.Point(554, 213);
            this.btbExit.Name = "btbExit";
            this.btbExit.Size = new System.Drawing.Size(153, 29);
            this.btbExit.TabIndex = 59;
            this.btbExit.Text = "Exit";
            this.btbExit.UseSelectable = true;
            this.btbExit.Click += new System.EventHandler(this.btbExit_Click);
            // 
            // txtRefAgent
            // 
            // 
            // 
            // 
            this.txtRefAgent.CustomButton.Image = null;
            this.txtRefAgent.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.txtRefAgent.CustomButton.Name = "";
            this.txtRefAgent.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRefAgent.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRefAgent.CustomButton.TabIndex = 1;
            this.txtRefAgent.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRefAgent.CustomButton.UseSelectable = true;
            this.txtRefAgent.CustomButton.Visible = false;
            this.txtRefAgent.Lines = new string[0];
            this.txtRefAgent.Location = new System.Drawing.Point(376, 173);
            this.txtRefAgent.MaxLength = 32767;
            this.txtRefAgent.Name = "txtRefAgent";
            this.txtRefAgent.PasswordChar = '\0';
            this.txtRefAgent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRefAgent.SelectedText = "";
            this.txtRefAgent.SelectionLength = 0;
            this.txtRefAgent.SelectionStart = 0;
            this.txtRefAgent.ShortcutsEnabled = true;
            this.txtRefAgent.Size = new System.Drawing.Size(137, 23);
            this.txtRefAgent.TabIndex = 38;
            this.txtRefAgent.UseSelectable = true;
            this.txtRefAgent.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRefAgent.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(288, 173);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(80, 19);
            this.metroLabel5.TabIndex = 37;
            this.metroLabel5.Text = "Agent\'s ID: ";
            // 
            // btbCancel
            // 
            this.btbCancel.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btbCancel.Location = new System.Drawing.Point(554, 178);
            this.btbCancel.Name = "btbCancel";
            this.btbCancel.Size = new System.Drawing.Size(153, 29);
            this.btbCancel.TabIndex = 36;
            this.btbCancel.Text = "Cancel";
            this.btbCancel.UseSelectable = true;
            this.btbCancel.Click += new System.EventHandler(this.btbCancel_Click);
            // 
            // btbDelete
            // 
            this.btbDelete.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btbDelete.Location = new System.Drawing.Point(554, 143);
            this.btbDelete.Name = "btbDelete";
            this.btbDelete.Size = new System.Drawing.Size(153, 29);
            this.btbDelete.TabIndex = 35;
            this.btbDelete.Text = "Delete";
            this.btbDelete.UseSelectable = true;
            this.btbDelete.Click += new System.EventHandler(this.btbDelete_Click);
            // 
            // btbSave
            // 
            this.btbSave.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btbSave.Location = new System.Drawing.Point(554, 107);
            this.btbSave.Name = "btbSave";
            this.btbSave.Size = new System.Drawing.Size(153, 29);
            this.btbSave.TabIndex = 34;
            this.btbSave.Text = "Save";
            this.btbSave.UseSelectable = true;
            this.btbSave.Click += new System.EventHandler(this.btbSave_Click);
            // 
            // btbEdit
            // 
            this.btbEdit.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btbEdit.Location = new System.Drawing.Point(554, 72);
            this.btbEdit.Name = "btbEdit";
            this.btbEdit.Size = new System.Drawing.Size(153, 29);
            this.btbEdit.TabIndex = 33;
            this.btbEdit.Text = "Edit";
            this.btbEdit.UseSelectable = true;
            this.btbEdit.Click += new System.EventHandler(this.btbEdit_Click);
            // 
            // cboTypeUser
            // 
            this.cboTypeUser.FormattingEnabled = true;
            this.cboTypeUser.ItemHeight = 23;
            this.cboTypeUser.Items.AddRange(new object[] {
            "admins",
            "agents",
            "clients"});
            this.cboTypeUser.Location = new System.Drawing.Point(113, 32);
            this.cboTypeUser.Name = "cboTypeUser";
            this.cboTypeUser.Size = new System.Drawing.Size(137, 29);
            this.cboTypeUser.TabIndex = 32;
            this.cboTypeUser.UseSelectable = true;
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblUserType.Location = new System.Drawing.Point(23, 42);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(48, 19);
            this.lblUserType.TabIndex = 31;
            this.lblUserType.Text = "Type:  ";
            // 
            // btbAdd
            // 
            this.btbAdd.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btbAdd.Location = new System.Drawing.Point(554, 38);
            this.btbAdd.Name = "btbAdd";
            this.btbAdd.Size = new System.Drawing.Size(153, 29);
            this.btbAdd.TabIndex = 28;
            this.btbAdd.Text = "Add";
            this.btbAdd.UseSelectable = true;
            this.btbAdd.Click += new System.EventHandler(this.btbAdd_Click);
            // 
            // txtPhone
            // 
            // 
            // 
            // 
            this.txtPhone.CustomButton.Image = null;
            this.txtPhone.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.txtPhone.CustomButton.Name = "";
            this.txtPhone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPhone.CustomButton.TabIndex = 1;
            this.txtPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPhone.CustomButton.UseSelectable = true;
            this.txtPhone.CustomButton.Visible = false;
            this.txtPhone.Lines = new string[0];
            this.txtPhone.Location = new System.Drawing.Point(113, 175);
            this.txtPhone.MaxLength = 32767;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhone.SelectedText = "";
            this.txtPhone.SelectionLength = 0;
            this.txtPhone.SelectionStart = 0;
            this.txtPhone.ShortcutsEnabled = true;
            this.txtPhone.Size = new System.Drawing.Size(137, 23);
            this.txtPhone.TabIndex = 26;
            this.txtPhone.UseSelectable = true;
            this.txtPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(113, 143);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(137, 23);
            this.txtPassword.TabIndex = 25;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            // 
            // txtUserName
            // 
            // 
            // 
            // 
            this.txtUserName.CustomButton.Image = null;
            this.txtUserName.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.txtUserName.CustomButton.Name = "";
            this.txtUserName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserName.CustomButton.TabIndex = 1;
            this.txtUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUserName.CustomButton.UseSelectable = true;
            this.txtUserName.CustomButton.Visible = false;
            this.txtUserName.Lines = new string[0];
            this.txtUserName.Location = new System.Drawing.Point(113, 110);
            this.txtUserName.MaxLength = 32767;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserName.SelectedText = "";
            this.txtUserName.SelectionLength = 0;
            this.txtUserName.SelectionStart = 0;
            this.txtUserName.ShortcutsEnabled = true;
            this.txtUserName.Size = new System.Drawing.Size(137, 23);
            this.txtUserName.TabIndex = 24;
            this.txtUserName.UseSelectable = true;
            this.txtUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(113, 76);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(137, 23);
            this.txtName.TabIndex = 23;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(25, 173);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(55, 19);
            this.metroLabel4.TabIndex = 21;
            this.metroLabel4.Text = "Phone: ";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(25, 144);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(74, 19);
            this.metroLabel3.TabIndex = 20;
            this.metroLabel3.Text = "Password: ";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(23, 114);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(84, 19);
            this.metroLabel2.TabIndex = 19;
            this.metroLabel2.Text = "User Name: ";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(25, 76);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(52, 19);
            this.metroLabel1.TabIndex = 18;
            this.metroLabel1.Text = "Name: ";
            // 
            // frmCreateClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 502);
            this.Controls.Add(this.grdListUsers);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCreateClient";
            this.Text = "Create Client - Remax";
            this.Load += new System.EventHandler(this.frmCreateClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdListUsers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid grdListUsers;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton btbExit;
        private MetroFramework.Controls.MetroTextBox txtRefAgent;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton btbCancel;
        private MetroFramework.Controls.MetroButton btbDelete;
        private MetroFramework.Controls.MetroButton btbSave;
        private MetroFramework.Controls.MetroButton btbEdit;
        private MetroFramework.Controls.MetroComboBox cboTypeUser;
        private MetroFramework.Controls.MetroLabel lblUserType;
        private MetroFramework.Controls.MetroButton btbAdd;
        private MetroFramework.Controls.MetroTextBox txtPhone;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroTextBox txtUserName;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtPostalCode;
        private MetroFramework.Controls.MetroTextBox txtCity;
        private MetroFramework.Controls.MetroTextBox txtAddress;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
    }
}