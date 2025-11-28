namespace TicketingSys
{
    partial class HeaderUC
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
            txtSearch = new TextBox();
            pbLogo = new PictureBox();
            lblProfile = new Label();
            lblNotification = new Label();
            btnMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(386, 25);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(297, 27);
            txtSearch.TabIndex = 2;
            txtSearch.Text = "🔍 search.. ";
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.logo1;
            pbLogo.Location = new Point(113, 17);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(207, 45);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 3;
            pbLogo.TabStop = false;
            // 
            // lblProfile
            // 
            lblProfile.AutoSize = true;
            lblProfile.Font = new Font("Segoe UI", 19F);
            lblProfile.Location = new Point(799, 25);
            lblProfile.Name = "lblProfile";
            lblProfile.Size = new Size(51, 36);
            lblProfile.TabIndex = 4;
            lblProfile.Text = "👤";
            // 
            // lblNotification
            // 
            lblNotification.AutoSize = true;
            lblNotification.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNotification.Location = new Point(746, 25);
            lblNotification.Name = "lblNotification";
            lblNotification.Size = new Size(47, 32);
            lblNotification.TabIndex = 5;
            lblNotification.Text = "🔔";
            // 
            // btnMenu
            // 
            btnMenu.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenu.Location = new Point(26, 22);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(55, 35);
            btnMenu.TabIndex = 6;
            btnMenu.Text = "☰";
            btnMenu.UseVisualStyleBackColor = true;
            // 
            // HeaderUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            Controls.Add(btnMenu);
            Controls.Add(lblNotification);
            Controls.Add(lblProfile);
            Controls.Add(pbLogo);
            Controls.Add(txtSearch);
            Name = "HeaderUC";
            Size = new Size(858, 65);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtSearch;
        private PictureBox pbLogo;
        private Label lblProfile;
        private Label lblNotification;
        private Button btnMenu;
    }
}
