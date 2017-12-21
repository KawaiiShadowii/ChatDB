namespace ChatDB
{
    partial class FormChat
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChat));
            this.btn_send = new System.Windows.Forms.Button();
            this.rich_chat = new System.Windows.Forms.RichTextBox();
            this.men_menustrip = new System.Windows.Forms.MenuStrip();
            this.intervalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmr_refresh = new System.Windows.Forms.Timer(this.components);
            this.rich_message = new System.Windows.Forms.RichTextBox();
            this.men_menustrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(797, 777);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 72);
            this.btn_send.TabIndex = 1;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // rich_chat
            // 
            this.rich_chat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rich_chat.Location = new System.Drawing.Point(12, 27);
            this.rich_chat.Name = "rich_chat";
            this.rich_chat.ReadOnly = true;
            this.rich_chat.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rich_chat.Size = new System.Drawing.Size(860, 744);
            this.rich_chat.TabIndex = 2;
            this.rich_chat.Text = "";
            // 
            // men_menustrip
            // 
            this.men_menustrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.intervalToolStripMenuItem});
            this.men_menustrip.Location = new System.Drawing.Point(0, 0);
            this.men_menustrip.Name = "men_menustrip";
            this.men_menustrip.Size = new System.Drawing.Size(884, 24);
            this.men_menustrip.TabIndex = 3;
            this.men_menustrip.Text = "menuStrip1";
            // 
            // intervalToolStripMenuItem
            // 
            this.intervalToolStripMenuItem.Name = "intervalToolStripMenuItem";
            this.intervalToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.intervalToolStripMenuItem.Text = "Interval";
            this.intervalToolStripMenuItem.Click += new System.EventHandler(this.intervalToolStripMenuItem_Click);
            // 
            // tmr_refresh
            // 
            this.tmr_refresh.Interval = 3000;
            this.tmr_refresh.Tick += new System.EventHandler(this.tmr_refresh_Tick);
            // 
            // rich_message
            // 
            this.rich_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rich_message.Location = new System.Drawing.Point(12, 777);
            this.rich_message.Name = "rich_message";
            this.rich_message.Size = new System.Drawing.Size(779, 72);
            this.rich_message.TabIndex = 4;
            this.rich_message.Text = "";
            this.rich_message.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rich_message_KeyDown);
            this.rich_message.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rich_message_KeyUp);
            // 
            // FormChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 861);
            this.Controls.Add(this.rich_message);
            this.Controls.Add(this.rich_chat);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.men_menustrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.men_menustrip;
            this.MaximumSize = new System.Drawing.Size(900, 900);
            this.MinimumSize = new System.Drawing.Size(900, 900);
            this.Name = "FormChat";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChat";
            this.Load += new System.EventHandler(this.FormChat_Load);
            this.men_menustrip.ResumeLayout(false);
            this.men_menustrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.RichTextBox rich_chat;
        private System.Windows.Forms.MenuStrip men_menustrip;
        private System.Windows.Forms.ToolStripMenuItem intervalToolStripMenuItem;
        private System.Windows.Forms.Timer tmr_refresh;
        private System.Windows.Forms.RichTextBox rich_message;
    }
}