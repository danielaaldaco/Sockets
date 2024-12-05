using System.Net.Sockets;
using System.Text;

namespace Cliente_Socket
{
    public partial class Form1 : Form
    {
        TcpClient tcpClient = new TcpClient();
        Stream stm;
        Thread hilo;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                tcpClient.Connect(txtIP.Text, int.Parse(txtPuerto.Text));
                MessageBox.Show("Conectado al Servidor");
                btnConectar.Enabled = false;
                btnEnviar.Enabled = true;
                hilo = new Thread(new ThreadStart(RecibirMensaje));
                hilo.Start();
            }
            catch (Exception ex) {
                MessageBox.Show("Error en la conexion");
            }

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string mensaje = txtMensaje.Text;
            ASCIIEncoding aciiEncode = new ASCIIEncoding();
            byte[] mensajeBytes = aciiEncode.GetBytes(mensaje);
            stm = tcpClient.GetStream();
            stm.Write(mensajeBytes, 0, mensajeBytes.Length);

        }

        private void RecibirMensaje()
        {
            while (true)
            {
                byte[] bb = new byte[100];
                int k = stm.Read(bb, 0, 100);
                string mensajeRecibido = "";
                for (int i = 0; i < k; i++)
                {
                    mensajeRecibido = mensajeRecibido + Convert.ToChar(bb[i]);
                }
                Mensaje(mensajeRecibido);
            }
        }

        private void Mensaje(string message)
        {
            if (rtbMensaje.InvokeRequired)
            {
                rtbMensaje.Invoke(new MethodInvoker(delegate
                {
                    rtbMensaje.Text = rtbMensaje.Text + message;

                }));
            }
            else
            {
                rtbMensaje.Text = rtbMensaje.Text + message;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            tcpClient.Close();
        }
    }
}
