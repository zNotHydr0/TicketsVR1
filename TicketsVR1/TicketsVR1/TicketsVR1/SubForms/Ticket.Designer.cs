
namespace TicketsVR1.SubForms
{
    partial class Ticket
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
            this.lblTittle = new System.Windows.Forms.Label();
            this.lblAssignedUser = new System.Windows.Forms.Label();
            this.lblCreatorUser = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTittle
            // 
            this.lblTittle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("JetBrains Mono Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.Location = new System.Drawing.Point(306, 20);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(179, 31);
            this.lblTittle.TabIndex = 13;
            this.lblTittle.Text = "Ticket Name";
            // 
            // lblAssignedUser
            // 
            this.lblAssignedUser.AutoSize = true;
            this.lblAssignedUser.Font = new System.Drawing.Font("JetBrains Mono Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignedUser.Location = new System.Drawing.Point(172, 78);
            this.lblAssignedUser.Name = "lblAssignedUser";
            this.lblAssignedUser.Size = new System.Drawing.Size(111, 14);
            this.lblAssignedUser.TabIndex = 14;
            this.lblAssignedUser.Text = "Assigned User";
            // 
            // lblCreatorUser
            // 
            this.lblCreatorUser.AutoSize = true;
            this.lblCreatorUser.Font = new System.Drawing.Font("JetBrains Mono Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatorUser.Location = new System.Drawing.Point(33, 78);
            this.lblCreatorUser.Name = "lblCreatorUser";
            this.lblCreatorUser.Size = new System.Drawing.Size(103, 14);
            this.lblCreatorUser.TabIndex = 15;
            this.lblCreatorUser.Text = "Creator User";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("JetBrains Mono Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(33, 149);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(95, 14);
            this.lblDescription.TabIndex = 16;
            this.lblDescription.Text = "Description";
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblCreatorUser);
            this.Controls.Add(this.lblAssignedUser);
            this.Controls.Add(this.lblTittle);
            this.Name = "Ticket";
            this.Text = "Ticket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Label lblAssignedUser;
        private System.Windows.Forms.Label lblCreatorUser;
        private System.Windows.Forms.Label lblDescription;
    }
}