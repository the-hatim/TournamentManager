
namespace TrackerUI
{
    partial class CreateTeamForms
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
            this.Team1ScoreValue = new System.Windows.Forms.TextBox();
            this.TeamNameLabel = new System.Windows.Forms.Label();
            this.SelectTeamMemberLabel = new System.Windows.Forms.Label();
            this.RounDropdown = new System.Windows.Forms.ComboBox();
            this.AddMemberLabel = new System.Windows.Forms.Button();
            this.AddNewMemberLabel = new System.Windows.Forms.GroupBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.FirstNameValue = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.LastNameValue = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.CellphoneLabel = new System.Windows.Forms.Label();
            this.EmailValue = new System.Windows.Forms.TextBox();
            this.CellphoneValue = new System.Windows.Forms.TextBox();
            this.CreateMemberLabel = new System.Windows.Forms.Button();
            this.tournamentplayerlistbox = new System.Windows.Forms.ListBox();
            this.DeleteSelectedMemberLabel = new System.Windows.Forms.Button();
            this.CreateTeamLabel = new System.Windows.Forms.Button();
            this.AddNewMemberLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.HeaderLabel.Location = new System.Drawing.Point(12, 24);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(128, 30);
            this.HeaderLabel.TabIndex = 2;
            this.HeaderLabel.Text = "Create Team";
            // 
            // Team1ScoreValue
            // 
            this.Team1ScoreValue.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Team1ScoreValue.Location = new System.Drawing.Point(16, 106);
            this.Team1ScoreValue.Name = "Team1ScoreValue";
            this.Team1ScoreValue.Size = new System.Drawing.Size(280, 33);
            this.Team1ScoreValue.TabIndex = 11;
            // 
            // TeamNameLabel
            // 
            this.TeamNameLabel.AutoSize = true;
            this.TeamNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamNameLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TeamNameLabel.Location = new System.Drawing.Point(12, 69);
            this.TeamNameLabel.Name = "TeamNameLabel";
            this.TeamNameLabel.Size = new System.Drawing.Size(88, 21);
            this.TeamNameLabel.TabIndex = 10;
            this.TeamNameLabel.Text = "Team Name";
            this.TeamNameLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // SelectTeamMemberLabel
            // 
            this.SelectTeamMemberLabel.AutoSize = true;
            this.SelectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectTeamMemberLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.SelectTeamMemberLabel.Location = new System.Drawing.Point(12, 171);
            this.SelectTeamMemberLabel.Name = "SelectTeamMemberLabel";
            this.SelectTeamMemberLabel.Size = new System.Drawing.Size(147, 21);
            this.SelectTeamMemberLabel.TabIndex = 12;
            this.SelectTeamMemberLabel.Text = "Select Team Member";
            // 
            // RounDropdown
            // 
            this.RounDropdown.ForeColor = System.Drawing.SystemColors.Highlight;
            this.RounDropdown.FormattingEnabled = true;
            this.RounDropdown.Location = new System.Drawing.Point(16, 211);
            this.RounDropdown.Name = "RounDropdown";
            this.RounDropdown.Size = new System.Drawing.Size(280, 33);
            this.RounDropdown.TabIndex = 13;
            // 
            // AddMemberLabel
            // 
            this.AddMemberLabel.AllowDrop = true;
            this.AddMemberLabel.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.AddMemberLabel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.AddMemberLabel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.AddMemberLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddMemberLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMemberLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.AddMemberLabel.Location = new System.Drawing.Point(61, 274);
            this.AddMemberLabel.Name = "AddMemberLabel";
            this.AddMemberLabel.Size = new System.Drawing.Size(155, 38);
            this.AddMemberLabel.TabIndex = 20;
            this.AddMemberLabel.Text = "Add Member";
            this.AddMemberLabel.UseVisualStyleBackColor = true;
            // 
            // AddNewMemberLabel
            // 
            this.AddNewMemberLabel.Controls.Add(this.CreateMemberLabel);
            this.AddNewMemberLabel.Controls.Add(this.CellphoneValue);
            this.AddNewMemberLabel.Controls.Add(this.EmailValue);
            this.AddNewMemberLabel.Controls.Add(this.CellphoneLabel);
            this.AddNewMemberLabel.Controls.Add(this.EmailLabel);
            this.AddNewMemberLabel.Controls.Add(this.LastNameValue);
            this.AddNewMemberLabel.Controls.Add(this.LastNameLabel);
            this.AddNewMemberLabel.Controls.Add(this.FirstNameValue);
            this.AddNewMemberLabel.Controls.Add(this.FirstNameLabel);
            this.AddNewMemberLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.AddNewMemberLabel.Location = new System.Drawing.Point(16, 339);
            this.AddNewMemberLabel.Name = "AddNewMemberLabel";
            this.AddNewMemberLabel.Size = new System.Drawing.Size(492, 258);
            this.AddNewMemberLabel.TabIndex = 21;
            this.AddNewMemberLabel.TabStop = false;
            this.AddNewMemberLabel.Text = "Add New Member";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.FirstNameLabel.Location = new System.Drawing.Point(8, 56);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(80, 21);
            this.FirstNameLabel.TabIndex = 9;
            this.FirstNameLabel.Text = "First Name";
            // 
            // FirstNameValue
            // 
            this.FirstNameValue.Location = new System.Drawing.Point(94, 50);
            this.FirstNameValue.Name = "FirstNameValue";
            this.FirstNameValue.Size = new System.Drawing.Size(168, 33);
            this.FirstNameValue.TabIndex = 10;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.LastNameLabel.Location = new System.Drawing.Point(8, 110);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(80, 21);
            this.LastNameLabel.TabIndex = 11;
            this.LastNameLabel.Text = "Last Name";
            // 
            // LastNameValue
            // 
            this.LastNameValue.Location = new System.Drawing.Point(94, 110);
            this.LastNameValue.Name = "LastNameValue";
            this.LastNameValue.Size = new System.Drawing.Size(168, 33);
            this.LastNameValue.TabIndex = 12;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.EmailLabel.Location = new System.Drawing.Point(8, 164);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(45, 21);
            this.EmailLabel.TabIndex = 13;
            this.EmailLabel.Text = "Email";
            // 
            // CellphoneLabel
            // 
            this.CellphoneLabel.AutoSize = true;
            this.CellphoneLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CellphoneLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.CellphoneLabel.Location = new System.Drawing.Point(8, 218);
            this.CellphoneLabel.Name = "CellphoneLabel";
            this.CellphoneLabel.Size = new System.Drawing.Size(78, 21);
            this.CellphoneLabel.TabIndex = 14;
            this.CellphoneLabel.Text = "Cellphone";
            // 
            // EmailValue
            // 
            this.EmailValue.Location = new System.Drawing.Point(94, 158);
            this.EmailValue.Name = "EmailValue";
            this.EmailValue.Size = new System.Drawing.Size(168, 33);
            this.EmailValue.TabIndex = 15;
            // 
            // CellphoneValue
            // 
            this.CellphoneValue.Location = new System.Drawing.Point(94, 212);
            this.CellphoneValue.Name = "CellphoneValue";
            this.CellphoneValue.Size = new System.Drawing.Size(168, 33);
            this.CellphoneValue.TabIndex = 16;
            // 
            // CreateMemberLabel
            // 
            this.CreateMemberLabel.AllowDrop = true;
            this.CreateMemberLabel.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateMemberLabel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.CreateMemberLabel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.CreateMemberLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateMemberLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateMemberLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.CreateMemberLabel.Location = new System.Drawing.Point(319, 110);
            this.CreateMemberLabel.Name = "CreateMemberLabel";
            this.CreateMemberLabel.Size = new System.Drawing.Size(155, 81);
            this.CreateMemberLabel.TabIndex = 22;
            this.CreateMemberLabel.Text = "Create Member";
            this.CreateMemberLabel.UseVisualStyleBackColor = true;
            // 
            // tournamentplayerlistbox
            // 
            this.tournamentplayerlistbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tournamentplayerlistbox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tournamentplayerlistbox.FormattingEnabled = true;
            this.tournamentplayerlistbox.ItemHeight = 25;
            this.tournamentplayerlistbox.Location = new System.Drawing.Point(585, 69);
            this.tournamentplayerlistbox.Name = "tournamentplayerlistbox";
            this.tournamentplayerlistbox.Size = new System.Drawing.Size(336, 527);
            this.tournamentplayerlistbox.TabIndex = 22;
            // 
            // DeleteSelectedMemberLabel
            // 
            this.DeleteSelectedMemberLabel.AllowDrop = true;
            this.DeleteSelectedMemberLabel.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.DeleteSelectedMemberLabel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.DeleteSelectedMemberLabel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.DeleteSelectedMemberLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSelectedMemberLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSelectedMemberLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.DeleteSelectedMemberLabel.Location = new System.Drawing.Point(964, 274);
            this.DeleteSelectedMemberLabel.Name = "DeleteSelectedMemberLabel";
            this.DeleteSelectedMemberLabel.Size = new System.Drawing.Size(155, 81);
            this.DeleteSelectedMemberLabel.TabIndex = 23;
            this.DeleteSelectedMemberLabel.Text = "Delete Selected Member";
            this.DeleteSelectedMemberLabel.UseVisualStyleBackColor = true;
            // 
            // CreateTeamLabel
            // 
            this.CreateTeamLabel.AllowDrop = true;
            this.CreateTeamLabel.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateTeamLabel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.CreateTeamLabel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.CreateTeamLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTeamLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTeamLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.CreateTeamLabel.Location = new System.Drawing.Point(287, 647);
            this.CreateTeamLabel.Name = "CreateTeamLabel";
            this.CreateTeamLabel.Size = new System.Drawing.Size(537, 81);
            this.CreateTeamLabel.TabIndex = 24;
            this.CreateTeamLabel.Text = "Create Team";
            this.CreateTeamLabel.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1138, 735);
            this.Controls.Add(this.CreateTeamLabel);
            this.Controls.Add(this.DeleteSelectedMemberLabel);
            this.Controls.Add(this.tournamentplayerlistbox);
            this.Controls.Add(this.AddNewMemberLabel);
            this.Controls.Add(this.AddMemberLabel);
            this.Controls.Add(this.RounDropdown);
            this.Controls.Add(this.SelectTeamMemberLabel);
            this.Controls.Add(this.Team1ScoreValue);
            this.Controls.Add(this.TeamNameLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "CreateTeamForms";
            this.Text = "CreateTeam";
            this.Load += new System.EventHandler(this.CreateTeamForms_Load);
            this.AddNewMemberLabel.ResumeLayout(false);
            this.AddNewMemberLabel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.TextBox Team1ScoreValue;
        private System.Windows.Forms.Label TeamNameLabel;
        private System.Windows.Forms.Label SelectTeamMemberLabel;
        private System.Windows.Forms.ComboBox RounDropdown;
        private System.Windows.Forms.Button AddMemberLabel;
        private System.Windows.Forms.GroupBox AddNewMemberLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox CellphoneValue;
        private System.Windows.Forms.TextBox EmailValue;
        private System.Windows.Forms.Label CellphoneLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox LastNameValue;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox FirstNameValue;
        private System.Windows.Forms.Button CreateMemberLabel;
        private System.Windows.Forms.ListBox tournamentplayerlistbox;
        private System.Windows.Forms.Button DeleteSelectedMemberLabel;
        private System.Windows.Forms.Button CreateTeamLabel;
    }
}