using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            // Inicializa el puerto serie
            serialPort1 = new SerialPort("COM20", 15600); // Ajusta "COM20" al puerto COM correcto y 9600 al baud rate correcto
            serialPort1.Open();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
