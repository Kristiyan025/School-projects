namespace phone_timer
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
            this.lblS = new System.Windows.Forms.Label();
            this.lblSt = new System.Windows.Forms.Label();
            this.lblM = new System.Windows.Forms.Label();
            this.btnNull = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblS
            // 
            this.lblS.Font = new System.Drawing.Font("Sitka Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblS.Location = new System.Drawing.Point(61, 9);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(42, 32);
            this.lblS.TabIndex = 0;
            this.lblS.Text = "00";
            // 
            // lblSt
            // 
            this.lblSt.Font = new System.Drawing.Font("Sitka Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSt.Location = new System.Drawing.Point(102, 9);
            this.lblSt.Name = "lblSt";
            this.lblSt.Size = new System.Drawing.Size(42, 32);
            this.lblSt.TabIndex = 0;
            this.lblSt.Text = "00";
            // 
            // lblM
            // 
            this.lblM.Font = new System.Drawing.Font("Sitka Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblM.Location = new System.Drawing.Point(20, 9);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(42, 32);
            this.lblM.TabIndex = 0;
            this.lblM.Text = "00";
            // 
            // btnNull
            // 
            this.btnNull.Enabled = false;
            this.btnNull.Location = new System.Drawing.Point(83, 64);
            this.btnNull.Name = "btnNull";
            this.btnNull.Size = new System.Drawing.Size(69, 27);
            this.btnNull.TabIndex = 1;
            this.btnNull.Text = "Reset";
            this.btnNull.UseVisualStyleBackColor = true;
            this.btnNull.Click += new System.EventHandler(this.btnNull_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(9, 64);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(69, 27);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(9, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(9, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = ":";
            // 
            // timer1
            // 
            this.timer1.Interval = 6;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(161, 103);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnNull);
            this.Controls.Add(this.lblM);
            this.Controls.Add(this.lblSt);
            this.Controls.Add(this.lblS);
            this.Name = "Form1";
            this.Text = "Timer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.Label lblSt;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.Button btnNull;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}

