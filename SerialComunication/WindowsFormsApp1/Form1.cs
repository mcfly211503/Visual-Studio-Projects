using System;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SerialPort serialPort1;
        Thread sendDataThread;
        volatile bool sendingData;  // Controla si el envío está activo
        volatile string dataToSend; // Controla qué dato enviar ("a" o "b")

        public Form1()
        {
            InitializeComponent();

            // Inicializa el puerto serie
            serialPort1 = new SerialPort("COM9", 15600); // Ajusta "COM9" y el baud rate
            serialPort1.Open();

            sendingData = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Nada aquí, por ahora
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show("Acceso denegado al puerto COM: " + ex.Message);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error de E/S: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el puerto COM: " + ex.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Cierra el hilo y el puerto serie al cerrar la aplicación
            if (sendDataThread != null && sendDataThread.IsAlive)
            {
                sendingData = false; // Detiene el envío
                sendDataThread.Join(); // Espera a que termine el hilo
            }

            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Al presionar el botón 1, comienza a enviar "a"
            dataToSend = "a";
            StartSendingData();
            label1.Text = "ENCENDIDO";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Al presionar el botón 2, comienza a enviar "b"
            dataToSend = "b";
            StartSendingData();
            label1.Text = "APAGADO";
        }

        private void StartSendingData()
        {
            // Si ya hay un hilo enviando datos, lo detiene
            if (sendDataThread != null && sendDataThread.IsAlive)
            {
                sendingData = false;
                sendDataThread.Join(); // Espera a que el hilo anterior termine
            }

            // Comienza a enviar los datos de forma continua
            sendingData = true;
            sendDataThread = new Thread(SendDataLoop);
            sendDataThread.Start();
        }

        private void SendDataLoop()
        {
            // Enviar datos continuamente hasta que se detenga
            while (sendingData)
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.WriteLine(dataToSend);
                }
                Thread.Sleep(100); // Pausa de 100 ms entre envíos
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                // Aquí se manejaría la recepción de datos si fuera necesario
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error de E/S al leer el puerto: " + ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Error al leer el puerto: " + ex.Message);
            }
        }

        private void UpdateLabels(string data)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(UpdateLabels), data);
            }
            else
            {
                label1.Text = "Altura: " + data;
            }
        }

        private void HandleSerialData(string data)
        {
            // Parsear el dato recibido
            if (double.TryParse(data, out double value))
            {
                if (0 < value && value < 300)
                {
                    if (serialPort1.IsOpen)
                        serialPort1.WriteLine("a");
                }
                else if (300 < value && value < 600)
                {
                    if (serialPort1.IsOpen)
                        serialPort1.WriteLine("b");
                }
            }
        }
    }
}
