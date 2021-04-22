namespace Flappy_Birds_Santa_Edd
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.lblGameOver = new System.Windows.Forms.Label();
            this.pbGround = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbBlueDown = new System.Windows.Forms.PictureBox();
            this.pbBlueUp = new System.Windows.Forms.PictureBox();
            this.pbRedDown = new System.Windows.Forms.PictureBox();
            this.pbRedUp = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.pbReindeer = new System.Windows.Forms.PictureBox();
            this.lblDistance = new System.Windows.Forms.Label();
            this.lblEndDistance = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlueDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlueUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRedDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRedUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReindeer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGameOver
            // 
            this.lblGameOver.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGameOver.Font = new System.Drawing.Font("Sitka Subheading", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblGameOver.Location = new System.Drawing.Point(0, 0);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(540, 221);
            this.lblGameOver.TabIndex = 23;
            this.lblGameOver.Text = "Game Over";
            this.lblGameOver.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblGameOver.Visible = false;
            // 
            // pbGround
            // 
            this.pbGround.Image = global::Flappy_Birds_Santa_Edd.Properties.Resources.ground;
            this.pbGround.Location = new System.Drawing.Point(0, 383);
            this.pbGround.Name = "pbGround";
            this.pbGround.Size = new System.Drawing.Size(1090, 117);
            this.pbGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGround.TabIndex = 0;
            this.pbGround.TabStop = false;
            // 
            // gameLoop
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbBlueDown
            // 
            this.pbBlueDown.BackColor = System.Drawing.Color.Transparent;
            this.pbBlueDown.Image = global::Flappy_Birds_Santa_Edd.Properties.Resources.blue_removebg_preview;
            this.pbBlueDown.Location = new System.Drawing.Point(528, 224);
            this.pbBlueDown.Name = "pbBlueDown";
            this.pbBlueDown.Size = new System.Drawing.Size(39, 159);
            this.pbBlueDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBlueDown.TabIndex = 2;
            this.pbBlueDown.TabStop = false;
            // 
            // pbBlueUp
            // 
            this.pbBlueUp.BackColor = System.Drawing.Color.Transparent;
            this.pbBlueUp.Image = global::Flappy_Birds_Santa_Edd.Properties.Resources.blue_reversed;
            this.pbBlueUp.Location = new System.Drawing.Point(528, 0);
            this.pbBlueUp.Name = "pbBlueUp";
            this.pbBlueUp.Size = new System.Drawing.Size(39, 145);
            this.pbBlueUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBlueUp.TabIndex = 2;
            this.pbBlueUp.TabStop = false;
            // 
            // pbRedDown
            // 
            this.pbRedDown.BackColor = System.Drawing.Color.Transparent;
            this.pbRedDown.Image = global::Flappy_Birds_Santa_Edd.Properties.Resources.red_removebg_preview;
            this.pbRedDown.Location = new System.Drawing.Point(807, 227);
            this.pbRedDown.Name = "pbRedDown";
            this.pbRedDown.Size = new System.Drawing.Size(39, 159);
            this.pbRedDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRedDown.TabIndex = 2;
            this.pbRedDown.TabStop = false;
            // 
            // pbRedUp
            // 
            this.pbRedUp.BackColor = System.Drawing.Color.Transparent;
            this.pbRedUp.Image = global::Flappy_Birds_Santa_Edd.Properties.Resources.red_reversed;
            this.pbRedUp.Location = new System.Drawing.Point(807, 0);
            this.pbRedUp.Name = "pbRedUp";
            this.pbRedUp.Size = new System.Drawing.Size(39, 145);
            this.pbRedUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRedUp.TabIndex = 2;
            this.pbRedUp.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::Flappy_Birds_Santa_Edd.Properties.Resources.yellow_gradient_26949_1920x1200;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Green;
            this.btnClose.Location = new System.Drawing.Point(312, 428);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(216, 60);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Back to the Menu";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnClose_MouseClick);
            // 
            // pbReindeer
            // 
            this.pbReindeer.BackColor = System.Drawing.Color.Transparent;
            this.pbReindeer.Image = ((System.Drawing.Image)(resources.GetObject("pbReindeer.Image")));
            this.pbReindeer.Location = new System.Drawing.Point(108, 146);
            this.pbReindeer.Name = "pbReindeer";
            this.pbReindeer.Size = new System.Drawing.Size(69, 62);
            this.pbReindeer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbReindeer.TabIndex = 21;
            this.pbReindeer.TabStop = false;
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(216)))), ((int)(((byte)(149)))));
            this.lblDistance.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistance.Location = new System.Drawing.Point(12, 440);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(303, 38);
            this.lblDistance.TabIndex = 22;
            this.lblDistance.Text = "рррррррррррррррррр";
            // 
            // lblEndDistance
            // 
            this.lblEndDistance.BackColor = System.Drawing.Color.Transparent;
            this.lblEndDistance.Font = new System.Drawing.Font("Sitka Subheading", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDistance.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblEndDistance.Location = new System.Drawing.Point(0, 221);
            this.lblEndDistance.Name = "lblEndDistance";
            this.lblEndDistance.Size = new System.Drawing.Size(540, 279);
            this.lblEndDistance.TabIndex = 24;
            this.lblEndDistance.Text = "label1";
            this.lblEndDistance.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblEndDistance.Visible = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Flappy_Birds_Santa_Edd.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(540, 500);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblEndDistance);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.pbReindeer);
            this.Controls.Add(this.pbRedUp);
            this.Controls.Add(this.pbRedDown);
            this.Controls.Add(this.pbBlueUp);
            this.Controls.Add(this.pbBlueDown);
            this.Controls.Add(this.pbGround);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameForm";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlueDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlueUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRedDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRedUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReindeer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGround;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pbBlueDown;
        private System.Windows.Forms.PictureBox pbBlueUp;
        private System.Windows.Forms.PictureBox pbRedDown;
        private System.Windows.Forms.PictureBox pbRedUp;
        private System.Windows.Forms.PictureBox pbReindeer;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Label lblEndDistance;
    }
}