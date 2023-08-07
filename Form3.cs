using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Staj___Not_defteri_uygulaması
{
    public partial class Form3 : Form
    {
        public static string FindWord;

        public Form3()
        {
            InitializeComponent();
            label1.Text = Form1.LabelLangSupportForm3;
            button1.Text = Form1.ButtonLangSupportForm3;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FindWord = textBox1.Text;
            this.Close();
        }
    }
}
