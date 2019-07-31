namespace BS_game
{
    partial class Form1
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
            this.lblNew = new System.Windows.Forms.Label();
            this.lblHow = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNew
            // 
            this.lblNew.BackColor = System.Drawing.Color.Transparent;
            this.lblNew.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNew.ForeColor = System.Drawing.Color.LightCyan;
            this.lblNew.Location = new System.Drawing.Point(61, 29);
            this.lblNew.Name = "lblNew";
            this.lblNew.Size = new System.Drawing.Size(165, 39);
            this.lblNew.TabIndex = 0;
            this.lblNew.Text = "New game";
            this.lblNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNew.Click += new System.EventHandler(this.lblNew_Click);
            this.lblNew.MouseLeave += new System.EventHandler(this.lblNew_MouseLeave);
            this.lblNew.MouseHover += new System.EventHandler(this.lblNew_MouseHover);
            // 
            // lblHow
            // 
            this.lblHow.BackColor = System.Drawing.Color.Transparent;
            this.lblHow.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHow.ForeColor = System.Drawing.Color.LightCyan;
            this.lblHow.Location = new System.Drawing.Point(60, 111);
            this.lblHow.Name = "lblHow";
            this.lblHow.Size = new System.Drawing.Size(165, 39);
            this.lblHow.TabIndex = 1;
            this.lblHow.Text = "How to play";
            this.lblHow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHow.MouseLeave += new System.EventHandler(this.lblNew_MouseLeave);
            this.lblHow.MouseHover += new System.EventHandler(this.lblNew_MouseHover);
            // 
            // lblClose
            // 
            this.lblClose.BackColor = System.Drawing.Color.Transparent;
            this.lblClose.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.LightCyan;
            this.lblClose.Location = new System.Drawing.Point(60, 183);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(165, 39);
            this.lblClose.TabIndex = 2;
            this.lblClose.Text = "Close";
            this.lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            this.lblClose.MouseLeave += new System.EventHandler(this.lblNew_MouseLeave);
            this.lblClose.MouseHover += new System.EventHandler(this.lblNew_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BS_game.Properties.Resources.wall_wallpaper_concrete_colored_painted_textured_concept_53876_31799;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblHow);
            this.Controls.Add(this.lblNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNew;
        private System.Windows.Forms.Label lblHow;
        private System.Windows.Forms.Label lblClose;
    }
}

