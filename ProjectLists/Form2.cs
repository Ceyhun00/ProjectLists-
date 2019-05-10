using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectLists
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cetn cetn = new Cetn();
            cetn.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nec nec = new Nec();
            nec.Show();
        }
    }
}
