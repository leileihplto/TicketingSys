using System;
using System.Windows.Forms;

namespace TicketingSys
{
    public partial class SidebarUC : UserControl
    {
        // Event to tell MainForm that "New Ticket" was clicked
        public event EventHandler OnNewTicketClicked;

        public SidebarUC()
        {
            InitializeComponent(); // REQUIRED for Designer

            // Wire up the button logic manually
            // (Ensure your button is named 'btnNewTicket' in Properties!)
            if (btnNewTicket != null)
            {
                btnNewTicket.Click += (s, e) => OnNewTicketClicked?.Invoke(this, EventArgs.Empty);
            }
        }

        // Fix for accidental double-clicks in designer
        private void SidebarUC_Load(object sender, EventArgs e) { }
    }
}