using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketsVR1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            // Login logic...

            // Open the main menu
            this.Hide();
            Form Menu = new Form();
            Menu.Show();
            Menu.FormClosed += (s, args) => this.Show();
        }
    }
}
