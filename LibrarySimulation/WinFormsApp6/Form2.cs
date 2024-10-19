using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool a=!String.IsNullOrEmpty(textBox1.Text);
            bool b=!String.IsNullOrEmpty(textBox2.Text);
            bool c=!String.IsNullOrEmpty(textBox3.Text);

            if (a==true && b==true && c==true) 
            { 
            string titulo= textBox1 .Text;
            string autor = textBox2 .Text;
            int code = Convert.ToInt32(textBox3.Text);
            libro x= new libro (titulo, autor, code);
                x.info();
                Form1 asd = (Form1)Application.OpenForms["Form1"];
                asd.actualizarlibros(x);
                MessageBox.Show(x.informacion, "Se ha agregado el libro: ", MessageBoxButtons.OK);
                this.Hide();

            }
        }
    }
}
