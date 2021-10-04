using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Discord.Webhook;

namespace DiscordWebhookTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Webhook webhook = new Webhook();
            webhook.SendMessage(richTextBox1.Text, richTextBox4.Text, richTextBox6.Text, richTextBox5.Text);


        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 formm = new Form2();
            formm.Show();
        }
    }
}
