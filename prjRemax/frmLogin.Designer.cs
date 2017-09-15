namespace prjRemax.GUI
{
    partial class frmLogin
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
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.linkLabelChangePassword = new System.Windows.Forms.LinkLabel();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonLogInMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserName.Location = new System.Drawing.Point(248, 82);
            this.textBoxUserName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(233, 22);
            this.textBoxUserName.TabIndex = 14;
            this.textBoxUserName.Text = "mary";
            // 
            // linkLabelChangePassword
            // 
            this.linkLabelChangePassword.AutoSize = true;
            this.linkLabelChangePassword.Location = new System.Drawing.Point(388, 148);
            this.linkLabelChangePassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelChangePassword.Name = "linkLabelChangePassword";
            this.linkLabelChangePassword.Size = new System.Drawing.Size(93, 13);
            this.linkLabelChangePassword.TabIndex = 16;
            this.linkLabelChangePassword.TabStop = true;
            this.linkLabelChangePassword.Text = "Change Password";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(122, 119);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(71, 16);
            this.labelPassword.TabIndex = 20;
            this.labelPassword.Text = "Password:";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(122, 82);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(80, 16);
            this.labelUsername.TabIndex = 18;
            this.labelUsername.Text = "User Name:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(248, 119);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(233, 22);
            this.textBoxPassword.TabIndex = 15;
            this.textBoxPassword.Text = "mary";
            // 
            // buttonExit
            // 
            this.buttonExit.AutoSize = true;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(332, 181);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(149, 32);
            this.buttonExit.TabIndex = 19;
            this.buttonExit.Text = "&Cancel";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // buttonLogInMain
            // 
            this.buttonLogInMain.AutoSize = true;
            this.buttonLogInMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogInMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogInMain.Location = new System.Drawing.Point(125, 181);
            this.buttonLogInMain.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogInMain.Name = "buttonLogInMain";
            this.buttonLogInMain.Size = new System.Drawing.Size(152, 32);
            this.buttonLogInMain.TabIndex = 17;
            this.buttonLogInMain.Text = "&LogIn";
            this.buttonLogInMain.UseVisualStyleBackColor = true;
            this.buttonLogInMain.Click += new System.EventHandler(this.buttonLogInMain_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 275);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.linkLabelChangePassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonLogInMain);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.Resizable = false;
            this.Text = "Log in";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.LinkLabel linkLabelChangePassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonLogInMain;
    }
}