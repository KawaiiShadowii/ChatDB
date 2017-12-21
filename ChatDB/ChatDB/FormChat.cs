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
    public partial class FormChat : Form
    {
        public FormChat()
        {
            InitializeComponent();
        }

        public string ConString = "", UserName = ""; 

        chatdbdatabaseEntities cdbentity = new chatdbdatabaseEntities();
        chatdb tablecdb = new chatdb();

        //speed of the chat refresh
        decimal interval;

        bool shift = false;
        bool enter = false;

        private void FormChat_Load(object sender, EventArgs e)
        {
            cdbentity.Database.Connection.ConnectionString = ConString;
            RefreshData();
        }

        private void RefreshData()
        {
            rich_chat.Clear();

            foreach (chatdb cdb in cdbentity.chatdb)
            {
                rich_chat.Text = rich_chat.Text + cdb.username + " - " + cdb.date + ": " + cdb.message + "\n";
            }
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            if (!txt_message.Text.Trim().Equals(""))
            {
                try
                {
                    tablecdb.mid = CheckID();
                    tablecdb.username = UserName;
                    tablecdb.date = DateTime.Now;
                    tablecdb.message = txt_message.Text;

                    cdbentity.chatdb.Add(tablecdb);

                    cdbentity.SaveChanges();

                    RefreshData();

                    txt_message.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private int CheckID()
        {
            for (int i = 1; true; i++)
            {
                if (cdbentity.chatdb.Where(x => x.mid == i).FirstOrDefault() == null)
                {
                    return i;
                }
            }
        }

        private void txt_message_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ShiftKey)
            {
                shift = true;
            }

            if (e.KeyCode == Keys.Enter)
            {
                 enter = true;
            }

            if (enter && shift)
            {
                
            }
            else if (enter)
            {
                btn_send.PerformClick();
            }
        }

        private void intervalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //set interval with form interval
            FormInterval finterval = new FormInterval();
            if (finterval.ShowDialog() == DialogResult.OK)
            {
                interval = finterval.Interval;
            }

            finterval.Dispose();
        }

        private void txt_message_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ShiftKey)
            {
                shift = false;
            }

            if (e.KeyCode == Keys.Enter)
            {
                enter = false;
            }
        }
    }
}
