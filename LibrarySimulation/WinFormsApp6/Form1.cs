using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        List<libro> listalibros = new List<libro>();
        List<usuario> listausuario = new List<usuario>();
        string listaprestamos = "";

        public void actualizarlibros(libro a)
        {
            listalibros.Add(a);
            listBox1.Items.Add(a);
        }

        public void actualizarusuarios(usuario b)
        {
            listausuario.Add(b);
            listBox2.Items.Add(b);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 x = new Form2();
            x.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count == 1)
            {
                libro x = (libro)listBox1.SelectedItems[0];
                MessageBox.Show(x.informacion, "Info:", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Seleccione exactamente un libro", "Error", MessageBoxButtons.OK);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            libro x = (libro)listBox1.SelectedItems[0];
            listalibros.Remove(x);
            listBox1.Items.Remove(listBox1.SelectedItems[0]);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItems.Count == 1)
            {
                usuario x = (usuario)listBox2.SelectedItems[0];
                MessageBox.Show(x.informacion, "Info:", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Seleccione exactamente un usuario", "Error", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedItems.Count == 1 && listBox2.SelectedItems.Count == 1)
            {

                libro a = (libro)listBox1.SelectedItems[0];
                usuario b = (usuario)listBox2.SelectedItems[0];

                if (a.prestado == "Actualmente, disponible para prestamo")
                {
                    if (a.code==1 && b.edad<18)
                    {
                        MessageBox.Show("No se puede prestar este libro, es menor de edad", "Error", MessageBoxButtons.OK);
                    }
                    else
                    {
                        b.prestar(a);
                        listaprestamos += a.informacion + b.informacion + "\n-------------------------------------------------------------";

                    }
                }
                else
                {
                    MessageBox.Show("No se puede prestar un libro ocupado", "Error", MessageBoxButtons.OK);
                }

            }
            else
            {
                MessageBox.Show("Seleccione exactamente un usuario y un libro", "Error", MessageBoxButtons.OK);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            usuario x = (usuario)listBox2.SelectedItems[0];
            listausuario.Remove(x);
            listBox2.Items.Remove(listBox2.SelectedItems[0]);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItems.Count == 1)
            {
                usuario x = (usuario)listBox2.SelectedItems[0];

                string a = "";
                for (int i = 0; i < x.listaprestamos.Count; i++)
                {
                    a = a + x.listaprestamos[i].informacion;
                }
                MessageBox.Show(a, "Historial Prestamos:", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Seleccione exactamente un usuario", "Error", MessageBoxButtons.OK);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {


            if (listBox1.SelectedItems.Count == 1 && listBox2.SelectedItems.Count == 1)
            {

                libro a = (libro)listBox1.SelectedItems[0];
                usuario b = (usuario)listBox2.SelectedItems[0];
                int aa = 0;
                for (int i = 0; i < b.listaprestamos.Count; i++)
                {
                    if (b.listaprestamos[i] == a)
                    {
                        aa = 1;
                    }

                }

                if (aa == 0)
                {
                    MessageBox.Show("Este usuario no presto este libro", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    b.devolver(a);
                }

            }
            else
            {
                MessageBox.Show("Seleccione exactamente un usuario y un libro", "Error", MessageBoxButtons.OK);
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            string nombreArchivo = "Historial"+ ".txt";
            string rutaCarpeta = @"C:\Users\Len\Documents\Visual Studio 2022\Codigos\WinFormsApp6";
            string rutaArchivo = Path.Combine(rutaCarpeta, nombreArchivo);

            using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
            {
                writer.WriteLine(listaprestamos);
                writer.WriteLine();
            }
            MessageBox.Show("Historial de ventas guardado en: " + "\n" + rutaCarpeta, "Cierre de Caja Exitoso", MessageBoxButtons.OK);

        }
    }
}
