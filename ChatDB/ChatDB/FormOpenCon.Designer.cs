namespace ChatDB
{
    partial class FormOpenCon
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
            this.txt_PW = new System.Windows.Forms.TextBox();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_PW
            // 
            this.txt_PW.Location = new System.Drawing.Point(12, 25);
            this.txt_PW.MaxLength = 64;
            this.txt_PW.Name = "txt_PW";
            this.txt_PW.PasswordChar = '*';
            this.txt_PW.Size = new System.Drawing.Size(203, 20);
            this.txt_PW.TabIndex = 0;
            this.txt_PW.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_PW_KeyDown);
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(12, 69);
            this.txt_Username.MaxLength = 32;
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(203, 20);
            this.txt_Username.TabIndex = 1;
            this.txt_Username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_PW_KeyDown);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(12, 104);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(203, 23);
            this.btn_OK.TabIndex = 2;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(12, 9);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(53, 13);
            this.lbl_Password.TabIndex = 3;
            this.lbl_Password.Text = "Password";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Location = new System.Drawing.Point(14, 53);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(55, 13);
            this.lbl_Username.TabIndex = 4;
            this.lbl_Username.Text = "Username";
            // 
            // FormOpenCon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 139);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.txt_PW);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOpenCon";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connection File Decrypt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_PW;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Username;
    }
}