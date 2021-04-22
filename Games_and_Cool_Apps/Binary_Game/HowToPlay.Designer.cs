namespace Binary_Game
{
    partial class HowToPlay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HowToPlay));
            this.btnGotIt = new System.Windows.Forms.Button();
            this.pbGame = new System.Windows.Forms.PictureBox();
            this.pbResult = new System.Windows.Forms.PictureBox();
            this.lblTittle = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGotIt
            // 
            this.btnGotIt.BackColor = System.Drawing.Color.Gold;
            this.btnGotIt.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGotIt.Font = new System.Drawing.Font("Hobo Std", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGotIt.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnGotIt.Location = new System.Drawing.Point(648, 12);
            this.btnGotIt.Name = "btnGotIt";
            this.btnGotIt.Size = new System.Drawing.Size(273, 62);
            this.btnGotIt.TabIndex = 0;
            this.btnGotIt.Text = "Ok, got it!";
            this.btnGotIt.UseVisualStyleBackColor = false;
            // 
            // pbGame
            // 
            this.pbGame.Image = ((System.Drawing.Image)(resources.GetObject("pbGame.Image")));
            this.pbGame.Location = new System.Drawing.Point(12, 278);
            this.pbGame.Name = "pbGame";
            this.pbGame.Size = new System.Drawing.Size(423, 245);
            this.pbGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGame.TabIndex = 1;
            this.pbGame.TabStop = false;
            // 
            // pbResult
            // 
            this.pbResult.Image = ((System.Drawing.Image)(resources.GetObject("pbResult.Image")));
            this.pbResult.Location = new System.Drawing.Point(498, 278);
            this.pbResult.Name = "pbResult";
            this.pbResult.Size = new System.Drawing.Size(423, 245);
            this.pbResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbResult.TabIndex = 1;
            this.pbResult.TabStop = false;
            // 
            // lblTittle
            // 
            this.lblTittle.BackColor = System.Drawing.Color.Transparent;
            this.lblTittle.Font = new System.Drawing.Font("Hobo Std", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTittle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblTittle.Location = new System.Drawing.Point(15, 4);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(382, 89);
            this.lblTittle.TabIndex = 2;
            this.lblTittle.Text = "How To Play";
            this.lblTittle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Font = new System.Drawing.Font("Hobo Std", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblInfo.Location = new System.Drawing.Point(15, 93);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(905, 168);
            this.lblInfo.TabIndex = 3;
            // 
            // HowToPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(933, 535);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.pbResult);
            this.Controls.Add(this.pbGame);
            this.Controls.Add(this.btnGotIt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HowToPlay";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HowToPlay";
            this.Load += new System.EventHandler(this.HowToPlay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGotIt;
        private System.Windows.Forms.PictureBox pbGame;
        private System.Windows.Forms.PictureBox pbResult;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Label lblInfo;
    }
}