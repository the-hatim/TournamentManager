
namespace TrackerUI
{
    partial class PrizeListLabel
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
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.TournamentNameLabel = new System.Windows.Forms.Label();
            this.Team1ScoreValue = new System.Windows.Forms.TextBox();
            this.EntryFeeLabel = new System.Windows.Forms.Label();
            this.EntryFeeValue = new System.Windows.Forms.TextBox();
            this.RounDropdown = new System.Windows.Forms.ComboBox();
            this.SelectTeamLabel = new System.Windows.Forms.Label();
            this.CreateNewTeamLink = new System.Windows.Forms.LinkLabel();
            this.Score = new System.Windows.Forms.Button();
            this.CreatePrizeLabel = new System.Windows.Forms.Button();
            this.tournamentplayerlistbox = new System.Windows.Forms.ListBox();
            this.TeamsLabel = new System.Windows.Forms.Label();
            this.DeleteSelectedLabel = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.TeamPlayerLabel = new System.Windows.Forms.Label();
            this.PrizeListBox = new System.Windows.Forms.ListBox();
            this.CreateTournamentLabel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.HeaderLabel.Location = new System.Drawing.Point(15, 24);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(190, 30);
            this.HeaderLabel.TabIndex = 1;
            this.HeaderLabel.Text = "Create Tournament";
            // 
            // TournamentNameLabel
            // 
            this.TournamentNameLabel.AutoSize = true;
            this.TournamentNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamentNameLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TournamentNameLabel.Location = new System.Drawing.Point(15, 90);
            this.TournamentNameLabel.Name = "TournamentNameLabel";
            this.TournamentNameLabel.Size = new System.Drawing.Size(134, 21);
            this.TournamentNameLabel.TabIndex = 8;
            this.TournamentNameLabel.Text = "Tournament Name";
            // 
            // Team1ScoreValue
            // 
            this.Team1ScoreValue.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Team1ScoreValue.Location = new System.Drawing.Point(19, 127);
            this.Team1ScoreValue.Name = "Team1ScoreValue";
            this.Team1ScoreValue.Size = new System.Drawing.Size(280, 35);
            this.Team1ScoreValue.TabIndex = 9;
            // 
            // EntryFeeLabel
            // 
            this.EntryFeeLabel.AutoSize = true;
            this.EntryFeeLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryFeeLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.EntryFeeLabel.Location = new System.Drawing.Point(15, 205);
            this.EntryFeeLabel.Name = "EntryFeeLabel";
            this.EntryFeeLabel.Size = new System.Drawing.Size(72, 21);
            this.EntryFeeLabel.TabIndex = 10;
            this.EntryFeeLabel.Text = "Entry Fee";
            // 
            // EntryFeeValue
            // 
            this.EntryFeeValue.ForeColor = System.Drawing.SystemColors.Highlight;
            this.EntryFeeValue.Location = new System.Drawing.Point(93, 195);
            this.EntryFeeValue.Name = "EntryFeeValue";
            this.EntryFeeValue.Size = new System.Drawing.Size(96, 35);
            this.EntryFeeValue.TabIndex = 11;
            this.EntryFeeValue.Text = "0";
            // 
            // RounDropdown
            // 
            this.RounDropdown.ForeColor = System.Drawing.SystemColors.Highlight;
            this.RounDropdown.FormattingEnabled = true;
            this.RounDropdown.Location = new System.Drawing.Point(19, 292);
            this.RounDropdown.Name = "RounDropdown";
            this.RounDropdown.Size = new System.Drawing.Size(280, 38);
            this.RounDropdown.TabIndex = 12;
            // 
            // SelectTeamLabel
            // 
            this.SelectTeamLabel.AutoSize = true;
            this.SelectTeamLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectTeamLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.SelectTeamLabel.Location = new System.Drawing.Point(15, 258);
            this.SelectTeamLabel.Name = "SelectTeamLabel";
            this.SelectTeamLabel.Size = new System.Drawing.Size(87, 21);
            this.SelectTeamLabel.TabIndex = 13;
            this.SelectTeamLabel.Text = "Select Team";
            // 
            // CreateNewTeamLink
            // 
            this.CreateNewTeamLink.AutoSize = true;
            this.CreateNewTeamLink.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateNewTeamLink.ForeColor = System.Drawing.SystemColors.Highlight;
            this.CreateNewTeamLink.Location = new System.Drawing.Point(208, 268);
            this.CreateNewTeamLink.Name = "CreateNewTeamLink";
            this.CreateNewTeamLink.Size = new System.Drawing.Size(91, 21);
            this.CreateNewTeamLink.TabIndex = 14;
            this.CreateNewTeamLink.TabStop = true;
            this.CreateNewTeamLink.Text = "Create New";
            // 
            // Score
            // 
            this.Score.AllowDrop = true;
            this.Score.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Score.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.Score.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.Score.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Score.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Score.Location = new System.Drawing.Point(93, 360);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(155, 38);
            this.Score.TabIndex = 15;
            this.Score.Text = "Add Team";
            this.Score.UseVisualStyleBackColor = true;
            // 
            // CreatePrizeLabel
            // 
            this.CreatePrizeLabel.AllowDrop = true;
            this.CreatePrizeLabel.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreatePrizeLabel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.CreatePrizeLabel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.CreatePrizeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreatePrizeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatePrizeLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.CreatePrizeLabel.Location = new System.Drawing.Point(93, 422);
            this.CreatePrizeLabel.Name = "CreatePrizeLabel";
            this.CreatePrizeLabel.Size = new System.Drawing.Size(155, 38);
            this.CreatePrizeLabel.TabIndex = 16;
            this.CreatePrizeLabel.Text = "Create Prize";
            this.CreatePrizeLabel.UseVisualStyleBackColor = true;
            // 
            // tournamentplayerlistbox
            // 
            this.tournamentplayerlistbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tournamentplayerlistbox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tournamentplayerlistbox.FormattingEnabled = true;
            this.tournamentplayerlistbox.ItemHeight = 30;
            this.tournamentplayerlistbox.Location = new System.Drawing.Point(331, 114);
            this.tournamentplayerlistbox.Name = "tournamentplayerlistbox";
            this.tournamentplayerlistbox.Size = new System.Drawing.Size(229, 182);
            this.tournamentplayerlistbox.TabIndex = 17;
            // 
            // TeamsLabel
            // 
            this.TeamsLabel.AutoSize = true;
            this.TeamsLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamsLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TeamsLabel.Location = new System.Drawing.Point(327, 90);
            this.TeamsLabel.Name = "TeamsLabel";
            this.TeamsLabel.Size = new System.Drawing.Size(165, 21);
            this.TeamsLabel.TabIndex = 18;
            this.TeamsLabel.Text = "TournamentPlayerLabel";
            // 
            // DeleteSelectedLabel
            // 
            this.DeleteSelectedLabel.AllowDrop = true;
            this.DeleteSelectedLabel.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.DeleteSelectedLabel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.DeleteSelectedLabel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.DeleteSelectedLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSelectedLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSelectedLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.DeleteSelectedLabel.Location = new System.Drawing.Point(366, 314);
            this.DeleteSelectedLabel.Name = "DeleteSelectedLabel";
            this.DeleteSelectedLabel.Size = new System.Drawing.Size(155, 38);
            this.DeleteSelectedLabel.TabIndex = 19;
            this.DeleteSelectedLabel.Text = "Delete Selected";
            this.DeleteSelectedLabel.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.AllowDrop = true;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button3.Location = new System.Drawing.Point(366, 597);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 38);
            this.button3.TabIndex = 22;
            this.button3.Text = "Delete SelectedLabel";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // TeamPlayerLabel
            // 
            this.TeamPlayerLabel.AutoSize = true;
            this.TeamPlayerLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamPlayerLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TeamPlayerLabel.Location = new System.Drawing.Point(327, 368);
            this.TeamPlayerLabel.Name = "TeamPlayerLabel";
            this.TeamPlayerLabel.Size = new System.Drawing.Size(102, 21);
            this.TeamPlayerLabel.TabIndex = 21;
            this.TeamPlayerLabel.Text = "Teams/Players";
            // 
            // PrizeListBox
            // 
            this.PrizeListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrizeListBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.PrizeListBox.FormattingEnabled = true;
            this.PrizeListBox.ItemHeight = 30;
            this.PrizeListBox.Location = new System.Drawing.Point(331, 392);
            this.PrizeListBox.Name = "PrizeListBox";
            this.PrizeListBox.Size = new System.Drawing.Size(229, 182);
            this.PrizeListBox.TabIndex = 20;
            // 
            // CreateTournamentLabel
            // 
            this.CreateTournamentLabel.AllowDrop = true;
            this.CreateTournamentLabel.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateTournamentLabel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.CreateTournamentLabel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.CreateTournamentLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTournamentLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTournamentLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.CreateTournamentLabel.Location = new System.Drawing.Point(149, 653);
            this.CreateTournamentLabel.Name = "CreateTournamentLabel";
            this.CreateTournamentLabel.Size = new System.Drawing.Size(198, 38);
            this.CreateTournamentLabel.TabIndex = 23;
            this.CreateTournamentLabel.Text = "Create Tournament";
            this.CreateTournamentLabel.UseVisualStyleBackColor = true;
            // 
            // PrizeListLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(708, 718);
            this.Controls.Add(this.CreateTournamentLabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.TeamPlayerLabel);
            this.Controls.Add(this.PrizeListBox);
            this.Controls.Add(this.DeleteSelectedLabel);
            this.Controls.Add(this.TeamsLabel);
            this.Controls.Add(this.tournamentplayerlistbox);
            this.Controls.Add(this.CreatePrizeLabel);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.CreateNewTeamLink);
            this.Controls.Add(this.SelectTeamLabel);
            this.Controls.Add(this.RounDropdown);
            this.Controls.Add(this.EntryFeeValue);
            this.Controls.Add(this.EntryFeeLabel);
            this.Controls.Add(this.Team1ScoreValue);
            this.Controls.Add(this.TournamentNameLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "PrizeListLabel";
            this.Text = "CreateTournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label TournamentNameLabel;
        private System.Windows.Forms.TextBox Team1ScoreValue;
        private System.Windows.Forms.Label EntryFeeLabel;
        private System.Windows.Forms.TextBox EntryFeeValue;
        private System.Windows.Forms.ComboBox RounDropdown;
        private System.Windows.Forms.Label SelectTeamLabel;
        private System.Windows.Forms.LinkLabel CreateNewTeamLink;
        private System.Windows.Forms.Button Score;
        private System.Windows.Forms.Button CreatePrizeLabel;
        private System.Windows.Forms.ListBox tournamentplayerlistbox;
        private System.Windows.Forms.Label TeamsLabel;
        private System.Windows.Forms.Button DeleteSelectedLabel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label TeamPlayerLabel;
        private System.Windows.Forms.ListBox PrizeListBox;
        public System.Windows.Forms.Button CreateTournamentLabel;
    }
}