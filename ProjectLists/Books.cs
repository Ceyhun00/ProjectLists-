using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectLists
{
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("chrome.exe", "https://vk.com/doc494531747_475155924?hash=f95868f587616581ae&dl=e6dd2162bb9478d647");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("chrome.exe", "https://vk.com/doc494531747_475152193?hash=ab48cc8774b59b368a&dl=368c1531abdbf10fd7");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("chrome.exe", "https://vk.com/doc494531747_492434896?hash=c793fb3d9c6c390014&dl=4447a618e91d2bc800");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("chrome.exe", "https://vk.com/doc494531747_475455130?hash=c94b0639097802011d&dl=01fbcf78024cdbc416");
        }
    }
}
