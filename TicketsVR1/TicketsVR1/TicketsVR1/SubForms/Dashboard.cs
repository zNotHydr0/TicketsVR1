using System;
using System.Linq;
using System.Windows.Forms;
using System.Net;

namespace Menu.SubForms
{
    public partial class Dashboard : Form
    {
        private Timer timer; // Declaramos el Timer

        public Dashboard()
        {
            InitializeComponent();
            WelcomeMessage();
            InicializarReloj(); // Inicializamos el reloj
            MostrarIP(); // Mostrar la IP al iniciar
        }

        private void WelcomeMessage()
        {
            // Obtenim l'usuari actiu de Windows
            string user = Environment.UserName;
            lblWelcome.Text = $"Welcome {user}!";
        }

        private void InicializarReloj()
        {
            // Configurar el Timer
            timer = new Timer
            {
                Interval = 1000 // Actualizar cada 1 segundo
            };

            // Asignar el evento Tick al Timer
            timer.Tick += (sender, e) =>
            {
                lblTimeESP.Text = "Current time: " + DateTime.Now.ToString("HH:mm:ss"); // Actualizar el Label con la hora
            };

            timer.Start(); // Iniciar el Timer
        }

        private void MostrarIP()
        {
            try
            {
                // Obtener el nombre del host de la máquina
                string hostName = Dns.GetHostName();
                // Obtener todas las direcciones IP asociadas al host
                var ipAddresses = Dns.GetHostAddresses(hostName);

                // Filtrar las direcciones IPv4
                var ipv4Address = ipAddresses.FirstOrDefault(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);

                if (ipv4Address != null)
                {
                    // Mostrar la IP en el Label
                    lblIP.Text = $"IP: {ipv4Address}";
                }
                else
                {
                    lblIP.Text = "IP: 0.0.0.0";
                }
            }
            catch (Exception ex)
            {
                lblIP.Text = "Error: " + ex.Message;
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}