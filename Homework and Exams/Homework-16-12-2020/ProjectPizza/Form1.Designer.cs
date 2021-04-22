namespace ProjectPizza
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
            this.gbKind = new System.Windows.Forms.GroupBox();
            this.pbPizza = new System.Windows.Forms.PictureBox();
            this.rdnVegetariana = new System.Windows.Forms.RadioButton();
            this.rdnCaprichosa = new System.Windows.Forms.RadioButton();
            this.rdnPalermo = new System.Windows.Forms.RadioButton();
            this.rdnCuatro = new System.Windows.Forms.RadioButton();
            this.rdnMargarita = new System.Windows.Forms.RadioButton();
            this.lblInfo = new System.Windows.Forms.Label();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rdnBig = new System.Windows.Forms.RadioButton();
            this.rdnSmall = new System.Windows.Forms.RadioButton();
            this.gbSideDish = new System.Windows.Forms.GroupBox();
            this.cbClam = new System.Windows.Forms.CheckBox();
            this.cbPeppers = new System.Windows.Forms.CheckBox();
            this.cbCheese = new System.Windows.Forms.CheckBox();
            this.cbEgg = new System.Windows.Forms.CheckBox();
            this.cbVegetables = new System.Windows.Forms.CheckBox();
            this.gbSauces = new System.Windows.Forms.GroupBox();
            this.cbGarlic = new System.Windows.Forms.CheckBox();
            this.cbTomato = new System.Windows.Forms.CheckBox();
            this.cbSpicy = new System.Windows.Forms.CheckBox();
            this.cbKetchup = new System.Windows.Forms.CheckBox();
            this.cbSicilial = new System.Windows.Forms.CheckBox();
            this.cbBianko = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbKind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPizza)).BeginInit();
            this.gbSize.SuspendLayout();
            this.gbSideDish.SuspendLayout();
            this.gbSauces.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbKind
            // 
            this.gbKind.Controls.Add(this.pbPizza);
            this.gbKind.Controls.Add(this.rdnVegetariana);
            this.gbKind.Controls.Add(this.rdnCaprichosa);
            this.gbKind.Controls.Add(this.rdnPalermo);
            this.gbKind.Controls.Add(this.rdnCuatro);
            this.gbKind.Controls.Add(this.rdnMargarita);
            this.gbKind.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbKind.ForeColor = System.Drawing.Color.Maroon;
            this.gbKind.Location = new System.Drawing.Point(17, 12);
            this.gbKind.Name = "gbKind";
            this.gbKind.Size = new System.Drawing.Size(437, 240);
            this.gbKind.TabIndex = 0;
            this.gbKind.TabStop = false;
            this.gbKind.Text = "Вид Пица";
            // 
            // pbPizza
            // 
            this.pbPizza.Location = new System.Drawing.Point(159, 19);
            this.pbPizza.Name = "pbPizza";
            this.pbPizza.Size = new System.Drawing.Size(267, 210);
            this.pbPizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPizza.TabIndex = 1;
            this.pbPizza.TabStop = false;
            // 
            // rdnVegetariana
            // 
            this.rdnVegetariana.AutoSize = true;
            this.rdnVegetariana.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdnVegetariana.ForeColor = System.Drawing.Color.Black;
            this.rdnVegetariana.Location = new System.Drawing.Point(17, 156);
            this.rdnVegetariana.Name = "rdnVegetariana";
            this.rdnVegetariana.Size = new System.Drawing.Size(93, 19);
            this.rdnVegetariana.TabIndex = 0;
            this.rdnVegetariana.Tag = "4";
            this.rdnVegetariana.Text = "Вегетариана";
            this.rdnVegetariana.UseVisualStyleBackColor = true;
            this.rdnVegetariana.CheckedChanged += new System.EventHandler(this.rdnKind_CheckedChanged);
            // 
            // rdnCaprichosa
            // 
            this.rdnCaprichosa.AutoSize = true;
            this.rdnCaprichosa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdnCaprichosa.ForeColor = System.Drawing.Color.Black;
            this.rdnCaprichosa.Location = new System.Drawing.Point(17, 126);
            this.rdnCaprichosa.Name = "rdnCaprichosa";
            this.rdnCaprichosa.Size = new System.Drawing.Size(84, 19);
            this.rdnCaprichosa.TabIndex = 0;
            this.rdnCaprichosa.Tag = "3";
            this.rdnCaprichosa.Text = "Капричоза";
            this.rdnCaprichosa.UseVisualStyleBackColor = true;
            this.rdnCaprichosa.CheckedChanged += new System.EventHandler(this.rdnKind_CheckedChanged);
            // 
            // rdnPalermo
            // 
            this.rdnPalermo.AutoSize = true;
            this.rdnPalermo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdnPalermo.ForeColor = System.Drawing.Color.Black;
            this.rdnPalermo.Location = new System.Drawing.Point(17, 96);
            this.rdnPalermo.Name = "rdnPalermo";
            this.rdnPalermo.Size = new System.Drawing.Size(76, 19);
            this.rdnPalermo.TabIndex = 0;
            this.rdnPalermo.Tag = "2";
            this.rdnPalermo.Text = "Палермо";
            this.rdnPalermo.UseVisualStyleBackColor = true;
            this.rdnPalermo.CheckedChanged += new System.EventHandler(this.rdnKind_CheckedChanged);
            // 
            // rdnCuatro
            // 
            this.rdnCuatro.AutoSize = true;
            this.rdnCuatro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdnCuatro.ForeColor = System.Drawing.Color.Black;
            this.rdnCuatro.Location = new System.Drawing.Point(17, 66);
            this.rdnCuatro.Name = "rdnCuatro";
            this.rdnCuatro.Size = new System.Drawing.Size(121, 19);
            this.rdnCuatro.TabIndex = 0;
            this.rdnCuatro.Tag = "1";
            this.rdnCuatro.Text = "Куатро Стаджони";
            this.rdnCuatro.UseVisualStyleBackColor = true;
            this.rdnCuatro.CheckedChanged += new System.EventHandler(this.rdnKind_CheckedChanged);
            // 
            // rdnMargarita
            // 
            this.rdnMargarita.AutoSize = true;
            this.rdnMargarita.Checked = true;
            this.rdnMargarita.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdnMargarita.ForeColor = System.Drawing.Color.Black;
            this.rdnMargarita.Location = new System.Drawing.Point(17, 36);
            this.rdnMargarita.Name = "rdnMargarita";
            this.rdnMargarita.Size = new System.Drawing.Size(85, 19);
            this.rdnMargarita.TabIndex = 0;
            this.rdnMargarita.TabStop = true;
            this.rdnMargarita.Tag = "0";
            this.rdnMargarita.Text = "Маргарита";
            this.rdnMargarita.UseVisualStyleBackColor = true;
            this.rdnMargarita.CheckedChanged += new System.EventHandler(this.rdnKind_CheckedChanged);
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInfo.ForeColor = System.Drawing.Color.Maroon;
            this.lblInfo.Location = new System.Drawing.Point(17, 261);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(437, 162);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rdnBig);
            this.gbSize.Controls.Add(this.rdnSmall);
            this.gbSize.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbSize.ForeColor = System.Drawing.Color.Maroon;
            this.gbSize.Location = new System.Drawing.Point(463, 12);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(258, 67);
            this.gbSize.TabIndex = 0;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Размер";
            // 
            // rdnBig
            // 
            this.rdnBig.AutoSize = true;
            this.rdnBig.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdnBig.ForeColor = System.Drawing.Color.Black;
            this.rdnBig.Location = new System.Drawing.Point(153, 36);
            this.rdnBig.Name = "rdnBig";
            this.rdnBig.Size = new System.Drawing.Size(66, 19);
            this.rdnBig.TabIndex = 0;
            this.rdnBig.Text = "Голяма";
            this.rdnBig.UseVisualStyleBackColor = true;
            // 
            // rdnSmall
            // 
            this.rdnSmall.AutoSize = true;
            this.rdnSmall.Checked = true;
            this.rdnSmall.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdnSmall.ForeColor = System.Drawing.Color.Black;
            this.rdnSmall.Location = new System.Drawing.Point(17, 36);
            this.rdnSmall.Name = "rdnSmall";
            this.rdnSmall.Size = new System.Drawing.Size(61, 19);
            this.rdnSmall.TabIndex = 0;
            this.rdnSmall.TabStop = true;
            this.rdnSmall.Text = "Малка";
            this.rdnSmall.UseVisualStyleBackColor = true;
            this.rdnSmall.CheckedChanged += new System.EventHandler(this.rdnBig_CheckedChanged);
            // 
            // gbSideDish
            // 
            this.gbSideDish.Controls.Add(this.cbClam);
            this.gbSideDish.Controls.Add(this.cbPeppers);
            this.gbSideDish.Controls.Add(this.cbCheese);
            this.gbSideDish.Controls.Add(this.cbEgg);
            this.gbSideDish.Controls.Add(this.cbVegetables);
            this.gbSideDish.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbSideDish.ForeColor = System.Drawing.Color.Maroon;
            this.gbSideDish.Location = new System.Drawing.Point(463, 85);
            this.gbSideDish.Name = "gbSideDish";
            this.gbSideDish.Size = new System.Drawing.Size(258, 183);
            this.gbSideDish.TabIndex = 0;
            this.gbSideDish.TabStop = false;
            this.gbSideDish.Text = "Гарнитура";
            // 
            // cbClam
            // 
            this.cbClam.AutoSize = true;
            this.cbClam.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbClam.ForeColor = System.Drawing.Color.Black;
            this.cbClam.Location = new System.Drawing.Point(21, 60);
            this.cbClam.Name = "cbClam";
            this.cbClam.Size = new System.Drawing.Size(163, 21);
            this.cbClam.TabIndex = 0;
            this.cbClam.Tag = "2,09";
            this.cbClam.Text = "Миди - 2,09 лв. (50гр.)";
            this.cbClam.UseVisualStyleBackColor = true;
            this.cbClam.CheckedChanged += new System.EventHandler(this.cbVegetables_CheckedChanged);
            // 
            // cbPeppers
            // 
            this.cbPeppers.AutoSize = true;
            this.cbPeppers.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbPeppers.ForeColor = System.Drawing.Color.Black;
            this.cbPeppers.Location = new System.Drawing.Point(21, 141);
            this.cbPeppers.Name = "cbPeppers";
            this.cbPeppers.Size = new System.Drawing.Size(206, 21);
            this.cbPeppers.TabIndex = 0;
            this.cbPeppers.Tag = "0,70";
            this.cbPeppers.Text = "Люти чушки - 0,70 лв. (50гр.)";
            this.cbPeppers.UseVisualStyleBackColor = true;
            this.cbPeppers.CheckedChanged += new System.EventHandler(this.cbVegetables_CheckedChanged);
            // 
            // cbCheese
            // 
            this.cbCheese.AutoSize = true;
            this.cbCheese.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbCheese.ForeColor = System.Drawing.Color.Black;
            this.cbCheese.Location = new System.Drawing.Point(21, 114);
            this.cbCheese.Name = "cbCheese";
            this.cbCheese.Size = new System.Drawing.Size(223, 21);
            this.cbCheese.TabIndex = 0;
            this.cbCheese.Tag = "1,89";
            this.cbCheese.Text = "Сирене рокфор - 1,89 лв. (50гр.)";
            this.cbCheese.UseVisualStyleBackColor = true;
            this.cbCheese.CheckedChanged += new System.EventHandler(this.cbVegetables_CheckedChanged);
            // 
            // cbEgg
            // 
            this.cbEgg.AutoSize = true;
            this.cbEgg.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbEgg.ForeColor = System.Drawing.Color.Black;
            this.cbEgg.Location = new System.Drawing.Point(21, 87);
            this.cbEgg.Name = "cbEgg";
            this.cbEgg.Size = new System.Drawing.Size(158, 21);
            this.cbEgg.TabIndex = 0;
            this.cbEgg.Tag = "0,69";
            this.cbEgg.Text = "Яйце - 0,69 лв. (50гр.)";
            this.cbEgg.UseVisualStyleBackColor = true;
            this.cbEgg.CheckedChanged += new System.EventHandler(this.cbVegetables_CheckedChanged);
            // 
            // cbVegetables
            // 
            this.cbVegetables.AutoSize = true;
            this.cbVegetables.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbVegetables.ForeColor = System.Drawing.Color.Black;
            this.cbVegetables.Location = new System.Drawing.Point(21, 33);
            this.cbVegetables.Name = "cbVegetables";
            this.cbVegetables.Size = new System.Drawing.Size(194, 21);
            this.cbVegetables.TabIndex = 0;
            this.cbVegetables.Tag = "0,89";
            this.cbVegetables.Text = "Зеленчуци - 0,89 лв. (50гр.)";
            this.cbVegetables.UseVisualStyleBackColor = true;
            this.cbVegetables.CheckedChanged += new System.EventHandler(this.cbVegetables_CheckedChanged);
            // 
            // gbSauces
            // 
            this.gbSauces.Controls.Add(this.cbGarlic);
            this.gbSauces.Controls.Add(this.cbTomato);
            this.gbSauces.Controls.Add(this.cbSpicy);
            this.gbSauces.Controls.Add(this.cbKetchup);
            this.gbSauces.Controls.Add(this.cbSicilial);
            this.gbSauces.Controls.Add(this.cbBianko);
            this.gbSauces.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbSauces.ForeColor = System.Drawing.Color.Maroon;
            this.gbSauces.Location = new System.Drawing.Point(727, 12);
            this.gbSauces.Name = "gbSauces";
            this.gbSauces.Size = new System.Drawing.Size(199, 208);
            this.gbSauces.TabIndex = 0;
            this.gbSauces.TabStop = false;
            this.gbSauces.Text = "Сосове - 0,99 лв. (50гр.)";
            // 
            // cbGarlic
            // 
            this.cbGarlic.AutoSize = true;
            this.cbGarlic.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbGarlic.ForeColor = System.Drawing.Color.Black;
            this.cbGarlic.Location = new System.Drawing.Point(21, 60);
            this.cbGarlic.Name = "cbGarlic";
            this.cbGarlic.Size = new System.Drawing.Size(130, 21);
            this.cbGarlic.TabIndex = 0;
            this.cbGarlic.Tag = "0,99";
            this.cbGarlic.Text = "Бианко - чеснов";
            this.cbGarlic.UseVisualStyleBackColor = true;
            this.cbGarlic.CheckedChanged += new System.EventHandler(this.cbVegetables_CheckedChanged);
            // 
            // cbTomato
            // 
            this.cbTomato.AutoSize = true;
            this.cbTomato.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbTomato.ForeColor = System.Drawing.Color.Black;
            this.cbTomato.Location = new System.Drawing.Point(21, 168);
            this.cbTomato.Name = "cbTomato";
            this.cbTomato.Size = new System.Drawing.Size(82, 21);
            this.cbTomato.TabIndex = 0;
            this.cbTomato.Tag = "0,99";
            this.cbTomato.Text = "Доматен";
            this.cbTomato.UseVisualStyleBackColor = true;
            this.cbTomato.CheckedChanged += new System.EventHandler(this.cbVegetables_CheckedChanged);
            // 
            // cbSpicy
            // 
            this.cbSpicy.AutoSize = true;
            this.cbSpicy.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbSpicy.ForeColor = System.Drawing.Color.Black;
            this.cbSpicy.Location = new System.Drawing.Point(21, 141);
            this.cbSpicy.Name = "cbSpicy";
            this.cbSpicy.Size = new System.Drawing.Size(88, 21);
            this.cbSpicy.TabIndex = 0;
            this.cbSpicy.Tag = "0,99";
            this.cbSpicy.Text = "Пикантен";
            this.cbSpicy.UseVisualStyleBackColor = true;
            this.cbSpicy.CheckedChanged += new System.EventHandler(this.cbVegetables_CheckedChanged);
            // 
            // cbKetchup
            // 
            this.cbKetchup.AutoSize = true;
            this.cbKetchup.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbKetchup.ForeColor = System.Drawing.Color.Black;
            this.cbKetchup.Location = new System.Drawing.Point(21, 114);
            this.cbKetchup.Name = "cbKetchup";
            this.cbKetchup.Size = new System.Drawing.Size(71, 21);
            this.cbKetchup.TabIndex = 0;
            this.cbKetchup.Tag = "0,99";
            this.cbKetchup.Text = "Кетчуп";
            this.cbKetchup.UseVisualStyleBackColor = true;
            this.cbKetchup.CheckedChanged += new System.EventHandler(this.cbVegetables_CheckedChanged);
            // 
            // cbSicilial
            // 
            this.cbSicilial.AutoSize = true;
            this.cbSicilial.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbSicilial.ForeColor = System.Drawing.Color.Black;
            this.cbSicilial.Location = new System.Drawing.Point(21, 87);
            this.cbSicilial.Name = "cbSicilial";
            this.cbSicilial.Size = new System.Drawing.Size(110, 21);
            this.cbSicilial.TabIndex = 0;
            this.cbSicilial.Tag = "0,99";
            this.cbSicilial.Text = "Сицилиански";
            this.cbSicilial.UseVisualStyleBackColor = true;
            this.cbSicilial.CheckedChanged += new System.EventHandler(this.cbVegetables_CheckedChanged);
            // 
            // cbBianko
            // 
            this.cbBianko.AutoSize = true;
            this.cbBianko.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbBianko.ForeColor = System.Drawing.Color.Black;
            this.cbBianko.Location = new System.Drawing.Point(21, 33);
            this.cbBianko.Name = "cbBianko";
            this.cbBianko.Size = new System.Drawing.Size(73, 21);
            this.cbBianko.TabIndex = 0;
            this.cbBianko.Tag = "0,99";
            this.cbBianko.Text = "Бианко";
            this.cbBianko.UseVisualStyleBackColor = true;
            this.cbBianko.CheckedChanged += new System.EventHandler(this.cbVegetables_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.Maroon;
            this.btnClose.Location = new System.Drawing.Point(801, 397);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(124, 41);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Затвори";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOrder.ForeColor = System.Drawing.Color.Maroon;
            this.btnOrder.Location = new System.Drawing.Point(656, 397);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(139, 41);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "Поръчай";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNewOrder.ForeColor = System.Drawing.Color.Maroon;
            this.btnNewOrder.Location = new System.Drawing.Point(463, 397);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(187, 41);
            this.btnNewOrder.TabIndex = 2;
            this.btnNewOrder.Text = "Нова поръчка";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.ForeColor = System.Drawing.Color.Maroon;
            this.lblTotal.Location = new System.Drawing.Point(808, 310);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(116, 43);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "0.00лв.";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(727, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Сума:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(148)))));
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.gbSauces);
            this.Controls.Add(this.gbSideDish);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.gbKind);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пицария ПМГ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbKind.ResumeLayout(false);
            this.gbKind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPizza)).EndInit();
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbSideDish.ResumeLayout(false);
            this.gbSideDish.PerformLayout();
            this.gbSauces.ResumeLayout(false);
            this.gbSauces.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbKind;
        private System.Windows.Forms.PictureBox pbPizza;
        private System.Windows.Forms.RadioButton rdnVegetariana;
        private System.Windows.Forms.RadioButton rdnCaprichosa;
        private System.Windows.Forms.RadioButton rdnPalermo;
        private System.Windows.Forms.RadioButton rdnCuatro;
        private System.Windows.Forms.RadioButton rdnMargarita;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rdnBig;
        private System.Windows.Forms.RadioButton rdnSmall;
        private System.Windows.Forms.GroupBox gbSideDish;
        private System.Windows.Forms.CheckBox cbClam;
        private System.Windows.Forms.CheckBox cbPeppers;
        private System.Windows.Forms.CheckBox cbCheese;
        private System.Windows.Forms.CheckBox cbEgg;
        private System.Windows.Forms.CheckBox cbVegetables;
        private System.Windows.Forms.GroupBox gbSauces;
        private System.Windows.Forms.CheckBox cbGarlic;
        private System.Windows.Forms.CheckBox cbTomato;
        private System.Windows.Forms.CheckBox cbSpicy;
        private System.Windows.Forms.CheckBox cbKetchup;
        private System.Windows.Forms.CheckBox cbSicilial;
        private System.Windows.Forms.CheckBox cbBianko;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label1;
    }
}

