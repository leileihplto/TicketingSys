namespace TicketingSys
{
    partial class TicketToolbarUC
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
            btnRefresh = new Button();
            btnFilter = new Button();
            lblPagination = new Label();
            panel1 = new Panel();
            btnResolved = new Button();
            btnInProgress = new Button();
            btnOpen = new Button();
            btnAll = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.Window;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 10F);
            btnRefresh.Location = new Point(83, 12);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(88, 35);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "⟳ Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnFilter
            // 
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Segoe UI", 10F);
            btnFilter.Location = new Point(193, 12);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(76, 35);
            btnFilter.TabIndex = 1;
            btnFilter.Text = "⚲ Filter";
            btnFilter.UseVisualStyleBackColor = true;
            // 
            // lblPagination
            // 
            lblPagination.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPagination.AutoSize = true;
            lblPagination.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPagination.Location = new Point(881, 21);
            lblPagination.Name = "lblPagination";
            lblPagination.Size = new Size(94, 17);
            lblPagination.TabIndex = 2;
            lblPagination.Text = "< 1-20 of 20 >";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Controls.Add(btnResolved);
            panel1.Controls.Add(btnInProgress);
            panel1.Controls.Add(btnOpen);
            panel1.Controls.Add(btnAll);
            panel1.Location = new Point(83, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(919, 45);
            panel1.TabIndex = 3;
            // 
            // btnResolved
            // 
            btnResolved.Font = new Font("Segoe UI", 11F);
            btnResolved.Location = new Point(440, 8);
            btnResolved.Name = "btnResolved";
            btnResolved.Size = new Size(113, 31);
            btnResolved.TabIndex = 3;
            btnResolved.Text = "✔ RESOLVED";
            btnResolved.UseVisualStyleBackColor = true;
            // 
            // btnInProgress
            // 
            btnInProgress.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInProgress.Location = new Point(257, 6);
            btnInProgress.Name = "btnInProgress";
            btnInProgress.Size = new Size(144, 34);
            btnInProgress.TabIndex = 2;
            btnInProgress.Text = "⌛IN PROGRESS";
            btnInProgress.UseVisualStyleBackColor = true;
            // 
            // btnOpen
            // 
            btnOpen.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOpen.Location = new Point(124, 8);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(90, 31);
            btnOpen.TabIndex = 1;
            btnOpen.Text = "📖 OPEN";
            btnOpen.UseVisualStyleBackColor = true;
            // 
            // btnAll
            // 
            btnAll.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAll.Location = new Point(17, 6);
            btnAll.Name = "btnAll";
            btnAll.Size = new Size(71, 34);
            btnAll.TabIndex = 0;
            btnAll.Text = "⊞ ALL";
            btnAll.UseVisualStyleBackColor = true;
            // 
            // TicketToolbarUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            Controls.Add(panel1);
            Controls.Add(lblPagination);
            Controls.Add(btnFilter);
            Controls.Add(btnRefresh);
            Name = "TicketToolbarUC";
            Size = new Size(1005, 654);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRefresh;
        private Button btnFilter;
        private Label lblPagination;
        private Panel panel1;
        private Button btnResolved;
        private Button btnInProgress;
        private Button btnOpen;
        private Button btnAll;
    }
}
