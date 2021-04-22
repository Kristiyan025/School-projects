
namespace SIgn
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreateRandomReal = new System.Windows.Forms.Button();
            this.btnSplit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.rtxtResult = new System.Windows.Forms.RichTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(76, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(162, 20);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "File name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = ".txt";
            // 
            // btnCreateRandomReal
            // 
            this.btnCreateRandomReal.Location = new System.Drawing.Point(299, 21);
            this.btnCreateRandomReal.Name = "btnCreateRandomReal";
            this.btnCreateRandomReal.Size = new System.Drawing.Size(125, 46);
            this.btnCreateRandomReal.TabIndex = 3;
            this.btnCreateRandomReal.Text = "Create Random Real";
            this.btnCreateRandomReal.UseVisualStyleBackColor = true;
            this.btnCreateRandomReal.Click += new System.EventHandler(this.btnCreateRandomReal_Click);
            // 
            // btnSplit
            // 
            this.btnSplit.Location = new System.Drawing.Point(444, 21);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(123, 46);
            this.btnSplit.TabIndex = 4;
            this.btnSplit.Text = "Split";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(592, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtxtResult
            // 
            this.rtxtResult.Location = new System.Drawing.Point(20, 73);
            this.rtxtResult.Name = "rtxtResult";
            this.rtxtResult.Size = new System.Drawing.Size(857, 380);
            this.rtxtResult.TabIndex = 7;
            this.rtxtResult.Text = "";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(750, 19);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(144, 47);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 476);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.rtxtResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.btnCreateRandomReal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreateRandomReal;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rtxtResult;
        private System.Windows.Forms.Button btnClear;
    }
}

