using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ChatDB
{
    public partial class FormOpenCon : Form
    {
        public FormOpenCon()
        {
            InitializeComponent();
        }

        //location of connection file, is set by form start, constring is extracted from the .con file
        public string FileLocation, ConString, UserName;
        byte pwcount = 0; //tracks tries on password entry, after 3 quit the form

        #region button ok

        private void btn_OK_Click(object sender, EventArgs e)
        {
            UserName = txt_Username.Text;

            using (StreamReader sr = new StreamReader(FileLocation))
            {
                try
                {
                    //read three times, first to lines are not useful
                    sr.ReadLine();
                    sr.ReadLine();
                    ConString = EncryptString.Decrypt(sr.ReadLine(), txt_PW.Text);
                    //if it's successful return OK and close
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch
                {
                    pwcount++; 
                    MessageBox.Show("File couldn't be decrypted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (pwcount >= 3) //if a user failed 3 times close the form
                        this.Close();
                }
            }
        }

        #endregion
    }
}
