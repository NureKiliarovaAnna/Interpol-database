using System.Drawing;
using System.Windows.Forms;

namespace MainForm
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.опрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnHome = new System.Windows.Forms.LinkLabel();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAgeToFilter = new System.Windows.Forms.TextBox();
            this.txtHeightToFilter = new System.Windows.Forms.TextBox();
            this.txtAgeFromFilter = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCrimePlaceFilter = new System.Windows.Forms.TextBox();
            this.dtpCrimeDateFilter = new System.Windows.Forms.DateTimePicker();
            this.cmbCrimeTypeFilter = new System.Windows.Forms.ComboBox();
            this.cmbEyeColorFilter = new System.Windows.Forms.ComboBox();
            this.cmbHairColorFilter = new System.Windows.Forms.ComboBox();
            this.txtHeightFromFilter = new System.Windows.Forms.TextBox();
            this.txtCitizenshipFilter = new System.Windows.Forms.TextBox();
            this.txtBirthPlaceFilter = new System.Windows.Forms.TextBox();
            this.cmbGenderFilter = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNicknameFilter = new System.Windows.Forms.TextBox();
            this.txtLastNameFilter = new System.Windows.Forms.TextBox();
            this.txtFirstNameFilter = new System.Windows.Forms.TextBox();
            this.lstCriminals = new System.Windows.Forms.ListBox();
            this.AddCriminalForm = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 92);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Interpol";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.toolStripSeparator,
            this.сохранитьToolStripMenuItem,
            this.сохранитькакToolStripMenuItem,
            this.toolStripSeparator1,
            this.печатьToolStripMenuItem,
            this.предварительныйпросмотрToolStripMenuItem,
            this.toolStripSeparator2,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.файлToolStripMenuItem.Text = "&File";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(291, 6);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(291, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(291, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(294, 26);
            this.выходToolStripMenuItem.Text = "Ви&хід";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.опрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.справкаToolStripMenuItem.Text = "He&lp";
            // 
            // содержаниеToolStripMenuItem
            // 
            this.содержаниеToolStripMenuItem.Name = "содержаниеToolStripMenuItem";
            this.содержаниеToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.содержаниеToolStripMenuItem.Text = "&Содержание";
            // 
            // индексToolStripMenuItem
            // 
            this.индексToolStripMenuItem.Name = "индексToolStripMenuItem";
            this.индексToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.индексToolStripMenuItem.Text = "&Индекс";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.поискToolStripMenuItem.Text = "&Поиск";
            // 
            // btnHome
            // 
            this.btnHome.ActiveLinkColor = System.Drawing.Color.Black;
            this.btnHome.AutoSize = true;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.DisabledLinkColor = System.Drawing.Color.Black;
            this.btnHome.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.btnHome.LinkColor = System.Drawing.Color.Black;
            this.btnHome.Location = new System.Drawing.Point(19, 10);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(49, 20);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "HOME";
            this.btnHome.VisitedLinkColor = System.Drawing.Color.Black;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.Location = new System.Drawing.Point(360, 521);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 30);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Пошук";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(185, 521);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 30);
            this.button1.TabIndex = 68;
            this.button1.Text = "Очистити";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(306, 265);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 20);
            this.label18.TabIndex = 67;
            this.label18.Text = "до";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(202, 265);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 20);
            this.label14.TabIndex = 66;
            this.label14.Text = "від";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(306, 160);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 20);
            this.label13.TabIndex = 65;
            this.label13.Text = "до";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(202, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 20);
            this.label8.TabIndex = 64;
            this.label8.Text = "від";
            // 
            // txtAgeToFilter
            // 
            this.txtAgeToFilter.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAgeToFilter.Location = new System.Drawing.Point(341, 157);
            this.txtAgeToFilter.Name = "txtAgeToFilter";
            this.txtAgeToFilter.Size = new System.Drawing.Size(53, 27);
            this.txtAgeToFilter.TabIndex = 7;
            // 
            // txtHeightToFilter
            // 
            this.txtHeightToFilter.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtHeightToFilter.Location = new System.Drawing.Point(341, 262);
            this.txtHeightToFilter.Name = "txtHeightToFilter";
            this.txtHeightToFilter.Size = new System.Drawing.Size(53, 27);
            this.txtHeightToFilter.TabIndex = 11;
            // 
            // txtAgeFromFilter
            // 
            this.txtAgeFromFilter.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAgeFromFilter.Location = new System.Drawing.Point(247, 157);
            this.txtAgeFromFilter.Name = "txtAgeFromFilter";
            this.txtAgeFromFilter.Size = new System.Drawing.Size(53, 27);
            this.txtAgeFromFilter.TabIndex = 6;
            // 
            // txtCrimePlaceFilter
            // 
            this.txtCrimePlaceFilter.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCrimePlaceFilter.Location = new System.Drawing.Point(185, 440);
            this.txtCrimePlaceFilter.Name = "txtCrimePlaceFilter";
            this.txtCrimePlaceFilter.Size = new System.Drawing.Size(285, 27);
            this.txtCrimePlaceFilter.TabIndex = 16;
            // 
            // dtpCrimeDateFilter
            // 
            this.dtpCrimeDateFilter.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpCrimeDateFilter.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCrimeDateFilter.Location = new System.Drawing.Point(185, 405);
            this.dtpCrimeDateFilter.Name = "dtpCrimeDateFilter";
            this.dtpCrimeDateFilter.ShowCheckBox = true;
            this.dtpCrimeDateFilter.Size = new System.Drawing.Size(285, 27);
            this.dtpCrimeDateFilter.TabIndex = 15;
            // 
            // cmbCrimeTypeFilter
            // 
            this.cmbCrimeTypeFilter.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbCrimeTypeFilter.FormattingEnabled = true;
            this.cmbCrimeTypeFilter.Items.AddRange(new object[] {
            "вбивство, напад",
            "згвалтування",
            "крадіжка",
            "підробка",
            "вимагання",
            "викрадення людей",
            "тероризм",
            "корупція",
            "лжесвідчення",
            "шахрайство",
            "екологічний",
            "комп\'ютерний"});
            this.cmbCrimeTypeFilter.Location = new System.Drawing.Point(185, 369);
            this.cmbCrimeTypeFilter.Name = "cmbCrimeTypeFilter";
            this.cmbCrimeTypeFilter.Size = new System.Drawing.Size(285, 28);
            this.cmbCrimeTypeFilter.TabIndex = 14;
            // 
            // cmbEyeColorFilter
            // 
            this.cmbEyeColorFilter.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbEyeColorFilter.FormattingEnabled = true;
            this.cmbEyeColorFilter.Items.AddRange(new object[] {
            "Карий",
            "Сірий",
            "Зелений",
            "Блакитний",
            "Чорний"});
            this.cmbEyeColorFilter.Location = new System.Drawing.Point(185, 333);
            this.cmbEyeColorFilter.Name = "cmbEyeColorFilter";
            this.cmbEyeColorFilter.Size = new System.Drawing.Size(285, 28);
            this.cmbEyeColorFilter.TabIndex = 13;
            // 
            // cmbHairColorFilter
            // 
            this.cmbHairColorFilter.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbHairColorFilter.FormattingEnabled = true;
            this.cmbHairColorFilter.Items.AddRange(new object[] {
            "Чорний",
            "Блонд",
            "Рудий",
            "Шатен",
            "Сірий(сивий)",
            "Каштановий"});
            this.cmbHairColorFilter.Location = new System.Drawing.Point(185, 297);
            this.cmbHairColorFilter.Name = "cmbHairColorFilter";
            this.cmbHairColorFilter.Size = new System.Drawing.Size(285, 28);
            this.cmbHairColorFilter.TabIndex = 12;
            // 
            // txtHeightFromFilter
            // 
            this.txtHeightFromFilter.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtHeightFromFilter.Location = new System.Drawing.Point(247, 262);
            this.txtHeightFromFilter.Name = "txtHeightFromFilter";
            this.txtHeightFromFilter.Size = new System.Drawing.Size(53, 27);
            this.txtHeightFromFilter.TabIndex = 10;
            // 
            // txtCitizenshipFilter
            // 
            this.txtCitizenshipFilter.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCitizenshipFilter.Location = new System.Drawing.Point(185, 227);
            this.txtCitizenshipFilter.Name = "txtCitizenshipFilter";
            this.txtCitizenshipFilter.Size = new System.Drawing.Size(285, 27);
            this.txtCitizenshipFilter.TabIndex = 9;
            // 
            // txtBirthPlaceFilter
            // 
            this.txtBirthPlaceFilter.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBirthPlaceFilter.Location = new System.Drawing.Point(185, 192);
            this.txtBirthPlaceFilter.Name = "txtBirthPlaceFilter";
            this.txtBirthPlaceFilter.Size = new System.Drawing.Size(285, 27);
            this.txtBirthPlaceFilter.TabIndex = 8;
            // 
            // cmbGenderFilter
            // 
            this.cmbGenderFilter.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbGenderFilter.FormattingEnabled = true;
            this.cmbGenderFilter.Items.AddRange(new object[] {
            "чоловіча",
            "жіноча"});
            this.cmbGenderFilter.Location = new System.Drawing.Point(185, 121);
            this.cmbGenderFilter.Name = "cmbGenderFilter";
            this.cmbGenderFilter.Size = new System.Drawing.Size(285, 28);
            this.cmbGenderFilter.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(100, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Кличка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(80, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Прізвище";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(120, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Ім\'я";
            // 
            // txtNicknameFilter
            // 
            this.txtNicknameFilter.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNicknameFilter.Location = new System.Drawing.Point(185, 86);
            this.txtNicknameFilter.Name = "txtNicknameFilter";
            this.txtNicknameFilter.Size = new System.Drawing.Size(285, 27);
            this.txtNicknameFilter.TabIndex = 4;
            // 
            // txtLastNameFilter
            // 
            this.txtLastNameFilter.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLastNameFilter.Location = new System.Drawing.Point(185, 51);
            this.txtLastNameFilter.Name = "txtLastNameFilter";
            this.txtLastNameFilter.Size = new System.Drawing.Size(285, 27);
            this.txtLastNameFilter.TabIndex = 3;
            // 
            // txtFirstNameFilter
            // 
            this.txtFirstNameFilter.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFirstNameFilter.Location = new System.Drawing.Point(185, 16);
            this.txtFirstNameFilter.Name = "txtFirstNameFilter";
            this.txtFirstNameFilter.Size = new System.Drawing.Size(285, 27);
            this.txtFirstNameFilter.TabIndex = 2;
            // 
            // lstCriminals
            // 
            this.lstCriminals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstCriminals.BackColor = System.Drawing.SystemColors.Control;
            this.lstCriminals.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstCriminals.FormattingEnabled = true;
            this.lstCriminals.ItemHeight = 20;
            this.lstCriminals.Location = new System.Drawing.Point(485, 131);
            this.lstCriminals.Name = "lstCriminals";
            this.lstCriminals.Size = new System.Drawing.Size(297, 504);
            this.lstCriminals.TabIndex = 18;
            this.lstCriminals.DoubleClick += new System.EventHandler(this.lstCriminals_DoubleClick);
            // 
            // AddCriminalForm
            // 
            this.AddCriminalForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddCriminalForm.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCriminalForm.Location = new System.Drawing.Point(656, 651);
            this.AddCriminalForm.Name = "AddCriminalForm";
            this.AddCriminalForm.Size = new System.Drawing.Size(110, 30);
            this.AddCriminalForm.TabIndex = 19;
            this.AddCriminalForm.Text = "Додати";
            this.AddCriminalForm.UseVisualStyleBackColor = true;
            this.AddCriminalForm.Click += new System.EventHandler(this.btnAddCriminal_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 693);
            this.Controls.Add(this.AddCriminalForm);
            this.Controls.Add(this.lstCriminals);
            this.Controls.Add(this.pnlFilters);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 740);
            this.Name = "MainForm";
            this.Text = "Головна";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlFilters.ResumeLayout(false);
            this.pnlFilters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox btnAccount;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem опрограммеToolStripMenuItem;
        private Panel pnlFilters;
        private ListBox lstCriminals;
        private Button AddCriminalForm;
        private Button btnSearch;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtNicknameFilter;
        private TextBox txtLastNameFilter;
        private TextBox txtFirstNameFilter;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtCrimePlaceFilter;
        private DateTimePicker dtpCrimeDateFilter;
        private ComboBox cmbCrimeTypeFilter;
        private ComboBox cmbEyeColorFilter;
        private ComboBox cmbHairColorFilter;
        private TextBox txtHeightFromFilter;
        private TextBox txtCitizenshipFilter;
        private TextBox txtBirthPlaceFilter;
        private ComboBox cmbGenderFilter;
        private TextBox txtAgeToFilter;
        private TextBox txtHeightToFilter;
        private TextBox txtAgeFromFilter;
        private Label label18;
        private Label label14;
        private Label label13;
        private Label label8;
        private LinkLabel btnHome;
        private LinkLabel linkLabel1;
        private Button button1;
    }
}