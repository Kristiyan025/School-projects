namespace NLO_igra
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHits = new System.Windows.Forms.Label();
            this.laser = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cannon = new System.Windows.Forms.PictureBox();
            this.nlo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMissed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cannon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nlo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Points:";
            // 
            // lblHits
            // 
            this.lblHits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHits.Location = new System.Drawing.Point(69, 8);
            this.lblHits.Name = "lblHits";
            this.lblHits.Size = new System.Drawing.Size(33, 19);
            this.lblHits.TabIndex = 1;
            this.lblHits.Text = "0";
            // 
            // laser
            // 
            this.laser.BackColor = System.Drawing.Color.Red;
            this.laser.Location = new System.Drawing.Point(216, 340);
            this.laser.Name = "laser";
            this.laser.Size = new System.Drawing.Size(4, 11);
            this.laser.TabIndex = 2;
            this.laser.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cannon
            // 
            this.cannon.Image = global::NLO_igra.Properties.Resources.LaserCannon;
            this.cannon.Location = new System.Drawing.Point(210, 358);
            this.cannon.Name = "cannon";
            this.cannon.Size = new System.Drawing.Size(18, 15);
            this.cannon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cannon.TabIndex = 4;
            this.cannon.TabStop = false;
            // 
            // nlo
            // 
            this.nlo.Image = global::NLO_igra.Properties.Resources.nlo;
            this.nlo.Location = new System.Drawing.Point(12, 32);
            this.nlo.Name = "nlo";
            this.nlo.Size = new System.Drawing.Size(39, 27);
            this.nlo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.nlo.TabIndex = 3;
            this.nlo.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(180, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Missed:";
            // 
            // lblMissed
            // 
            this.lblMissed.AutoSize = true;
            this.lblMissed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMissed.Location = new System.Drawing.Point(262, 9);
            this.lblMissed.Name = "lblMissed";
            this.lblMissed.Size = new System.Drawing.Size(19, 20);
            this.lblMissed.TabIndex = 6;
            this.lblMissed.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 391);
            this.Controls.Add(this.lblMissed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cannon);
            this.Controls.Add(this.nlo);
            this.Controls.Add(this.laser);
            this.Controls.Add(this.lblHits);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "NLO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.cannon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nlo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHits;
        private System.Windows.Forms.Label laser;
        private System.Windows.Forms.PictureBox nlo;
        private System.Windows.Forms.PictureBox cannon;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMissed;
    }
}

