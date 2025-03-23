
namespace Menu.SubForms
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblIP = new System.Windows.Forms.Label();
            this.lblTimeESP = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblCurrentTickets = new System.Windows.Forms.Label();
            this.lblDepartmentTickets = new System.Windows.Forms.Label();
            this.lblTittle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblIP
            // 
            this.lblIP.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblIP.AutoSize = true;
            this.lblIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIP.Location = new System.Drawing.Point(434, 562);
            this.lblIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(93, 20);
            this.lblIP.TabIndex = 7;
            this.lblIP.Text = "IP: 0.0.0.0";
            // 
            // lblTimeESP
            // 
            this.lblTimeESP.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTimeESP.AutoSize = true;
            this.lblTimeESP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeESP.Location = new System.Drawing.Point(387, 523);
            this.lblTimeESP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimeESP.Name = "lblTimeESP";
            this.lblTimeESP.Size = new System.Drawing.Size(198, 20);
            this.lblTimeESP.TabIndex = 6;
            this.lblTimeESP.Text = "Current time: 00:00:00";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(18, 100);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(101, 20);
            this.lblWelcome.TabIndex = 8;
            this.lblWelcome.Text = "Welcome...";
            // 
            // lblCurrentTickets
            // 
            this.lblCurrentTickets.AutoSize = true;
            this.lblCurrentTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTickets.Location = new System.Drawing.Point(18, 149);
            this.lblCurrentTickets.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentTickets.Name = "lblCurrentTickets";
            this.lblCurrentTickets.Size = new System.Drawing.Size(156, 20);
            this.lblCurrentTickets.TabIndex = 9;
            this.lblCurrentTickets.Text = "Current tickets: 0";
            // 
            // lblDepartmentTickets
            // 
            this.lblDepartmentTickets.AutoSize = true;
            this.lblDepartmentTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentTickets.Location = new System.Drawing.Point(18, 197);
            this.lblDepartmentTickets.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartmentTickets.Name = "lblDepartmentTickets";
            this.lblDepartmentTickets.Size = new System.Drawing.Size(266, 20);
            this.lblDepartmentTickets.TabIndex = 10;
            this.lblDepartmentTickets.Text = "Tickets from my department: 0";
            // 
            // lblTittle
            // 
            this.lblTittle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.Location = new System.Drawing.Point(15, 22);
            this.lblTittle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(202, 40);
            this.lblTittle.TabIndex = 11;
            this.lblTittle.Text = "Dashboard";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 617);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.lblDepartmentTickets);
            this.Controls.Add(this.lblCurrentTickets);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.lblTimeESP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label lblTimeESP;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblCurrentTickets;
        private System.Windows.Forms.Label lblDepartmentTickets;
        private System.Windows.Forms.Label lblTittle;
    }
}