using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectLoL
{
    public partial class Form2 : Form
    {
        public string summonerName, Server;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 31, 63);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            summonerName = sumName.Text;
            Server = server.Text;
            Form1 f1 = new Form1();
            f1.f2 = this;
            f1.Show();
            this.Hide();


        }
    }
}
