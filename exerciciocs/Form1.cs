using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exerciciocs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        RTFFile meutexto = new RTFFile();

        private void Button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText(path, richTextBox1.Text);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            meutexto.Texto = richTextBox1.Text;
        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
