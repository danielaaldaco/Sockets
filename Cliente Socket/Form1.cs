using System.Net.Sockets;
using System.Text;

namespace Cliente_Socket
{
    public partial class Form1 : Form
    {
        TcpClient tcpClient = new TcpClient();
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
            }
            catch(Exception ex ) { }
            



        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string mensaje = txtMensaje.Text;
            ASCIIEncoding aciiEncode = new ASCIIEncoding();
            byte[] mensajeBytes = aciiEncode.GetBytes(mensaje);
            Stream stm = tcpClient.GetStream();
            stm.Write(mensajeBytes, 0, mensajeBytes.Length);

        }
    }
}
