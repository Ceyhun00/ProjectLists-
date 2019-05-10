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
    public partial class Link : Form
    {
        public Link()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("chrome.exe", "https://vk.com/stockdu");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("chrome.exe", "https://github.com/");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("chrome.exe", "https://stackoverflow.com/");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("chrome.exe", "https://www.smashingmagazine.com/2017/10/improving-performance-security/");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("chrome.exe", "http://learn.javascript.ru/");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start("chrome.exe", "http://css.yoksel.ru/");
         }
    }
}
