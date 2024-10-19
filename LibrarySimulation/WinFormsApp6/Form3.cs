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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool a =!string.IsNullOrEmpty(textBox1.Text);
            bool b=!string.IsNullOrEmpty(textBox2.Text);
            bool c=!string.IsNullOrEmpty(textBox3.Text);
            bool d=!string.IsNullOrEmpty(textBox4.Text);
            bool ee=!string.IsNullOrEmpty(textBox5.Text);

            if (a==true && b== true && c==true && d==true && ee==true)
            {
                string nombre=textBox1.Text;
                int id =Convert.ToInt32(textBox2.Text);
                int dia = Convert.ToInt32(textBox3.Text);
                int mes = Convert.ToInt32(textBox4.Text);
                int año = Convert.ToInt32(textBox5.Text);

                usuario x = new usuario(nombre, id, dia, mes, año);
                x.info();
                Form1 asd = (Form1)Application.OpenForms["Form1"];
                asd.actualizarusuarios(x);
                MessageBox.Show(x.informacion, "Se ha agregado el libro: ", MessageBoxButtons.OK);
                this.Hide();
            }
        }
    }
}
