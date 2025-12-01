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
            sideBarUc = new SidebarUC();
            headerUc = new HeaderUC();
            tixToolBarUc = new TicketToolbarUC();
            SuspendLayout();
            // 
            // sideBarUc
            // 
            sideBarUc.BackColor = SystemColors.Window;
            sideBarUc.Dock = DockStyle.Left;
            sideBarUc.Location = new Point(0, 0);
            sideBarUc.Name = "sideBarUc";
            sideBarUc.Size = new Size(220, 602);
            sideBarUc.TabIndex = 0;
            // 
            // headerUc
            // 
            headerUc.BackColor = SystemColors.Window;
            headerUc.Dock = DockStyle.Top;
            headerUc.Location = new Point(220, 0);
            headerUc.Name = "headerUc";
            headerUc.Size = new Size(875, 65);
            headerUc.TabIndex = 1;
            // 
            // tixToolBarUc
            // 
            tixToolBarUc.BackColor = SystemColors.Window;
            tixToolBarUc.Dock = DockStyle.Fill;
            tixToolBarUc.Location = new Point(220, 65);
            tixToolBarUc.Name = "tixToolBarUc";
            tixToolBarUc.Size = new Size(875, 537);
            tixToolBarUc.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 602);
            Controls.Add(tixToolBarUc);
            Controls.Add(headerUc);
            Controls.Add(sideBarUc);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private SidebarUC sideBarUc;
        private HeaderUC headerUc;
        private TicketToolbarUC tixToolBarUc;
    }
}
