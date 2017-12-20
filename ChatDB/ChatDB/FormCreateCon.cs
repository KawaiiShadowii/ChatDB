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
using System.Data.SqlClient;

namespace ChatDB
{
    public partial class FormCreateCon : Form
    {
        public FormCreateCon()
        {
            InitializeComponent();
        }

        #region test connection

        private void btn_TestCon_Click(object sender, EventArgs e)
        {
            chatdbdatabaseEntities testentities = new chatdbdatabaseEntities();
            //replace temporary connection strings with user input in textboxes
            testentities.Database.Connection.ConnectionString = testentities.Database.Connection.ConnectionString.Replace("#server#", txt_Server.Text);
            testentities.Database.Connection.ConnectionString = testentities.Database.Connection.ConnectionString.Replace("#user id#", txt_User.Text);
            testentities.Database.Connection.ConnectionString = testentities.Database.Connection.ConnectionString.Replace("#password#", txt_PW.Text);
            testentities.Database.Connection.ConnectionString = testentities.Database.Connection.ConnectionString.Replace("#database#", txt_DBName.Text);

            IDbConnection con = testentities.Database.Connection;

            try
            {
                con.Open();
                //if it is openable, connection is possible
                MessageBox.Show("Connection successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Connection failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        #endregion

        #region save con file

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //saves a .con file
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Connection Files (*.con)|*.con";
            sfd.Title = "Save";

            //can't be empty password
            if (txt_EPW.Text.Trim() == "")
            {
                MessageBox.Show("Encryption password can't be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            chatdbdatabaseEntities tempentities = new chatdbdatabaseEntities();
            //replace temporary connection strings with user input in textboxes
            tempentities.Database.Connection.ConnectionString = tempentities.Database.Connection.ConnectionString.Replace("#server#", txt_Server.Text);
            tempentities.Database.Connection.ConnectionString = tempentities.Database.Connection.ConnectionString.Replace("#user id#", txt_User.Text);
            tempentities.Database.Connection.ConnectionString = tempentities.Database.Connection.ConnectionString.Replace("#password#", txt_PW.Text);
            tempentities.Database.Connection.ConnectionString = tempentities.Database.Connection.ConnectionString.Replace("#database#", txt_DBName.Text);

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //write the data in the chosen file, so it can be read out by the program
                using (StreamWriter sw = new StreamWriter(sfd.FileName))
                {
                    sw.WriteLine("[ChatDB Connection]");
                    sw.WriteLine();
                    sw.WriteLine(EncryptString.Encrypt(tempentities.Database.Connection.ConnectionString,txt_EPW.Text));

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }

            sfd.Dispose();
        }

        #endregion
    }
}
