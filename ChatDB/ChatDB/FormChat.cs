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

        chatdbdatabaseEntities cdbentity = new chatdbdatabaseEntities();

        private void FormChat_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            foreach (chatdb cdb in cdbentity.chatdb)
            {
                rich_chat.Text = rich_chat.Text + cdb.username + " - " + cdb.date + ": " + cdb.message + "\n";
            }
        }
    }
}
