
namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            this.TournamentDashboardLabel = new System.Windows.Forms.Label();
            this.LoadExistingDropdown = new System.Windows.Forms.ComboBox();
            this.LoadExistingLabel = new System.Windows.Forms.Label();
            this.LoadTournamentButton = new System.Windows.Forms.Button();
            this.CreateTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TournamentDashboardLabel
            // 
            this.TournamentDashboardLabel.AutoSize = true;
            this.TournamentDashboardLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamentDashboardLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TournamentDashboardLabel.Location = new System.Drawing.Point(178, 21);
            this.TournamentDashboardLabel.Name = "TournamentDashboardLabel";
            this.TournamentDashboardLabel.Size = new System.Drawing.Size(231, 30);
            this.TournamentDashboardLabel.TabIndex = 4;
            this.TournamentDashboardLabel.Text = "Tournament Dashboard";
            // 
            // LoadExistingDropdown
            // 
            this.LoadExistingDropdown.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LoadExistingDropdown.FormattingEnabled = true;
            this.LoadExistingDropdown.Location = new System.Drawing.Point(94, 149);
            this.LoadExistingDropdown.Name = "LoadExistingDropdown";
            this.LoadExistingDropdown.Size = new System.Drawing.Size(399, 38);
            this.LoadExistingDropdown.TabIndex = 15;
            this.LoadExistingDropdown.SelectedIndexChanged += new System.EventHandler(this.RounDropdown_SelectedIndexChanged);
            // 
            // LoadExistingLabel
            // 
            this.LoadExistingLabel.AutoSize = true;
            this.LoadExistingLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadExistingLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LoadExistingLabel.Location = new System.Drawing.Point(209, 109);
            this.LoadExistingLabel.Name = "LoadExistingLabel";
            this.LoadExistingLabel.Size = new System.Drawing.Size(181, 21);
            this.LoadExistingLabel.TabIndex = 14;
            this.LoadExistingLabel.Text = "Load Existing Tournament";
            this.LoadExistingLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // LoadTournamentButton
            // 
            this.LoadTournamentButton.AllowDrop = true;
            this.LoadTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.LoadTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.LoadTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.LoadTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadTournamentButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LoadTournamentButton.Location = new System.Drawing.Point(147, 210);
            this.LoadTournamentButton.Name = "LoadTournamentButton";
            this.LoadTournamentButton.Size = new System.Drawing.Size(302, 33);
            this.LoadTournamentButton.TabIndex = 24;
            this.LoadTournamentButton.Text = "Load Tournament";
            this.LoadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentButton
            // 
            this.CreateTournamentButton.AllowDrop = true;
            this.CreateTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.CreateTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.CreateTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTournamentButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.CreateTournamentButton.Location = new System.Drawing.Point(147, 264);
            this.CreateTournamentButton.Name = "CreateTournamentButton";
            this.CreateTournamentButton.Size = new System.Drawing.Size(302, 91);
            this.CreateTournamentButton.TabIndex = 25;
            this.CreateTournamentButton.Text = "Create Tournament";
            this.CreateTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(587, 404);
            this.Controls.Add(this.CreateTournamentButton);
            this.Controls.Add(this.LoadTournamentButton);
            this.Controls.Add(this.LoadExistingDropdown);
            this.Controls.Add(this.LoadExistingLabel);
            this.Controls.Add(this.TournamentDashboardLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentDashboardForm";
            this.Text = "TournamentDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TournamentDashboardLabel;
        private System.Windows.Forms.ComboBox LoadExistingDropdown;
        private System.Windows.Forms.Label LoadExistingLabel;
        private System.Windows.Forms.Button LoadTournamentButton;
        private System.Windows.Forms.Button CreateTournamentButton;
    }
}