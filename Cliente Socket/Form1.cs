using System.Net.Sockets;

namespace Cliente_Socket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            TcpClient tcpClient = new TcpClient();
            tcpClient.Connect(txtIP.Text, int.Parse(txtPuerto.Text));
            btnConectar.Enabled = false;


        }
    }
}
