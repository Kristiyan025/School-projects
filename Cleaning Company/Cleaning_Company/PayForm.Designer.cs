namespace Cleaning_Company
{
    using Labels;

    partial class PayForm
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
            Cleaning_Company.Labels.BorderLabel lblQuestion;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayForm));
            this.lblInfo = new Cleaning_Company.Labels.BorderLabel();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            lblQuestion = new Cleaning_Company.Labels.BorderLabel();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            lblQuestion.BackColor = System.Drawing.Color.Transparent;
            lblQuestion.BorderColor = System.Drawing.Color.Black;
            lblQuestion.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            lblQuestion.ForeColor = System.Drawing.Color.Chartreuse;
            lblQuestion.Location = new System.Drawing.Point(13, 75);
            lblQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblQuestion.Size = new System.Drawing.Size(270, 99);
            lblQuestion.TabIndex = 0;
            lblQuestion.Text = "Потвърждавате ли\r\n      плащането?";
            lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.BorderColor = System.Drawing.Color.Black;
            this.lblInfo.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblInfo.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblInfo.Location = new System.Drawing.Point(2, 9);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblInfo.Size = new System.Drawing.Size(292, 52);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Вие дължите: ";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPay
            // 
            this.btnPay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPay.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnPay.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnPay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPay.Location = new System.Drawing.Point(13, 190);
            this.btnPay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(270, 42);
            this.btnPay.TabIndex = 1;
            this.btnPay.TabStop = false;
            this.btnPay.Text = "Потвърждаване";
            this.btnPay.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Location = new System.Drawing.Point(13, 238);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(270, 40);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "Отказ";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // PayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(296, 290);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(lblQuestion);
            this.Controls.Add(this.lblInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "PayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PayForm";
            this.Load += new System.EventHandler(this.PayForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private BorderLabel lblInfo;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnCancel;
    }
}