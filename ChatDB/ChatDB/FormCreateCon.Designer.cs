namespace ChatDB
{
    partial class FormCreateCon
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
            this.grpBox_DBC = new System.Windows.Forms.GroupBox();
            this.txt_EPW = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_DBName = new System.Windows.Forms.Label();
            this.lbl_PW = new System.Windows.Forms.Label();
            this.lbl_UserID = new System.Windows.Forms.Label();
            this.lbl_Server = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_TestCon = new System.Windows.Forms.Button();
            this.txt_Server = new System.Windows.Forms.TextBox();
            this.txt_DBName = new System.Windows.Forms.TextBox();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.txt_PW = new System.Windows.Forms.TextBox();
            this.grpBox_DBC.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBox_DBC
            // 
            this.grpBox_DBC.Controls.Add(this.txt_EPW);
            this.grpBox_DBC.Controls.Add(this.label1);
            this.grpBox_DBC.Controls.Add(this.lbl_DBName);
            this.grpBox_DBC.Controls.Add(this.lbl_PW);
            this.grpBox_DBC.Controls.Add(this.lbl_UserID);
            this.grpBox_DBC.Controls.Add(this.lbl_Server);
            this.grpBox_DBC.Controls.Add(this.btn_Save);
            this.grpBox_DBC.Controls.Add(this.btn_TestCon);
            this.grpBox_DBC.Controls.Add(this.txt_Server);
            this.grpBox_DBC.Controls.Add(this.txt_DBName);
            this.grpBox_DBC.Controls.Add(this.txt_User);
            this.grpBox_DBC.Controls.Add(this.txt_PW);
            this.grpBox_DBC.Location = new System.Drawing.Point(12, 12);
            this.grpBox_DBC.Name = "grpBox_DBC";
            this.grpBox_DBC.Size = new System.Drawing.Size(248, 235);
            this.grpBox_DBC.TabIndex = 5;
            this.grpBox_DBC.TabStop = false;
            this.grpBox_DBC.Text = "Database Connection";
            // 
            // txt_EPW
            // 
            this.txt_EPW.Location = new System.Drawing.Point(99, 165);
            this.txt_EPW.MaxLength = 64;
            this.txt_EPW.Name = "txt_EPW";
            this.txt_EPW.PasswordChar = '*';
            this.txt_EPW.Size = new System.Drawing.Size(140, 20);
            this.txt_EPW.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Encrypt Password";
            // 
            // lbl_DBName
            // 
            this.lbl_DBName.AutoSize = true;
            this.lbl_DBName.Location = new System.Drawing.Point(40, 109);
            this.lbl_DBName.Name = "lbl_DBName";
            this.lbl_DBName.Size = new System.Drawing.Size(53, 13);
            this.lbl_DBName.TabIndex = 9;
            this.lbl_DBName.Text = "Database";
            // 
            // lbl_PW
            // 
            this.lbl_PW.AutoSize = true;
            this.lbl_PW.Location = new System.Drawing.Point(40, 83);
            this.lbl_PW.Name = "lbl_PW";
            this.lbl_PW.Size = new System.Drawing.Size(53, 13);
            this.lbl_PW.TabIndex = 8;
            this.lbl_PW.Text = "Password";
            // 
            // lbl_UserID
            // 
            this.lbl_UserID.AutoSize = true;
            this.lbl_UserID.Location = new System.Drawing.Point(64, 57);
            this.lbl_UserID.Name = "lbl_UserID";
            this.lbl_UserID.Size = new System.Drawing.Size(29, 13);
            this.lbl_UserID.TabIndex = 7;
            this.lbl_UserID.Text = "User";
            // 
            // lbl_Server
            // 
            this.lbl_Server.AutoSize = true;
            this.lbl_Server.Location = new System.Drawing.Point(55, 31);
            this.lbl_Server.Name = "lbl_Server";
            this.lbl_Server.Size = new System.Drawing.Size(38, 13);
            this.lbl_Server.TabIndex = 6;
            this.lbl_Server.Text = "Server";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Save.Location = new System.Drawing.Point(99, 191);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(140, 27);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_TestCon
            // 
            this.btn_TestCon.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_TestCon.Location = new System.Drawing.Point(99, 132);
            this.btn_TestCon.Name = "btn_TestCon";
            this.btn_TestCon.Size = new System.Drawing.Size(140, 27);
            this.btn_TestCon.TabIndex = 4;
            this.btn_TestCon.Text = "Test Connection";
            this.btn_TestCon.UseVisualStyleBackColor = false;
            this.btn_TestCon.Click += new System.EventHandler(this.btn_TestCon_Click);
            // 
            // txt_Server
            // 
            this.txt_Server.Location = new System.Drawing.Point(99, 28);
            this.txt_Server.Name = "txt_Server";
            this.txt_Server.Size = new System.Drawing.Size(140, 20);
            this.txt_Server.TabIndex = 0;
            // 
            // txt_DBName
            // 
            this.txt_DBName.Location = new System.Drawing.Point(99, 106);
            this.txt_DBName.Name = "txt_DBName";
            this.txt_DBName.Size = new System.Drawing.Size(140, 20);
            this.txt_DBName.TabIndex = 3;
            // 
            // txt_User
            // 
            this.txt_User.Location = new System.Drawing.Point(99, 54);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(140, 20);
            this.txt_User.TabIndex = 1;
            // 
            // txt_PW
            // 
            this.txt_PW.Location = new System.Drawing.Point(99, 80);
            this.txt_PW.Name = "txt_PW";
            this.txt_PW.PasswordChar = '*';
            this.txt_PW.Size = new System.Drawing.Size(140, 20);
            this.txt_PW.TabIndex = 2;
            // 
            // FormCreateCon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 257);
            this.Controls.Add(this.grpBox_DBC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormCreateCon";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Connection File";
            this.grpBox_DBC.ResumeLayout(false);
            this.grpBox_DBC.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBox_DBC;
        private System.Windows.Forms.Label lbl_DBName;
        private System.Windows.Forms.Label lbl_PW;
        private System.Windows.Forms.Label lbl_UserID;
        private System.Windows.Forms.Label lbl_Server;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_TestCon;
        private System.Windows.Forms.TextBox txt_Server;
        private System.Windows.Forms.TextBox txt_DBName;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.TextBox txt_PW;
        private System.Windows.Forms.TextBox txt_EPW;
        private System.Windows.Forms.Label label1;
    }
}