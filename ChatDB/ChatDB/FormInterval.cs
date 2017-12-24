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
    public partial class FormInterval : Form
    {
        public FormInterval()
        {
            InitializeComponent();
        }

        public decimal Interval;

        private void btn_OK_Click(object sender, EventArgs e)
        {
            Interval = num_Interval.Value;
            //return ok if successful
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            //just close, let interval be the same
            this.Close();
        }

        private void num_Interval_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_OK.PerformClick();
        }
    }
}
