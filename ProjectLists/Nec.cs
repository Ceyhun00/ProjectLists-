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
    public partial class Nec : Form
    {
        public Nec()
        {
            InitializeComponent();
            StringBuilder str1 = new StringBuilder();
            str1.AppendLine("Понедельник ");
            str1.AppendLine();
            str1.AppendLine("Введение в практическую деятельность - 1305");
            str1.AppendLine("Алгебра и Геометрия - 1402");
            str1.AppendLine("Иностранные языки - 1308");
            str1.AppendLine("Русский язык(Лекция) - 198");
            Shd1.Text = str1.ToString();
            StringBuilder str2 = new StringBuilder();
            str2.AppendLine("Вторник");
            str2.AppendLine();
            str2.AppendLine("Физическая Культура");
            str2.AppendLine("Иностранные языки - 1305");
            str2.AppendLine("Математический анализ - 1308");
            str2.AppendLine("Алгоритмы и структуры данных - 1402 ");
            Shd2.Text = str2.ToString();
            StringBuilder str3 = new StringBuilder();
            str3.AppendLine("Среда");
            str3.AppendLine();
            str3.AppendLine("Дискретная математика - 1405");
            str3.AppendLine("Математический анализ - 1302");
            str3.AppendLine("Информатика - 1304");
            str3.AppendLine("Информатика(Лекция)");
            Shd3.Text = str3.ToString();
            StringBuilder str4 = new StringBuilder();
            str4.AppendLine("Четверг");
            str4.AppendLine();
            str4.AppendLine("Алгоритмы и структуры данных - 1305");
            str4.AppendLine("Русский язык и культура речи - 1311");
            str4.AppendLine("Иностранные языки - 1305 ");
            Shd4.Text = str4.ToString();
            StringBuilder str5 = new StringBuilder();
            str5.AppendLine("Пятница");
            str5.AppendLine();
            str5.AppendLine("Физическая культура");
            str5.AppendLine("Алгебра и геометрия - 1308");
            str5.AppendLine("Информатика - 1402 ");
            str5.AppendLine("Дискретная математика - 1308");
            Shd5.Text = str5.ToString();
            StringBuilder str6 = new StringBuilder();
            str6.AppendLine("Суббота");
            str6.AppendLine();
            str6.AppendLine("Алгебра и геометрия(иностранцы) - 1405");
            str6.AppendLine("Алгебра и геометрия(иностранцы) - 1405");
            Shd6.Text = str6.ToString();

        }
        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
