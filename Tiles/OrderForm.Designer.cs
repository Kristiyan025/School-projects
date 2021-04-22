
namespace plochki
{
    partial class OrderForm
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
            System.Windows.Forms.Label lblName;
            System.Windows.Forms.Label lblAddress;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            this.btnGoBack = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.gbTiles = new System.Windows.Forms.GroupBox();
            this.pbTile = new System.Windows.Forms.PictureBox();
            this.rbtnTile10 = new System.Windows.Forms.RadioButton();
            this.rbtnTile7 = new System.Windows.Forms.RadioButton();
            this.rbtnTile9 = new System.Windows.Forms.RadioButton();
            this.rbtnTile8 = new System.Windows.Forms.RadioButton();
            this.rbtnTile6 = new System.Windows.Forms.RadioButton();
            this.rbtnTile5 = new System.Windows.Forms.RadioButton();
            this.rbtnTile4 = new System.Windows.Forms.RadioButton();
            this.rbtnTile3 = new System.Windows.Forms.RadioButton();
            this.rbtnTile2 = new System.Windows.Forms.RadioButton();
            this.rbtnTile1 = new System.Windows.Forms.RadioButton();
            this.lblTilePrice = new System.Windows.Forms.Label();
            this.gbBath = new System.Windows.Forms.GroupBox();
            this.txtDepth = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.btnOrder = new System.Windows.Forms.Button();
            lblName = new System.Windows.Forms.Label();
            lblAddress = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.gbTiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTile)).BeginInit();
            this.gbBath.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = System.Drawing.Color.Transparent;
            lblName.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblName.Location = new System.Drawing.Point(19, 20);
            lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(95, 25);
            lblName.TabIndex = 1;
            lblName.Text = "Full Name:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BackColor = System.Drawing.Color.Transparent;
            lblAddress.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblAddress.Location = new System.Drawing.Point(19, 50);
            lblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new System.Drawing.Size(84, 25);
            lblAddress.TabIndex = 1;
            lblAddress.Text = "Address:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Papyrus", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(282, 249);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(235, 31);
            label1.TabIndex = 4;
            label1.Text = "Current Price per Tile:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(4, 28);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(171, 25);
            label2.TabIndex = 0;
            label2.Text = "Width:                        m";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(4, 65);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(175, 25);
            label3.TabIndex = 0;
            label3.Text = "Height:                       m";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(4, 102);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(175, 25);
            label4.TabIndex = 0;
            label4.Text = "Depth:                        m";
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackgroundImage = global::plochki.Properties.Resources.blue_to_green;
            this.btnGoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGoBack.Font = new System.Drawing.Font("Papyrus", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGoBack.Location = new System.Drawing.Point(485, 296);
            this.btnGoBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(111, 67);
            this.btnGoBack.TabIndex = 0;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.Location = new System.Drawing.Point(110, 19);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(94, 26);
            this.txtName.TabIndex = 2;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAddress.Location = new System.Drawing.Point(110, 48);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(94, 26);
            this.txtAddress.TabIndex = 2;
            // 
            // gbTiles
            // 
            this.gbTiles.BackColor = System.Drawing.Color.Transparent;
            this.gbTiles.Controls.Add(this.pbTile);
            this.gbTiles.Controls.Add(this.rbtnTile10);
            this.gbTiles.Controls.Add(this.rbtnTile7);
            this.gbTiles.Controls.Add(this.rbtnTile9);
            this.gbTiles.Controls.Add(this.rbtnTile8);
            this.gbTiles.Controls.Add(this.rbtnTile6);
            this.gbTiles.Controls.Add(this.rbtnTile5);
            this.gbTiles.Controls.Add(this.rbtnTile4);
            this.gbTiles.Controls.Add(this.rbtnTile3);
            this.gbTiles.Controls.Add(this.rbtnTile2);
            this.gbTiles.Controls.Add(this.rbtnTile1);
            this.gbTiles.Font = new System.Drawing.Font("Papyrus", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTiles.Location = new System.Drawing.Point(278, 10);
            this.gbTiles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbTiles.Name = "gbTiles";
            this.gbTiles.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbTiles.Size = new System.Drawing.Size(313, 232);
            this.gbTiles.TabIndex = 3;
            this.gbTiles.TabStop = false;
            this.gbTiles.Text = "Bathroom Tiles";
            // 
            // pbTile
            // 
            this.pbTile.Image = global::plochki.Properties.Resources._01;
            this.pbTile.Location = new System.Drawing.Point(134, 21);
            this.pbTile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbTile.Name = "pbTile";
            this.pbTile.Size = new System.Drawing.Size(121, 115);
            this.pbTile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTile.TabIndex = 6;
            this.pbTile.TabStop = false;
            // 
            // rbtnTile10
            // 
            this.rbtnTile10.AutoSize = true;
            this.rbtnTile10.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnTile10.Location = new System.Drawing.Point(146, 205);
            this.rbtnTile10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnTile10.Name = "rbtnTile10";
            this.rbtnTile10.Size = new System.Drawing.Size(140, 29);
            this.rbtnTile10.TabIndex = 5;
            this.rbtnTile10.Tag = "24.10";
            this.rbtnTile10.Text = "Sample No10";
            this.rbtnTile10.UseVisualStyleBackColor = true;
            this.rbtnTile10.CheckedChanged += new System.EventHandler(this.rbtnTile10_CheckedChanged);
            // 
            // rbtnTile7
            // 
            this.rbtnTile7.AutoSize = true;
            this.rbtnTile7.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnTile7.Location = new System.Drawing.Point(2, 205);
            this.rbtnTile7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnTile7.Name = "rbtnTile7";
            this.rbtnTile7.Size = new System.Drawing.Size(130, 29);
            this.rbtnTile7.TabIndex = 5;
            this.rbtnTile7.Tag = "29.60";
            this.rbtnTile7.Text = "Sample No7";
            this.rbtnTile7.UseVisualStyleBackColor = true;
            this.rbtnTile7.CheckedChanged += new System.EventHandler(this.rbtnTile7_CheckedChanged);
            // 
            // rbtnTile9
            // 
            this.rbtnTile9.AutoSize = true;
            this.rbtnTile9.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnTile9.Location = new System.Drawing.Point(146, 175);
            this.rbtnTile9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnTile9.Name = "rbtnTile9";
            this.rbtnTile9.Size = new System.Drawing.Size(130, 29);
            this.rbtnTile9.TabIndex = 4;
            this.rbtnTile9.Tag = "21.90";
            this.rbtnTile9.Text = "Sample No9";
            this.rbtnTile9.UseVisualStyleBackColor = true;
            this.rbtnTile9.CheckedChanged += new System.EventHandler(this.rbtnTile9_CheckedChanged);
            // 
            // rbtnTile8
            // 
            this.rbtnTile8.AutoSize = true;
            this.rbtnTile8.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnTile8.Location = new System.Drawing.Point(147, 145);
            this.rbtnTile8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnTile8.Name = "rbtnTile8";
            this.rbtnTile8.Size = new System.Drawing.Size(130, 29);
            this.rbtnTile8.TabIndex = 3;
            this.rbtnTile8.Tag = "28.40";
            this.rbtnTile8.Text = "Sample No8";
            this.rbtnTile8.UseVisualStyleBackColor = true;
            this.rbtnTile8.CheckedChanged += new System.EventHandler(this.rbtnTile8_CheckedChanged);
            // 
            // rbtnTile6
            // 
            this.rbtnTile6.AutoSize = true;
            this.rbtnTile6.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnTile6.Location = new System.Drawing.Point(2, 175);
            this.rbtnTile6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnTile6.Name = "rbtnTile6";
            this.rbtnTile6.Size = new System.Drawing.Size(130, 29);
            this.rbtnTile6.TabIndex = 4;
            this.rbtnTile6.Tag = "15.90";
            this.rbtnTile6.Text = "Sample No6";
            this.rbtnTile6.UseVisualStyleBackColor = true;
            this.rbtnTile6.CheckedChanged += new System.EventHandler(this.rbtnTile6_CheckedChanged);
            // 
            // rbtnTile5
            // 
            this.rbtnTile5.AutoSize = true;
            this.rbtnTile5.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnTile5.Location = new System.Drawing.Point(3, 145);
            this.rbtnTile5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnTile5.Name = "rbtnTile5";
            this.rbtnTile5.Size = new System.Drawing.Size(130, 29);
            this.rbtnTile5.TabIndex = 3;
            this.rbtnTile5.Tag = "27.20";
            this.rbtnTile5.Text = "Sample No5";
            this.rbtnTile5.UseVisualStyleBackColor = true;
            this.rbtnTile5.CheckedChanged += new System.EventHandler(this.rbtnTile5_CheckedChanged);
            // 
            // rbtnTile4
            // 
            this.rbtnTile4.AutoSize = true;
            this.rbtnTile4.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnTile4.Location = new System.Drawing.Point(3, 115);
            this.rbtnTile4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnTile4.Name = "rbtnTile4";
            this.rbtnTile4.Size = new System.Drawing.Size(130, 29);
            this.rbtnTile4.TabIndex = 2;
            this.rbtnTile4.Tag = "23.40";
            this.rbtnTile4.Text = "Sample No4";
            this.rbtnTile4.UseVisualStyleBackColor = true;
            this.rbtnTile4.CheckedChanged += new System.EventHandler(this.rbtnTile4_CheckedChanged);
            // 
            // rbtnTile3
            // 
            this.rbtnTile3.AutoSize = true;
            this.rbtnTile3.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnTile3.Location = new System.Drawing.Point(3, 84);
            this.rbtnTile3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnTile3.Name = "rbtnTile3";
            this.rbtnTile3.Size = new System.Drawing.Size(130, 29);
            this.rbtnTile3.TabIndex = 1;
            this.rbtnTile3.Tag = "17.50";
            this.rbtnTile3.Text = "Sample No3";
            this.rbtnTile3.UseVisualStyleBackColor = true;
            this.rbtnTile3.CheckedChanged += new System.EventHandler(this.rbtnTile3_CheckedChanged);
            // 
            // rbtnTile2
            // 
            this.rbtnTile2.AutoSize = true;
            this.rbtnTile2.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnTile2.Location = new System.Drawing.Point(3, 54);
            this.rbtnTile2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnTile2.Name = "rbtnTile2";
            this.rbtnTile2.Size = new System.Drawing.Size(130, 29);
            this.rbtnTile2.TabIndex = 0;
            this.rbtnTile2.Tag = "19.00";
            this.rbtnTile2.Text = "Sample No2";
            this.rbtnTile2.UseVisualStyleBackColor = true;
            this.rbtnTile2.CheckedChanged += new System.EventHandler(this.rbtnTile2_CheckedChanged);
            // 
            // rbtnTile1
            // 
            this.rbtnTile1.AutoSize = true;
            this.rbtnTile1.Checked = true;
            this.rbtnTile1.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnTile1.Location = new System.Drawing.Point(3, 24);
            this.rbtnTile1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnTile1.Name = "rbtnTile1";
            this.rbtnTile1.Size = new System.Drawing.Size(130, 29);
            this.rbtnTile1.TabIndex = 0;
            this.rbtnTile1.TabStop = true;
            this.rbtnTile1.Tag = "13.00";
            this.rbtnTile1.Text = "Sample No1";
            this.rbtnTile1.UseVisualStyleBackColor = true;
            this.rbtnTile1.CheckedChanged += new System.EventHandler(this.rbtnTile1_CheckedChanged);
            // 
            // lblTilePrice
            // 
            this.lblTilePrice.AutoSize = true;
            this.lblTilePrice.BackColor = System.Drawing.Color.Transparent;
            this.lblTilePrice.Font = new System.Drawing.Font("Papyrus", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTilePrice.Location = new System.Drawing.Point(504, 249);
            this.lblTilePrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTilePrice.Name = "lblTilePrice";
            this.lblTilePrice.Size = new System.Drawing.Size(67, 31);
            this.lblTilePrice.TabIndex = 4;
            this.lblTilePrice.Text = "0.00lv";
            // 
            // gbBath
            // 
            this.gbBath.BackColor = System.Drawing.Color.Transparent;
            this.gbBath.Controls.Add(this.txtDepth);
            this.gbBath.Controls.Add(label4);
            this.gbBath.Controls.Add(this.txtHeight);
            this.gbBath.Controls.Add(label3);
            this.gbBath.Controls.Add(this.txtWidth);
            this.gbBath.Controls.Add(label2);
            this.gbBath.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBath.Location = new System.Drawing.Point(26, 99);
            this.gbBath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbBath.Name = "gbBath";
            this.gbBath.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbBath.Size = new System.Drawing.Size(196, 144);
            this.gbBath.TabIndex = 5;
            this.gbBath.TabStop = false;
            this.gbBath.Text = "Room Parameters";
            // 
            // txtDepth
            // 
            this.txtDepth.Location = new System.Drawing.Point(70, 99);
            this.txtDepth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDepth.Name = "txtDepth";
            this.txtDepth.Size = new System.Drawing.Size(72, 33);
            this.txtDepth.TabIndex = 1;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(70, 63);
            this.txtHeight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(72, 33);
            this.txtHeight.TabIndex = 1;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(70, 26);
            this.txtWidth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(72, 33);
            this.txtWidth.TabIndex = 1;
            // 
            // btnOrder
            // 
            this.btnOrder.BackgroundImage = global::plochki.Properties.Resources.blue_to_green;
            this.btnOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOrder.Font = new System.Drawing.Font("Papyrus", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOrder.Location = new System.Drawing.Point(278, 296);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(202, 67);
            this.btnOrder.TabIndex = 0;
            this.btnOrder.Text = "Calculate and Order ";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::plochki.Properties.Resources.OrderBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.gbBath);
            this.Controls.Add(this.lblTilePrice);
            this.Controls.Add(label1);
            this.Controls.Add(this.gbTiles);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(lblAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(lblName);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnGoBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.gbTiles.ResumeLayout(false);
            this.gbTiles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTile)).EndInit();
            this.gbBath.ResumeLayout(false);
            this.gbBath.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.GroupBox gbTiles;
        private System.Windows.Forms.PictureBox pbTile;
        private System.Windows.Forms.RadioButton rbtnTile10;
        private System.Windows.Forms.RadioButton rbtnTile7;
        private System.Windows.Forms.RadioButton rbtnTile9;
        private System.Windows.Forms.RadioButton rbtnTile8;
        private System.Windows.Forms.RadioButton rbtnTile6;
        private System.Windows.Forms.RadioButton rbtnTile5;
        private System.Windows.Forms.RadioButton rbtnTile4;
        private System.Windows.Forms.RadioButton rbtnTile3;
        private System.Windows.Forms.RadioButton rbtnTile2;
        private System.Windows.Forms.RadioButton rbtnTile1;
        private System.Windows.Forms.Label lblTilePrice;
        private System.Windows.Forms.GroupBox gbBath;
        private System.Windows.Forms.TextBox txtDepth;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Button btnOrder;
    }
}