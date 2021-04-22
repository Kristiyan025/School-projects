
namespace Digits
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.rtxtResult = new System.Windows.Forms.RichTextBox();
            this.btnRevirse = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = ".txt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "File name: ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(86, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(162, 20);
            this.txtName.TabIndex = 3;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(282, 12);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(115, 50);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // rtxtResult
            // 
            this.rtxtResult.Location = new System.Drawing.Point(30, 68);
            this.rtxtResult.Name = "rtxtResult";
            this.rtxtResult.Size = new System.Drawing.Size(758, 370);
            this.rtxtResult.TabIndex = 7;
            this.rtxtResult.Text = "";
            // 
            // btnRevirse
            // 
            this.btnRevirse.Location = new System.Drawing.Point(407, 13);
            this.btnRevirse.Name = "btnRevirse";
            this.btnRevirse.Size = new System.Drawing.Size(125, 48);
            this.btnRevirse.TabIndex = 8;
            this.btnRevirse.Text = "Reverse";
            this.btnRevirse.UseVisualStyleBackColor = true;
            this.btnRevirse.Click += new System.EventHandler(this.btnRevirse_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(538, 13);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(123, 45);
            this.btnShow.TabIndex = 9;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(672, 16);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(115, 44);
            this.btnSum.TabIndex = 10;
            this.btnSum.Text = "Special sum";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnRevirse);
            this.Controls.Add(this.rtxtResult);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.RichTextBox rtxtResult;
        private System.Windows.Forms.Button btnRevirse;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnSum;
    }
}

