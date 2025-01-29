using System;
using System.Windows.Forms;

namespace Menu
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenSubForms(new SubForms.Dashboard());
        }

        private void OpenSubForms(object formName)
        {
            if (this.panelSubForms.Controls.Count > 0)
                this.panelSubForms.Controls.RemoveAt(0);

            Form fn = formName as Form;
            fn.TopLevel = false;
            fn.Dock = DockStyle.Fill;
            this.panelSubForms.Controls.Add(fn);
            this.panelSubForms.Tag = fn;
            fn.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenSubForms(new SubForms.Dashboard());
        }

        private void btnMyTickets_Click(object sender, EventArgs e)
        {
            OpenSubForms(new MyTickets());
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://github.com/zNotHydr0/TicketsVR1",
                UseShellExecute = true // Asegura que se use el navegador predeterminado
            });
        }

        private void lblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}