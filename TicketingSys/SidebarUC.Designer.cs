namespace TicketingSys
{
    partial class SidebarUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnNewTicket = new Button();
            btnInbox = new Button();
            btnPinned = new Button();
            btnSent = new Button();
            btnArchived = new Button();
            pnlManagement = new Panel();
            lblManagement = new Label();
            btnUsers = new Button();
            btnDepartment = new Button();
            btnConcerns = new Button();
            pnlManagement.SuspendLayout();
            SuspendLayout();
            // 
            // btnNewTicket
            // 
            btnNewTicket.BackColor = Color.DarkOrange;
            btnNewTicket.FlatStyle = FlatStyle.Flat;
            btnNewTicket.ForeColor = SystemColors.ButtonHighlight;
            btnNewTicket.Location = new Point(37, 36);
            btnNewTicket.Name = "btnNewTicket";
            btnNewTicket.Size = new Size(130, 42);
            btnNewTicket.TabIndex = 0;
            btnNewTicket.Text = "+ New Ticket";
            btnNewTicket.UseVisualStyleBackColor = false;
            // 
            // btnInbox
            // 
            btnInbox.Location = new Point(37, 98);
            btnInbox.Name = "btnInbox";
            btnInbox.Size = new Size(130, 42);
            btnInbox.TabIndex = 1;
            btnInbox.Text = "INBOX";
            btnInbox.UseVisualStyleBackColor = true;
            // 
            // btnPinned
            // 
            btnPinned.Location = new Point(37, 157);
            btnPinned.Name = "btnPinned";
            btnPinned.Size = new Size(130, 42);
            btnPinned.TabIndex = 2;
            btnPinned.Text = "PINNED";
            btnPinned.UseVisualStyleBackColor = true;
            // 
            // btnSent
            // 
            btnSent.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSent.Location = new Point(37, 226);
            btnSent.Name = "btnSent";
            btnSent.Size = new Size(130, 42);
            btnSent.TabIndex = 3;
            btnSent.Text = "SENT";
            btnSent.UseVisualStyleBackColor = true;
            // 
            // btnArchived
            // 
            btnArchived.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnArchived.Location = new Point(37, 288);
            btnArchived.Name = "btnArchived";
            btnArchived.Size = new Size(130, 42);
            btnArchived.TabIndex = 4;
            btnArchived.Text = "ARCHIVED";
            btnArchived.UseVisualStyleBackColor = true;
            // 
            // pnlManagement
            // 
            pnlManagement.Controls.Add(btnConcerns);
            pnlManagement.Controls.Add(btnDepartment);
            pnlManagement.Controls.Add(lblManagement);
            pnlManagement.Controls.Add(btnUsers);
            pnlManagement.Location = new Point(0, 347);
            pnlManagement.Name = "pnlManagement";
            pnlManagement.Size = new Size(220, 257);
            pnlManagement.TabIndex = 5;
            // 
            // lblManagement
            // 
            lblManagement.AutoSize = true;
            lblManagement.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblManagement.Location = new Point(55, 24);
            lblManagement.Name = "lblManagement";
            lblManagement.Size = new Size(102, 21);
            lblManagement.TabIndex = 1;
            lblManagement.Text = "Management";
            // 
            // btnUsers
            // 
            btnUsers.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUsers.Location = new Point(37, 58);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(130, 42);
            btnUsers.TabIndex = 0;
            btnUsers.Text = "USERS";
            btnUsers.UseVisualStyleBackColor = true;
            // 
            // btnDepartment
            // 
            btnDepartment.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDepartment.Location = new Point(37, 119);
            btnDepartment.Name = "btnDepartment";
            btnDepartment.Size = new Size(130, 42);
            btnDepartment.TabIndex = 2;
            btnDepartment.Text = "DEPARTMENT";
            btnDepartment.UseVisualStyleBackColor = true;
            // 
            // btnConcerns
            // 
            btnConcerns.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConcerns.Location = new Point(37, 188);
            btnConcerns.Name = "btnConcerns";
            btnConcerns.Size = new Size(140, 42);
            btnConcerns.TabIndex = 3;
            btnConcerns.Text = "CONCERNS";
            btnConcerns.UseVisualStyleBackColor = true;
            // 
            // SidebarUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            Controls.Add(pnlManagement);
            Controls.Add(btnArchived);
            Controls.Add(btnSent);
            Controls.Add(btnPinned);
            Controls.Add(btnInbox);
            Controls.Add(btnNewTicket);
            Name = "SidebarUC";
            Size = new Size(220, 604);
            pnlManagement.ResumeLayout(false);
            pnlManagement.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnNewTicket;
        private Button btnInbox;
        private Button btnPinned;
        private Button btnSent;
        private Button btnArchived;
        private Panel pnlManagement;
        private Label lblManagement;
        private Button btnUsers;
        private Button btnConcerns;
        private Button btnDepartment;
    }
}
