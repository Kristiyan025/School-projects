
namespace Cleaning_Company
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label lblCVV;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label12;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.dtTime = new System.Windows.Forms.DateTimePicker();
            this.cmbTown = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.gbCleaningKind = new System.Windows.Forms.GroupBox();
            this.gbDishes = new System.Windows.Forms.GroupBox();
            this.rbtnDishwasher = new System.Windows.Forms.RadioButton();
            this.rbtnSink = new System.Windows.Forms.RadioButton();
            this.nudDishes = new System.Windows.Forms.NumericUpDown();
            this.nudWindows = new System.Windows.Forms.NumericUpDown();
            this.lblDishesCount = new System.Windows.Forms.Label();
            this.lblWindowsCount = new System.Windows.Forms.Label();
            this.cbDishes = new System.Windows.Forms.CheckBox();
            this.cbWindows = new System.Windows.Forms.CheckBox();
            this.cbDust = new System.Windows.Forms.CheckBox();
            this.cbSteamCleaner = new System.Windows.Forms.CheckBox();
            this.cbVacuumCleaner = new System.Windows.Forms.CheckBox();
            this.cbMob = new System.Windows.Forms.CheckBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.nudArea = new System.Windows.Forms.NumericUpDown();
            this.nudRoomCount = new System.Windows.Forms.NumericUpDown();
            this.gbPayWay = new System.Windows.Forms.GroupBox();
            this.rbtnCash = new System.Windows.Forms.RadioButton();
            this.rbtnCreditCard = new System.Windows.Forms.RadioButton();
            this.gbCreditCard = new System.Windows.Forms.GroupBox();
            this.txtCardName = new System.Windows.Forms.TextBox();
            this.txtExpireDate = new System.Windows.Forms.TextBox();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.gbCardType = new System.Windows.Forms.GroupBox();
            this.rbtnBcard = new System.Windows.Forms.RadioButton();
            this.rbtnVPay = new System.Windows.Forms.RadioButton();
            this.rbtnMaestro = new System.Windows.Forms.RadioButton();
            this.rbtnVisa = new System.Windows.Forms.RadioButton();
            this.rbtnMastercard = new System.Windows.Forms.RadioButton();
            this.pbCard = new System.Windows.Forms.PictureBox();
            this.pbCVVHelp = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            lblCVV = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            this.gbCleaningKind.SuspendLayout();
            this.gbDishes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDishes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWindows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRoomCount)).BeginInit();
            this.gbPayWay.SuspendLayout();
            this.gbCreditCard.SuspendLayout();
            this.gbCardType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCVVHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.ControlText;
            label1.Location = new System.Drawing.Point(14, 115);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(101, 16);
            label1.TabIndex = 4;
            label1.Text = "Изберете час:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.SystemColors.ControlText;
            label2.Location = new System.Drawing.Point(14, 83);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(109, 16);
            label2.TabIndex = 4;
            label2.Text = "Изберете дата:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.SystemColors.ControlText;
            label3.Location = new System.Drawing.Point(14, 148);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(108, 16);
            label3.TabIndex = 4;
            label3.Text = "Изберете град:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.SystemColors.ControlText;
            label4.Location = new System.Drawing.Point(14, 178);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(117, 16);
            label4.TabIndex = 4;
            label4.Text = "Въведете адрес:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(14, 52);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(180, 16);
            label5.TabIndex = 4;
            label5.Text = "Въведете пълното си име:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label6.Location = new System.Drawing.Point(581, 442);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(185, 25);
            label6.TabIndex = 8;
            label6.Text = "Дължима Сума:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.Transparent;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.ForeColor = System.Drawing.SystemColors.ControlText;
            label7.Location = new System.Drawing.Point(14, 212);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(83, 16);
            label7.TabIndex = 1;
            label7.Text = "Площ (кв.м):";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.Color.Transparent;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label8.ForeColor = System.Drawing.SystemColors.ControlText;
            label8.Location = new System.Drawing.Point(168, 212);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(76, 16);
            label8.TabIndex = 1;
            label8.Text = "Брой стаи:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(6, 174);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(113, 16);
            label9.TabIndex = 1;
            label9.Text = "Номер на карта:";
            // 
            // lblCVV
            // 
            lblCVV.AutoSize = true;
            lblCVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            lblCVV.ForeColor = System.Drawing.Color.Red;
            lblCVV.Location = new System.Drawing.Point(6, 204);
            lblCVV.Name = "lblCVV";
            lblCVV.Size = new System.Drawing.Size(37, 16);
            lblCVV.TabIndex = 1;
            lblCVV.Text = "CVV:";
            lblCVV.MouseEnter += new System.EventHandler(this.lblCVV_MouseEnter);
            lblCVV.MouseLeave += new System.EventHandler(this.lblCVV_MouseLeave);
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(6, 234);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(134, 16);
            label11.TabIndex = 1;
            label11.Text = "Дата на валидност:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(6, 266);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(135, 16);
            label12.TabIndex = 1;
            label12.Text = "Име върху картата:";
            // 
            // btnOrder
            // 
            this.btnOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOrder.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOrder.Location = new System.Drawing.Point(581, 470);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(132, 40);
            this.btnOrder.TabIndex = 0;
            this.btnOrder.TabStop = false;
            this.btnOrder.Text = "Поръчай";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.brnPay_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Location = new System.Drawing.Point(716, 470);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(134, 40);
            this.btnBack.TabIndex = 1;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dtDate
            // 
            this.dtDate.CustomFormat = "ddd, dd. MMMM yyyyг.";
            this.dtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDate.Location = new System.Drawing.Point(149, 80);
            this.dtDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(258, 22);
            this.dtDate.TabIndex = 2;
            this.dtDate.Value = new System.DateTime(2020, 12, 30, 0, 0, 0, 0);
            // 
            // dtTime
            // 
            this.dtTime.CustomFormat = "HH:mm";
            this.dtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTime.Location = new System.Drawing.Point(148, 112);
            this.dtTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtTime.Name = "dtTime";
            this.dtTime.ShowUpDown = true;
            this.dtTime.Size = new System.Drawing.Size(63, 22);
            this.dtTime.TabIndex = 2;
            this.dtTime.Value = new System.DateTime(2020, 12, 29, 9, 36, 0, 798);
            // 
            // cmbTown
            // 
            this.cmbTown.FormattingEnabled = true;
            this.cmbTown.Items.AddRange(new object[] {
            "Бараково",
            "Бело поле",
            "Благоевград",
            "Бураново",
            "Бучино",
            "Дъбрава",
            "Железница",
            "Кочериново",
            "Крумово",
            "Перник",
            "Покровник",
            "Разлог",
            "Рила",
            "Рилци",
            "Селище",
            "Симитли",
            "Симитли",
            "София",
            "Стоб",
            "Церово",
            "Черниче"});
            this.cmbTown.Location = new System.Drawing.Point(148, 144);
            this.cmbTown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbTown.Name = "cmbTown";
            this.cmbTown.Size = new System.Drawing.Size(212, 23);
            this.cmbTown.TabIndex = 5;
            this.cmbTown.Text = "Благоевград";
            this.cmbTown.SelectedIndexChanged += new System.EventHandler(this.cmbTown_SelectedIndexChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.CausesValidation = false;
            this.txtAddress.Location = new System.Drawing.Point(148, 177);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PlaceholderText = "ул.„Васил Левски“ №11";
            this.txtAddress.Size = new System.Drawing.Size(212, 23);
            this.txtAddress.TabIndex = 6;
            // 
            // gbCleaningKind
            // 
            this.gbCleaningKind.BackColor = System.Drawing.Color.Transparent;
            this.gbCleaningKind.Controls.Add(this.gbDishes);
            this.gbCleaningKind.Controls.Add(this.nudDishes);
            this.gbCleaningKind.Controls.Add(this.nudWindows);
            this.gbCleaningKind.Controls.Add(this.lblDishesCount);
            this.gbCleaningKind.Controls.Add(this.lblWindowsCount);
            this.gbCleaningKind.Controls.Add(this.cbDishes);
            this.gbCleaningKind.Controls.Add(this.cbWindows);
            this.gbCleaningKind.Controls.Add(this.cbDust);
            this.gbCleaningKind.Controls.Add(this.cbSteamCleaner);
            this.gbCleaningKind.Controls.Add(this.cbVacuumCleaner);
            this.gbCleaningKind.Controls.Add(this.cbMob);
            this.gbCleaningKind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbCleaningKind.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbCleaningKind.Location = new System.Drawing.Point(18, 236);
            this.gbCleaningKind.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbCleaningKind.Name = "gbCleaningKind";
            this.gbCleaningKind.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbCleaningKind.Size = new System.Drawing.Size(413, 255);
            this.gbCleaningKind.TabIndex = 7;
            this.gbCleaningKind.TabStop = false;
            this.gbCleaningKind.Text = "Видове почистване";
            // 
            // gbDishes
            // 
            this.gbDishes.Controls.Add(this.rbtnDishwasher);
            this.gbDishes.Controls.Add(this.rbtnSink);
            this.gbDishes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbDishes.Location = new System.Drawing.Point(191, 180);
            this.gbDishes.Name = "gbDishes";
            this.gbDishes.Size = new System.Drawing.Size(217, 69);
            this.gbDishes.TabIndex = 3;
            this.gbDishes.TabStop = false;
            this.gbDishes.Text = "Осигурени:";
            this.gbDishes.Visible = false;
            // 
            // rbtnDishwasher
            // 
            this.rbtnDishwasher.AutoSize = true;
            this.rbtnDishwasher.Location = new System.Drawing.Point(6, 47);
            this.rbtnDishwasher.Name = "rbtnDishwasher";
            this.rbtnDishwasher.Size = new System.Drawing.Size(213, 20);
            this.rbtnDishwasher.TabIndex = 0;
            this.rbtnDishwasher.Tag = "0.50";
            this.rbtnDishwasher.Text = "Съдомиялна (0,50лв./съд)";
            this.rbtnDishwasher.UseVisualStyleBackColor = true;
            this.rbtnDishwasher.CheckedChanged += new System.EventHandler(this.rbtnDishwasher_CheckedChanged);
            // 
            // rbtnSink
            // 
            this.rbtnSink.AutoSize = true;
            this.rbtnSink.Location = new System.Drawing.Point(6, 21);
            this.rbtnSink.Name = "rbtnSink";
            this.rbtnSink.Size = new System.Drawing.Size(168, 20);
            this.rbtnSink.TabIndex = 0;
            this.rbtnSink.Tag = "1.00";
            this.rbtnSink.Text = "Мивка (1,00лв./съд)";
            this.rbtnSink.UseVisualStyleBackColor = true;
            this.rbtnSink.CheckedChanged += new System.EventHandler(this.rbtnSink_CheckedChanged);
            // 
            // nudDishes
            // 
            this.nudDishes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudDishes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nudDishes.Location = new System.Drawing.Point(133, 211);
            this.nudDishes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nudDishes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDishes.Name = "nudDishes";
            this.nudDishes.Size = new System.Drawing.Size(47, 22);
            this.nudDishes.TabIndex = 2;
            this.nudDishes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDishes.Visible = false;
            this.nudDishes.ValueChanged += new System.EventHandler(this.nudDishes_ValueChanged);
            // 
            // nudWindows
            // 
            this.nudWindows.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudWindows.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nudWindows.Location = new System.Drawing.Point(362, 152);
            this.nudWindows.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nudWindows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWindows.Name = "nudWindows";
            this.nudWindows.Size = new System.Drawing.Size(47, 22);
            this.nudWindows.TabIndex = 2;
            this.nudWindows.Tag = "3";
            this.nudWindows.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudWindows.Visible = false;
            this.nudWindows.ValueChanged += new System.EventHandler(this.nudWindows_ValueChanged);
            // 
            // lblDishesCount
            // 
            this.lblDishesCount.AutoSize = true;
            this.lblDishesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDishesCount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDishesCount.Location = new System.Drawing.Point(24, 212);
            this.lblDishesCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDishesCount.Name = "lblDishesCount";
            this.lblDishesCount.Size = new System.Drawing.Size(108, 17);
            this.lblDishesCount.TabIndex = 1;
            this.lblDishesCount.Text = "Брой съдове:";
            this.lblDishesCount.Visible = false;
            // 
            // lblWindowsCount
            // 
            this.lblWindowsCount.AutoSize = true;
            this.lblWindowsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWindowsCount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblWindowsCount.Location = new System.Drawing.Point(233, 155);
            this.lblWindowsCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWindowsCount.Name = "lblWindowsCount";
            this.lblWindowsCount.Size = new System.Drawing.Size(126, 17);
            this.lblWindowsCount.TabIndex = 1;
            this.lblWindowsCount.Text = "Брой прозорци:";
            this.lblWindowsCount.Visible = false;
            // 
            // cbDishes
            // 
            this.cbDishes.AutoSize = true;
            this.cbDishes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbDishes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbDishes.Location = new System.Drawing.Point(15, 180);
            this.cbDishes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbDishes.Name = "cbDishes";
            this.cbDishes.Size = new System.Drawing.Size(103, 21);
            this.cbDishes.TabIndex = 0;
            this.cbDishes.Text = "на съдове";
            this.cbDishes.UseVisualStyleBackColor = true;
            this.cbDishes.CheckedChanged += new System.EventHandler(this.cbDishes_CheckedChanged);
            // 
            // cbWindows
            // 
            this.cbWindows.AutoSize = true;
            this.cbWindows.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbWindows.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbWindows.Location = new System.Drawing.Point(15, 153);
            this.cbWindows.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbWindows.Name = "cbWindows";
            this.cbWindows.Size = new System.Drawing.Size(220, 21);
            this.cbWindows.TabIndex = 0;
            this.cbWindows.Tag = "3.00";
            this.cbWindows.Text = "на прозорци (3,00лв./бр.)";
            this.cbWindows.UseVisualStyleBackColor = true;
            this.cbWindows.CheckedChanged += new System.EventHandler(this.cbWindows_CheckedChanged);
            // 
            // cbDust
            // 
            this.cbDust.AutoSize = true;
            this.cbDust.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbDust.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbDust.Location = new System.Drawing.Point(15, 123);
            this.cbDust.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbDust.Name = "cbDust";
            this.cbDust.Size = new System.Drawing.Size(263, 21);
            this.cbDust.TabIndex = 0;
            this.cbDust.Tag = "0.40";
            this.cbDust.Text = "на прах (мебели) (0,40лв./кв.м)";
            this.cbDust.UseVisualStyleBackColor = true;
            this.cbDust.CheckedChanged += new System.EventHandler(this.cbDust_CheckedChanged);
            // 
            // cbSteamCleaner
            // 
            this.cbSteamCleaner.AutoSize = true;
            this.cbSteamCleaner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbSteamCleaner.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbSteamCleaner.Location = new System.Drawing.Point(15, 93);
            this.cbSteamCleaner.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbSteamCleaner.Name = "cbSteamCleaner";
            this.cbSteamCleaner.Size = new System.Drawing.Size(252, 21);
            this.cbSteamCleaner.TabIndex = 0;
            this.cbSteamCleaner.Tag = "0.60";
            this.cbSteamCleaner.Text = "с парочистачка (0,60лв./кв.м)";
            this.cbSteamCleaner.UseVisualStyleBackColor = true;
            this.cbSteamCleaner.CheckedChanged += new System.EventHandler(this.cbSteamCleaner_CheckedChanged);
            // 
            // cbVacuumCleaner
            // 
            this.cbVacuumCleaner.AutoSize = true;
            this.cbVacuumCleaner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbVacuumCleaner.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbVacuumCleaner.Location = new System.Drawing.Point(15, 63);
            this.cbVacuumCleaner.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbVacuumCleaner.Name = "cbVacuumCleaner";
            this.cbVacuumCleaner.Size = new System.Drawing.Size(259, 21);
            this.cbVacuumCleaner.TabIndex = 0;
            this.cbVacuumCleaner.Tag = "0.50";
            this.cbVacuumCleaner.Text = "с прахосмукачка (0,50лв./кв.м)";
            this.cbVacuumCleaner.UseVisualStyleBackColor = true;
            this.cbVacuumCleaner.CheckedChanged += new System.EventHandler(this.cbVacuumCleaner_CheckedChanged);
            // 
            // cbMob
            // 
            this.cbMob.AutoSize = true;
            this.cbMob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbMob.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbMob.Location = new System.Drawing.Point(15, 33);
            this.cbMob.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbMob.Name = "cbMob";
            this.cbMob.Size = new System.Drawing.Size(175, 21);
            this.cbMob.TabIndex = 0;
            this.cbMob.Tag = "0.80";
            this.cbMob.Text = "с моб (0,80лв./кв.м)";
            this.cbMob.UseVisualStyleBackColor = true;
            this.cbMob.CheckedChanged += new System.EventHandler(this.cbMob_CheckedChanged);
            // 
            // txtFullName
            // 
            this.txtFullName.CausesValidation = false;
            this.txtFullName.Location = new System.Drawing.Point(232, 50);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PlaceholderText = "Иван Кирилов Петров";
            this.txtFullName.Size = new System.Drawing.Size(176, 23);
            this.txtFullName.TabIndex = 6;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPrice.Location = new System.Drawing.Point(762, 442);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(90, 25);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "0,00лв.";
            // 
            // nudArea
            // 
            this.nudArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudArea.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nudArea.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudArea.Location = new System.Drawing.Point(101, 208);
            this.nudArea.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nudArea.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudArea.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudArea.Name = "nudArea";
            this.nudArea.Size = new System.Drawing.Size(54, 22);
            this.nudArea.TabIndex = 2;
            this.nudArea.Value = new decimal(new int[] {
            55,
            0,
            0,
            0});
            this.nudArea.ValueChanged += new System.EventHandler(this.nudArea_ValueChanged);
            // 
            // nudRoomCount
            // 
            this.nudRoomCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudRoomCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nudRoomCount.Location = new System.Drawing.Point(248, 208);
            this.nudRoomCount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nudRoomCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRoomCount.Name = "nudRoomCount";
            this.nudRoomCount.Size = new System.Drawing.Size(47, 22);
            this.nudRoomCount.TabIndex = 2;
            this.nudRoomCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudRoomCount.ValueChanged += new System.EventHandler(this.nudRoomCount_ValueChanged);
            // 
            // gbPayWay
            // 
            this.gbPayWay.BackColor = System.Drawing.Color.Transparent;
            this.gbPayWay.Controls.Add(this.rbtnCash);
            this.gbPayWay.Controls.Add(this.rbtnCreditCard);
            this.gbPayWay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbPayWay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbPayWay.Location = new System.Drawing.Point(438, 50);
            this.gbPayWay.Name = "gbPayWay";
            this.gbPayWay.Size = new System.Drawing.Size(409, 84);
            this.gbPayWay.TabIndex = 10;
            this.gbPayWay.TabStop = false;
            this.gbPayWay.Text = "Начин на плащане";
            // 
            // rbtnCash
            // 
            this.rbtnCash.AutoSize = true;
            this.rbtnCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnCash.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtnCash.Location = new System.Drawing.Point(6, 55);
            this.rbtnCash.Name = "rbtnCash";
            this.rbtnCash.Size = new System.Drawing.Size(129, 20);
            this.rbtnCash.TabIndex = 0;
            this.rbtnCash.Text = "В брой на място";
            this.rbtnCash.UseVisualStyleBackColor = true;
            this.rbtnCash.CheckedChanged += new System.EventHandler(this.rbtnCreditCard_CheckedChanged);
            // 
            // rbtnCreditCard
            // 
            this.rbtnCreditCard.AutoSize = true;
            this.rbtnCreditCard.Checked = true;
            this.rbtnCreditCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnCreditCard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtnCreditCard.Location = new System.Drawing.Point(6, 29);
            this.rbtnCreditCard.Name = "rbtnCreditCard";
            this.rbtnCreditCard.Size = new System.Drawing.Size(199, 20);
            this.rbtnCreditCard.TabIndex = 0;
            this.rbtnCreditCard.TabStop = true;
            this.rbtnCreditCard.Text = "С кредитна/дебитна карта";
            this.rbtnCreditCard.UseVisualStyleBackColor = true;
            this.rbtnCreditCard.CheckedChanged += new System.EventHandler(this.rbtnCreditCard_CheckedChanged);
            // 
            // gbCreditCard
            // 
            this.gbCreditCard.BackColor = System.Drawing.Color.Transparent;
            this.gbCreditCard.Controls.Add(this.txtCardName);
            this.gbCreditCard.Controls.Add(this.txtExpireDate);
            this.gbCreditCard.Controls.Add(this.txtCVV);
            this.gbCreditCard.Controls.Add(this.txtCardNumber);
            this.gbCreditCard.Controls.Add(label12);
            this.gbCreditCard.Controls.Add(label11);
            this.gbCreditCard.Controls.Add(lblCVV);
            this.gbCreditCard.Controls.Add(label9);
            this.gbCreditCard.Controls.Add(this.gbCardType);
            this.gbCreditCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbCreditCard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbCreditCard.Location = new System.Drawing.Point(438, 145);
            this.gbCreditCard.Name = "gbCreditCard";
            this.gbCreditCard.Size = new System.Drawing.Size(408, 293);
            this.gbCreditCard.TabIndex = 11;
            this.gbCreditCard.TabStop = false;
            this.gbCreditCard.Text = "Информация за кредитната/дебитната карта";
            // 
            // txtCardName
            // 
            this.txtCardName.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtCardName.Location = new System.Drawing.Point(148, 264);
            this.txtCardName.Name = "txtCardName";
            this.txtCardName.PlaceholderText = "Ivan Kirilov Petrov";
            this.txtCardName.Size = new System.Drawing.Size(163, 24);
            this.txtCardName.TabIndex = 4;
            // 
            // txtExpireDate
            // 
            this.txtExpireDate.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtExpireDate.Location = new System.Drawing.Point(146, 231);
            this.txtExpireDate.MaxLength = 5;
            this.txtExpireDate.Name = "txtExpireDate";
            this.txtExpireDate.PlaceholderText = "ММ/ГГ";
            this.txtExpireDate.Size = new System.Drawing.Size(50, 25);
            this.txtExpireDate.TabIndex = 3;
            this.txtExpireDate.Click += new System.EventHandler(this.txtExpireDate_Click);
            this.txtExpireDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtExpireDate_KeyDown);
            // 
            // txtCVV
            // 
            this.txtCVV.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCVV.Location = new System.Drawing.Point(124, 201);
            this.txtCVV.MaxLength = 3;
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.PlaceholderText = "000";
            this.txtCVV.Size = new System.Drawing.Size(36, 25);
            this.txtCVV.TabIndex = 3;
            this.txtCVV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtCardNumber.Location = new System.Drawing.Point(124, 171);
            this.txtCardNumber.MaxLength = 19;
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.PlaceholderText = "0000 0000 0000 0000";
            this.txtCardNumber.Size = new System.Drawing.Size(131, 24);
            this.txtCardNumber.TabIndex = 2;
            this.txtCardNumber.Click += new System.EventHandler(this.txtCardNumber_Click);
            this.txtCardNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCardNumber_KeyDown);
            // 
            // gbCardType
            // 
            this.gbCardType.BackColor = System.Drawing.Color.Transparent;
            this.gbCardType.Controls.Add(this.rbtnBcard);
            this.gbCardType.Controls.Add(this.rbtnVPay);
            this.gbCardType.Controls.Add(this.rbtnMaestro);
            this.gbCardType.Controls.Add(this.rbtnVisa);
            this.gbCardType.Controls.Add(this.rbtnMastercard);
            this.gbCardType.Controls.Add(this.pbCard);
            this.gbCardType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbCardType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbCardType.Location = new System.Drawing.Point(5, 18);
            this.gbCardType.Name = "gbCardType";
            this.gbCardType.Size = new System.Drawing.Size(399, 147);
            this.gbCardType.TabIndex = 0;
            this.gbCardType.TabStop = false;
            this.gbCardType.Text = "Вид на картата";
            // 
            // rbtnBcard
            // 
            this.rbtnBcard.AutoSize = true;
            this.rbtnBcard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnBcard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtnBcard.Location = new System.Drawing.Point(3, 122);
            this.rbtnBcard.Name = "rbtnBcard";
            this.rbtnBcard.Size = new System.Drawing.Size(61, 20);
            this.rbtnBcard.TabIndex = 2;
            this.rbtnBcard.TabStop = true;
            this.rbtnBcard.Tag = "4";
            this.rbtnBcard.Text = "Bcard";
            this.rbtnBcard.UseVisualStyleBackColor = true;
            this.rbtnBcard.CheckedChanged += new System.EventHandler(this.rbtnCardType_CheckedChanged);
            // 
            // rbtnVPay
            // 
            this.rbtnVPay.AutoSize = true;
            this.rbtnVPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnVPay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtnVPay.Location = new System.Drawing.Point(3, 96);
            this.rbtnVPay.Name = "rbtnVPay";
            this.rbtnVPay.Size = new System.Drawing.Size(61, 20);
            this.rbtnVPay.TabIndex = 2;
            this.rbtnVPay.TabStop = true;
            this.rbtnVPay.Tag = "3";
            this.rbtnVPay.Text = "V Pay";
            this.rbtnVPay.UseVisualStyleBackColor = true;
            this.rbtnVPay.CheckedChanged += new System.EventHandler(this.rbtnCardType_CheckedChanged);
            // 
            // rbtnMaestro
            // 
            this.rbtnMaestro.AutoSize = true;
            this.rbtnMaestro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnMaestro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtnMaestro.Location = new System.Drawing.Point(3, 70);
            this.rbtnMaestro.Name = "rbtnMaestro";
            this.rbtnMaestro.Size = new System.Drawing.Size(74, 20);
            this.rbtnMaestro.TabIndex = 2;
            this.rbtnMaestro.TabStop = true;
            this.rbtnMaestro.Tag = "2";
            this.rbtnMaestro.Text = "Maestro";
            this.rbtnMaestro.UseVisualStyleBackColor = true;
            this.rbtnMaestro.CheckedChanged += new System.EventHandler(this.rbtnCardType_CheckedChanged);
            // 
            // rbtnVisa
            // 
            this.rbtnVisa.AutoSize = true;
            this.rbtnVisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnVisa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtnVisa.Location = new System.Drawing.Point(3, 44);
            this.rbtnVisa.Name = "rbtnVisa";
            this.rbtnVisa.Size = new System.Drawing.Size(52, 20);
            this.rbtnVisa.TabIndex = 2;
            this.rbtnVisa.TabStop = true;
            this.rbtnVisa.Tag = "1";
            this.rbtnVisa.Text = "Visa";
            this.rbtnVisa.UseVisualStyleBackColor = true;
            this.rbtnVisa.CheckedChanged += new System.EventHandler(this.rbtnCardType_CheckedChanged);
            // 
            // rbtnMastercard
            // 
            this.rbtnMastercard.AutoSize = true;
            this.rbtnMastercard.Checked = true;
            this.rbtnMastercard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnMastercard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtnMastercard.Location = new System.Drawing.Point(3, 18);
            this.rbtnMastercard.Name = "rbtnMastercard";
            this.rbtnMastercard.Size = new System.Drawing.Size(93, 20);
            this.rbtnMastercard.TabIndex = 1;
            this.rbtnMastercard.TabStop = true;
            this.rbtnMastercard.Tag = "0";
            this.rbtnMastercard.Text = "Mastercard";
            this.rbtnMastercard.UseVisualStyleBackColor = true;
            this.rbtnMastercard.CheckedChanged += new System.EventHandler(this.rbtnCardType_CheckedChanged);
            // 
            // pbCard
            // 
            this.pbCard.Location = new System.Drawing.Point(180, 14);
            this.pbCard.Name = "pbCard";
            this.pbCard.Size = new System.Drawing.Size(213, 127);
            this.pbCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCard.TabIndex = 0;
            this.pbCard.TabStop = false;
            // 
            // pbCVVHelp
            // 
            this.pbCVVHelp.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbCVVHelp.Location = new System.Drawing.Point(486, 316);
            this.pbCVVHelp.Name = "pbCVVHelp";
            this.pbCVVHelp.Size = new System.Drawing.Size(21, 24);
            this.pbCVVHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCVVHelp.TabIndex = 12;
            this.pbCVVHelp.TabStop = false;
            this.pbCVVHelp.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 516);
            this.Controls.Add(this.pbCVVHelp);
            this.Controls.Add(this.gbCreditCard);
            this.Controls.Add(this.gbPayWay);
            this.Controls.Add(this.nudRoomCount);
            this.Controls.Add(this.nudArea);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(label8);
            this.Controls.Add(label7);
            this.Controls.Add(label6);
            this.Controls.Add(this.gbCleaningKind);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.cmbTown);
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(label1);
            this.Controls.Add(label2);
            this.Controls.Add(this.dtTime);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.gbCleaningKind.ResumeLayout(false);
            this.gbCleaningKind.PerformLayout();
            this.gbDishes.ResumeLayout(false);
            this.gbDishes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDishes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWindows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRoomCount)).EndInit();
            this.gbPayWay.ResumeLayout(false);
            this.gbPayWay.PerformLayout();
            this.gbCreditCard.ResumeLayout(false);
            this.gbCreditCard.PerformLayout();
            this.gbCardType.ResumeLayout(false);
            this.gbCardType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCVVHelp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.DateTimePicker dtTime;
        private System.Windows.Forms.ComboBox cmbTown;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.GroupBox gbCleaningKind;
        private System.Windows.Forms.NumericUpDown nudWindows;
        private System.Windows.Forms.Label lblWindowsCount;
        private System.Windows.Forms.CheckBox cbWindows;
        private System.Windows.Forms.CheckBox cbDust;
        private System.Windows.Forms.CheckBox cbSteamCleaner;
        private System.Windows.Forms.CheckBox cbVacuumCleaner;
        private System.Windows.Forms.CheckBox cbMob;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudArea;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudRoomCount;
        private System.Windows.Forms.CheckBox cbDishes;
        private System.Windows.Forms.GroupBox gbDishes;
        private System.Windows.Forms.RadioButton rbtnDishwasher;
        private System.Windows.Forms.RadioButton rbtnSink;
        private System.Windows.Forms.NumericUpDown nudDishes;
        private System.Windows.Forms.Label lblDishesCount;
        private System.Windows.Forms.GroupBox gbPayWay;
        private System.Windows.Forms.RadioButton rbtnCash;
        private System.Windows.Forms.RadioButton rbtnCreditCard;
        private System.Windows.Forms.GroupBox gbCreditCard;
        private System.Windows.Forms.GroupBox gbCardType;
        private System.Windows.Forms.RadioButton rbtnBcard;
        private System.Windows.Forms.RadioButton rbtnVPay;
        private System.Windows.Forms.RadioButton rbtnMaestro;
        private System.Windows.Forms.RadioButton rbtnVisa;
        private System.Windows.Forms.RadioButton rbtnMastercard;
        private System.Windows.Forms.PictureBox pbCard;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.TextBox txtExpireDate;
        private System.Windows.Forms.TextBox txtCardName;
        private System.Windows.Forms.PictureBox pbCVVHelp;
    }
}

