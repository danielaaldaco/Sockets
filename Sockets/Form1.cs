using System.Diagnostics;
using System.Net;
using System.Net.Sockets;

namespace Sockets
{
    public partial class Form1 : Form
    {
        Thread server;
        public Form1()
        {
            InitializeComponent();
        }

        private void escuchar()
        {
            while (true)
            {
                try
                {
                    IPAddress ipAD = IPAddress.Any;
                    TcpListener lista = new TcpListener(ipAD, 8001);
                    lista.Start();
                    Mensaje("Servidor corriendo en el puerto 8001");
                    Mensaje("\nLocal End Point: " + ipAD.ToString());
                    Mensaje("\nEsperando conexion\n");
                    Socket s = lista.AcceptSocket();
                    Mensaje("Conexion recibida desde: " + s.RemoteEndPoint?.ToString());
                    byte[] b = new byte[100];
                    int k = s.Receive(b);
                    string cadena = "";
                    for (int i = 0; i < k; i++)
                    {
                        cadena = cadena + Convert.ToChar(b[i]);
                    }
                    Mensaje(cadena);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }

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

        private void btnServidor_Click(object sender, EventArgs e)
        {
            server = new Thread(new ThreadStart(escuchar));
            server.Start();
        }
    }
}

