namespace Binary_Game
{
    partial class Winner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Winner));
            this.btnTryAggain = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTryAggain
            // 
            this.btnTryAggain.BackColor = System.Drawing.Color.Yellow;
            this.btnTryAggain.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnTryAggain.Font = new System.Drawing.Font("Hobo Std", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTryAggain.ForeColor = System.Drawing.Color.Olive;
            this.btnTryAggain.Location = new System.Drawing.Point(444, 327);
            this.btnTryAggain.Name = "btnTryAggain";
            this.btnTryAggain.Size = new System.Drawing.Size(189, 44);
            this.btnTryAggain.TabIndex = 1;
            this.btnTryAggain.Text = "Try Again";
            this.btnTryAggain.UseVisualStyleBackColor = false;
            this.btnTryAggain.Click += new System.EventHandler(this.btnTryAggain_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("Hobo Std", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMessage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMessage.Location = new System.Drawing.Point(66, 9);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(508, 68);
            this.lblMessage.TabIndex = 6;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Winner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(645, 383);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnTryAggain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Winner";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Try Again";
            this.Load += new System.EventHandler(this.Winner_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTryAggain;
        private System.Windows.Forms.Label lblMessage;
    }
}