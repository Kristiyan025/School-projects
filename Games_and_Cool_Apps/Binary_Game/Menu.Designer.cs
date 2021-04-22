namespace Binary_Game
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.lblStart = new System.Windows.Forms.Label();
            this.lblHow = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.pBoxBg = new System.Windows.Forms.PictureBox();
            this.pBoxEn = new System.Windows.Forms.PictureBox();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.lblNickname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxBg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxEn)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStart
            // 
            this.lblStart.BackColor = System.Drawing.Color.Transparent;
            this.lblStart.Font = new System.Drawing.Font("Gabriola", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStart.ForeColor = System.Drawing.SystemColors.Info;
            this.lblStart.Location = new System.Drawing.Point(217, 145);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(223, 53);
            this.lblStart.TabIndex = 0;
            this.lblStart.Text = "Нова игра";
            this.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStart.Click += new System.EventHandler(this.lblStart_Click);
            this.lblStart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtNicknameLoseFocus);
            this.lblStart.MouseLeave += new System.EventHandler(this.Out);
            this.lblStart.MouseHover += new System.EventHandler(this.Hover);
            // 
            // lblHow
            // 
            this.lblHow.BackColor = System.Drawing.Color.Transparent;
            this.lblHow.Font = new System.Drawing.Font("Gabriola", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHow.ForeColor = System.Drawing.SystemColors.Info;
            this.lblHow.Location = new System.Drawing.Point(217, 215);
            this.lblHow.Name = "lblHow";
            this.lblHow.Size = new System.Drawing.Size(235, 60);
            this.lblHow.TabIndex = 0;
            this.lblHow.Text = "Как се играе";
            this.lblHow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHow.Click += new System.EventHandler(this.lblHow_Click);
            this.lblHow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtNicknameLoseFocus);
            this.lblHow.MouseLeave += new System.EventHandler(this.Out);
            this.lblHow.MouseHover += new System.EventHandler(this.Hover);
            // 
            // lblClose
            // 
            this.lblClose.BackColor = System.Drawing.Color.Transparent;
            this.lblClose.Font = new System.Drawing.Font("Gabriola", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClose.ForeColor = System.Drawing.SystemColors.Info;
            this.lblClose.Location = new System.Drawing.Point(249, 289);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(163, 60);
            this.lblClose.TabIndex = 0;
            this.lblClose.Text = "Затвори";
            this.lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            this.lblClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtNicknameLoseFocus);
            this.lblClose.MouseLeave += new System.EventHandler(this.Out);
            this.lblClose.MouseHover += new System.EventHandler(this.Hover);
            // 
            // pBoxBg
            // 
            this.pBoxBg.Image = ((System.Drawing.Image)(resources.GetObject("pBoxBg.Image")));
            this.pBoxBg.Location = new System.Drawing.Point(295, 395);
            this.pBoxBg.Name = "pBoxBg";
            this.pBoxBg.Size = new System.Drawing.Size(36, 25);
            this.pBoxBg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxBg.TabIndex = 1;
            this.pBoxBg.TabStop = false;
            this.pBoxBg.Click += new System.EventHandler(this.pBoxBg_Click);
            this.pBoxBg.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtNicknameLoseFocus);
            // 
            // pBoxEn
            // 
            this.pBoxEn.Cursor = System.Windows.Forms.Cursors.Default;
            this.pBoxEn.Image = ((System.Drawing.Image)(resources.GetObject("pBoxEn.Image")));
            this.pBoxEn.Location = new System.Drawing.Point(349, 395);
            this.pBoxEn.Name = "pBoxEn";
            this.pBoxEn.Size = new System.Drawing.Size(36, 25);
            this.pBoxEn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxEn.TabIndex = 1;
            this.pBoxEn.TabStop = false;
            this.pBoxEn.Click += new System.EventHandler(this.pBoxEn_Click);
            this.pBoxEn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtNicknameLoseFocus);
            // 
            // txtNickname
            // 
            this.txtNickname.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNickname.Location = new System.Drawing.Point(279, 71);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(176, 35);
            this.txtNickname.TabIndex = 2;
            // 
            // lblNickname
            // 
            this.lblNickname.BackColor = System.Drawing.Color.Transparent;
            this.lblNickname.Font = new System.Drawing.Font("Gabriola", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNickname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNickname.Location = new System.Drawing.Point(143, 58);
            this.lblNickname.Name = "lblNickname";
            this.lblNickname.Size = new System.Drawing.Size(137, 54);
            this.lblNickname.TabIndex = 3;
            this.lblNickname.Text = "Прякор:";
            this.lblNickname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNickname.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtNicknameLoseFocus);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(713, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lblNickname);
            this.Controls.Add(this.txtNickname);
            this.Controls.Add(this.pBoxEn);
            this.Controls.Add(this.pBoxBg);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblHow);
            this.Controls.Add(this.lblStart);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Binary Game";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtNicknameLoseFocus);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxBg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxEn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblHow;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.PictureBox pBoxBg;
        private System.Windows.Forms.PictureBox pBoxEn;
        private System.Windows.Forms.TextBox txtNickname;
        private System.Windows.Forms.Label lblNickname;
    }
}

