namespace TicketingSys
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sidebaruc1 = new SidebarUC();
            headeruc1 = new HeaderUC();
            ticketToolbaruc1 = new TicketToolbarUC();
            SuspendLayout();
            // 
            // sidebaruc1
            // 
            sidebaruc1.BackColor = SystemColors.Window;
            sidebaruc1.Dock = DockStyle.Left;
            sidebaruc1.Location = new Point(0, 0);
            sidebaruc1.Name = "sidebaruc1";
            sidebaruc1.Size = new Size(220, 602);
            sidebaruc1.TabIndex = 0;
            // 
            // headeruc1
            // 
            headeruc1.BackColor = SystemColors.Window;
            headeruc1.Dock = DockStyle.Top;
            headeruc1.Location = new Point(220, 0);
            headeruc1.Name = "headeruc1";
            headeruc1.Size = new Size(875, 65);
            headeruc1.TabIndex = 1;
            // 
            // ticketToolbaruc1
            // 
            ticketToolbaruc1.BackColor = SystemColors.Window;
            ticketToolbaruc1.Dock = DockStyle.Fill;
            ticketToolbaruc1.Location = new Point(220, 65);
            ticketToolbaruc1.Name = "ticketToolbaruc1";
            ticketToolbaruc1.Size = new Size(875, 537);
            ticketToolbaruc1.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 602);
            Controls.Add(ticketToolbaruc1);
            Controls.Add(headeruc1);
            Controls.Add(sidebaruc1);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private SidebarUC sidebaruc1;
        private HeaderUC headeruc1;
        private TicketToolbarUC ticketToolbaruc1;
    }
}
