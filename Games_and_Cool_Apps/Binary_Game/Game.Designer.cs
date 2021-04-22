namespace Binary_Game
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.gBoxBar = new System.Windows.Forms.GroupBox();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblMistakes = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblMistakesLabel = new System.Windows.Forms.Label();
            this.lblLevelLabel = new System.Windows.Forms.Label();
            this.lblScoreLabel = new System.Windows.Forms.Label();
            this.lblTimeLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblNumsLabel = new System.Windows.Forms.Label();
            this.lblNums = new System.Windows.Forms.Label();
            this.gBoxBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxBar
            // 
            this.gBoxBar.BackColor = System.Drawing.Color.Transparent;
            this.gBoxBar.Controls.Add(this.lblClose);
            this.gBoxBar.Controls.Add(this.lblMistakes);
            this.gBoxBar.Controls.Add(this.lblLevel);
            this.gBoxBar.Controls.Add(this.lblScore);
            this.gBoxBar.Controls.Add(this.lblTime);
            this.gBoxBar.Controls.Add(this.lblMistakesLabel);
            this.gBoxBar.Controls.Add(this.lblLevelLabel);
            this.gBoxBar.Controls.Add(this.lblScoreLabel);
            this.gBoxBar.Controls.Add(this.lblTimeLabel);
            this.gBoxBar.Location = new System.Drawing.Point(0, -8);
            this.gBoxBar.Margin = new System.Windows.Forms.Padding(0);
            this.gBoxBar.Name = "gBoxBar";
            this.gBoxBar.Padding = new System.Windows.Forms.Padding(0);
            this.gBoxBar.Size = new System.Drawing.Size(800, 60);
            this.gBoxBar.TabIndex = 0;
            this.gBoxBar.TabStop = false;
            // 
            // lblClose
            // 
            this.lblClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(15)))));
            this.lblClose.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblClose.Font = new System.Drawing.Font("Hobo Std", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblClose.Location = new System.Drawing.Point(636, 14);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(157, 40);
            this.lblClose.TabIndex = 1;
            this.lblClose.Text = "Close";
            this.lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            this.lblClose.MouseLeave += new System.EventHandler(this.ShrinkOnMouseLeave);
            this.lblClose.MouseHover += new System.EventHandler(this.ScaleOnMouseHover);
            // 
            // lblMistakes
            // 
            this.lblMistakes.Font = new System.Drawing.Font("Hobo Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMistakes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMistakes.Location = new System.Drawing.Point(594, 20);
            this.lblMistakes.Name = "lblMistakes";
            this.lblMistakes.Size = new System.Drawing.Size(46, 30);
            this.lblMistakes.TabIndex = 0;
            this.lblMistakes.Text = "0";
            this.lblMistakes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLevel
            // 
            this.lblLevel.Font = new System.Drawing.Font("Hobo Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLevel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLevel.Location = new System.Drawing.Point(458, 20);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(46, 30);
            this.lblLevel.TabIndex = 0;
            this.lblLevel.Text = "1";
            this.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblScore
            // 
            this.lblScore.Font = new System.Drawing.Font("Hobo Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblScore.Location = new System.Drawing.Point(253, 20);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(140, 30);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "0/0";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Hobo Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTime.Location = new System.Drawing.Point(83, 20);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(67, 30);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "00:00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMistakesLabel
            // 
            this.lblMistakesLabel.Font = new System.Drawing.Font("Hobo Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMistakesLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMistakesLabel.Location = new System.Drawing.Point(500, 20);
            this.lblMistakesLabel.Name = "lblMistakesLabel";
            this.lblMistakesLabel.Size = new System.Drawing.Size(100, 30);
            this.lblMistakesLabel.TabIndex = 0;
            this.lblMistakesLabel.Text = "Mistakes:";
            this.lblMistakesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLevelLabel
            // 
            this.lblLevelLabel.Font = new System.Drawing.Font("Hobo Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLevelLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLevelLabel.Location = new System.Drawing.Point(384, 20);
            this.lblLevelLabel.Name = "lblLevelLabel";
            this.lblLevelLabel.Size = new System.Drawing.Size(73, 30);
            this.lblLevelLabel.TabIndex = 0;
            this.lblLevelLabel.Text = "Level:";
            this.lblLevelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblScoreLabel
            // 
            this.lblScoreLabel.Font = new System.Drawing.Font("Hobo Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblScoreLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblScoreLabel.Location = new System.Drawing.Point(145, 20);
            this.lblScoreLabel.Name = "lblScoreLabel";
            this.lblScoreLabel.Size = new System.Drawing.Size(115, 30);
            this.lblScoreLabel.TabIndex = 6;
            this.lblScoreLabel.Text = "Score:";
            this.lblScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTimeLabel
            // 
            this.lblTimeLabel.Font = new System.Drawing.Font("Hobo Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTimeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTimeLabel.Location = new System.Drawing.Point(3, 20);
            this.lblTimeLabel.Name = "lblTimeLabel";
            this.lblTimeLabel.Size = new System.Drawing.Size(83, 30);
            this.lblTimeLabel.TabIndex = 0;
            this.lblTimeLabel.Text = "Time:";
            this.lblTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.Lime;
            this.btnCheck.Font = new System.Drawing.Font("Hobo Std", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCheck.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnCheck.Location = new System.Drawing.Point(631, 400);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(156, 44);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            this.btnCheck.MouseLeave += new System.EventHandler(this.ShrinkOnMouseLeave);
            this.btnCheck.MouseHover += new System.EventHandler(this.ScaleOnMouseHover);
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("Hobo Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMessage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMessage.Location = new System.Drawing.Point(42, 76);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(692, 121);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumsLabel
            // 
            this.lblNumsLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblNumsLabel.Font = new System.Drawing.Font("Hobo Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumsLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNumsLabel.Location = new System.Drawing.Point(547, 176);
            this.lblNumsLabel.Name = "lblNumsLabel";
            this.lblNumsLabel.Size = new System.Drawing.Size(103, 28);
            this.lblNumsLabel.TabIndex = 3;
            this.lblNumsLabel.Text = "Numbers:";
            this.lblNumsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNumsLabel.Visible = false;
            // 
            // lblNums
            // 
            this.lblNums.BackColor = System.Drawing.Color.Transparent;
            this.lblNums.Font = new System.Drawing.Font("Hobo Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNums.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNums.Location = new System.Drawing.Point(652, 176);
            this.lblNums.Name = "lblNums";
            this.lblNums.Size = new System.Drawing.Size(135, 56);
            this.lblNums.TabIndex = 3;
            this.lblNums.Text = "00";
            this.lblNums.Visible = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lblNums);
            this.Controls.Add(this.lblNumsLabel);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.gBoxBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Game";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.gBoxBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxBar;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblLevelLabel;
        private System.Windows.Forms.Label lblScoreLabel;
        private System.Windows.Forms.Label lblTimeLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblMistakes;
        private System.Windows.Forms.Label lblMistakesLabel;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblNumsLabel;
        private System.Windows.Forms.Label lblNums;
    }
}