using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatDB
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            FormChat fc = new FormChat();
            fc.ShowDialog();
            fc.Dispose();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {

        }
    }
}
