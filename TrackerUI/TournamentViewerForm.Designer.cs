
namespace TrackerUI
{
    partial class TournamentViewerForm
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
            this.TournamentName = new System.Windows.Forms.Label();
            this.RoundLabel = new System.Windows.Forms.Label();
            this.RounDropdown = new System.Windows.Forms.ComboBox();
            this.UnplayedLabel = new System.Windows.Forms.CheckBox();
            this.MatchupListbox = new System.Windows.Forms.ListBox();
            this.Team1 = new System.Windows.Forms.Label();
            this.Team1ScoreLabel = new System.Windows.Forms.Label();
            this.Team1ScoreValue = new System.Windows.Forms.TextBox();
            this.Team2ScoreLabel = new System.Windows.Forms.TextBox();
            this.Team2Score = new System.Windows.Forms.Label();
            this.Team2 = new System.Windows.Forms.Label();
            this.VersusLabel = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.HeaderLabel.Location = new System.Drawing.Point(12, 52);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(94, 21);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "Tournament:";
            // 
            // TournamentName
            // 
            this.TournamentName.AutoSize = true;
            this.TournamentName.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamentName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TournamentName.Location = new System.Drawing.Point(112, 52);
            this.TournamentName.Name = "TournamentName";
            this.TournamentName.Size = new System.Drawing.Size(67, 21);
            this.TournamentName.TabIndex = 1;
            this.TournamentName.Text = "<None>";
            // 
            // RoundLabel
            // 
            this.RoundLabel.AutoSize = true;
            this.RoundLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoundLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.RoundLabel.Location = new System.Drawing.Point(12, 130);
            this.RoundLabel.Name = "RoundLabel";
            this.RoundLabel.Size = new System.Drawing.Size(55, 21);
            this.RoundLabel.TabIndex = 2;
            this.RoundLabel.Text = "Round";
            // 
            // RounDropdown
            // 
            this.RounDropdown.ForeColor = System.Drawing.SystemColors.Highlight;
            this.RounDropdown.FormattingEnabled = true;
            this.RounDropdown.Location = new System.Drawing.Point(116, 124);
            this.RounDropdown.Name = "RounDropdown";
            this.RounDropdown.Size = new System.Drawing.Size(129, 33);
            this.RounDropdown.TabIndex = 3;
            // 
            // UnplayedLabel
            // 
            this.UnplayedLabel.AutoSize = true;
            this.UnplayedLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnplayedLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnplayedLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.UnplayedLabel.Location = new System.Drawing.Point(116, 163);
            this.UnplayedLabel.Name = "UnplayedLabel";
            this.UnplayedLabel.Size = new System.Drawing.Size(129, 25);
            this.UnplayedLabel.TabIndex = 4;
            this.UnplayedLabel.Text = "Unplayed Only";
            this.UnplayedLabel.UseVisualStyleBackColor = true;
            // 
            // MatchupListbox
            // 
            this.MatchupListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MatchupListbox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.MatchupListbox.FormattingEnabled = true;
            this.MatchupListbox.ItemHeight = 25;
            this.MatchupListbox.Location = new System.Drawing.Point(16, 209);
            this.MatchupListbox.Name = "MatchupListbox";
            this.MatchupListbox.Size = new System.Drawing.Size(229, 202);
            this.MatchupListbox.TabIndex = 5;
            // 
            // Team1
            // 
            this.Team1.AutoSize = true;
            this.Team1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Team1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Team1.Location = new System.Drawing.Point(300, 192);
            this.Team1.Name = "Team1";
            this.Team1.Size = new System.Drawing.Size(50, 21);
            this.Team1.TabIndex = 6;
            this.Team1.Text = "Team1";
            // 
            // Team1ScoreLabel
            // 
            this.Team1ScoreLabel.AutoSize = true;
            this.Team1ScoreLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Team1ScoreLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Team1ScoreLabel.Location = new System.Drawing.Point(300, 237);
            this.Team1ScoreLabel.Name = "Team1ScoreLabel";
            this.Team1ScoreLabel.Size = new System.Drawing.Size(47, 21);
            this.Team1ScoreLabel.TabIndex = 7;
            this.Team1ScoreLabel.Text = "Score";
            // 
            // Team1ScoreValue
            // 
            this.Team1ScoreValue.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Team1ScoreValue.Location = new System.Drawing.Point(354, 231);
            this.Team1ScoreValue.Name = "Team1ScoreValue";
            this.Team1ScoreValue.Size = new System.Drawing.Size(100, 33);
            this.Team1ScoreValue.TabIndex = 8;
            // 
            // Team2ScoreLabel
            // 
            this.Team2ScoreLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Team2ScoreLabel.Location = new System.Drawing.Point(354, 349);
            this.Team2ScoreLabel.Name = "Team2ScoreLabel";
            this.Team2ScoreLabel.Size = new System.Drawing.Size(100, 33);
            this.Team2ScoreLabel.TabIndex = 11;
            // 
            // Team2Score
            // 
            this.Team2Score.AutoSize = true;
            this.Team2Score.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Team2Score.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Team2Score.Location = new System.Drawing.Point(300, 349);
            this.Team2Score.Name = "Team2Score";
            this.Team2Score.Size = new System.Drawing.Size(47, 21);
            this.Team2Score.TabIndex = 10;
            this.Team2Score.Text = "Score";
            // 
            // Team2
            // 
            this.Team2.AutoSize = true;
            this.Team2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Team2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Team2.Location = new System.Drawing.Point(300, 311);
            this.Team2.Name = "Team2";
            this.Team2.Size = new System.Drawing.Size(52, 21);
            this.Team2.TabIndex = 9;
            this.Team2.Text = "Team2";
            // 
            // VersusLabel
            // 
            this.VersusLabel.AutoSize = true;
            this.VersusLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.VersusLabel.Location = new System.Drawing.Point(383, 287);
            this.VersusLabel.Name = "VersusLabel";
            this.VersusLabel.Size = new System.Drawing.Size(50, 25);
            this.VersusLabel.TabIndex = 12;
            this.VersusLabel.Text = "-VS-";
            this.VersusLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // Score
            // 
            this.Score.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Score.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.Score.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.Score.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Score.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Score.Location = new System.Drawing.Point(502, 280);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(94, 38);
            this.Score.TabIndex = 13;
            this.Score.Text = "Score";
            this.Score.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(608, 449);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.VersusLabel);
            this.Controls.Add(this.Team2ScoreLabel);
            this.Controls.Add(this.Team2Score);
            this.Controls.Add(this.Team2);
            this.Controls.Add(this.Team1ScoreValue);
            this.Controls.Add(this.Team1ScoreLabel);
            this.Controls.Add(this.Team1);
            this.Controls.Add(this.MatchupListbox);
            this.Controls.Add(this.UnplayedLabel);
            this.Controls.Add(this.RounDropdown);
            this.Controls.Add(this.RoundLabel);
            this.Controls.Add(this.TournamentName);
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "TournamentViewerForm";
            this.Text = "g";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label TournamentName;
        private System.Windows.Forms.Label RoundLabel;
        private System.Windows.Forms.ComboBox RounDropdown;
        private System.Windows.Forms.CheckBox UnplayedLabel;
        private System.Windows.Forms.ListBox MatchupListbox;
        private System.Windows.Forms.Label Team1;
        private System.Windows.Forms.Label Team1ScoreLabel;
        private System.Windows.Forms.TextBox Team1ScoreValue;
        private System.Windows.Forms.TextBox Team2ScoreLabel;
        private System.Windows.Forms.Label Team2Score;
        private System.Windows.Forms.Label Team2;
        private System.Windows.Forms.Label VersusLabel;
        private System.Windows.Forms.Button Score;
    }
}

