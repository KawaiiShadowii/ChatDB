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
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        #region open .con file

        private void btn_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Multiselect = false;
            openFile.Filter = "Connection Files (*.con)|*.con";
            openFile.Title = "Choose a connection file.";

            //save the location of the new databaseconnection string file
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                //asks for password of file and username
                FormOpenCon foc = new FormOpenCon();
                foc.FileLocation = openFile.FileName;
                openFile.Dispose();

                if (foc.ShowDialog() == DialogResult.OK) //if it's successful
                {
                    FormChat formChat = new FormChat();
                    formChat.ConString = foc.ConString;
                    formChat.UserName = foc.UserName;
                    foc.Dispose();
                    this.Hide();
                    formChat.ShowDialog();
                    this.Show();

                }
                else
                {
                    foc.Dispose();
                }

            }
            else
            {
                openFile.Dispose();
            }
        }

        #endregion

        #region create .con file

        private void btn_Create_Click(object sender, EventArgs e)
        {
            FormCreateCon fcc = new FormCreateCon();
            fcc.ShowDialog();
            fcc.Dispose();
        }

        #endregion
    }
}
