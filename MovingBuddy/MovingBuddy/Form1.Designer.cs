namespace MovingBuddy
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.man = new System.Windows.Forms.PictureBox();
            this.walk = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.man)).BeginInit();
            this.SuspendLayout();
            // 
            // man
            // 
            this.man.Image = ((System.Drawing.Image)(resources.GetObject("man.Image")));
            this.man.Location = new System.Drawing.Point(0, 0);
            this.man.Name = "man";
            this.man.Size = new System.Drawing.Size(100, 100);
            this.man.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.man.TabIndex = 0;
            this.man.TabStop = false;
            // 
            // walk
            // 
            this.walk.Enabled = true;
            this.walk.Interval = 5;
            this.walk.Tick += new System.EventHandler(this.walk_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.man);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogging Buddy";
            ((System.ComponentModel.ISupportInitialize)(this.man)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox man;
        private System.Windows.Forms.Timer walk;
    }
}

