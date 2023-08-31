using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityWinForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Bekzod" && textBox3.Text == "bekzod28072009")
            {
                new Form1().Show();
                this.Hide();
                textBox1.Clear();
                textBox3.Clear();
                textBox1.Focus();
            }
            else
            {
                MessageBox.Show("Login or password is incorrect, please try again!", MessageBoxButtons.YesNoCancel(), MessageBoxIcon.Error);
            }
        }
    }
}
