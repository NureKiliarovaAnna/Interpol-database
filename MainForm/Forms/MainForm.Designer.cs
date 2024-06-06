using System.Drawing;
using System.Windows.Forms;

namespace Interpol
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnHome = new System.Windows.Forms.LinkLabel();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
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
            this.panel1.Size = new System.Drawing.Size(912, 92);
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
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(912, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.exitToolStripMenuItem.Text = "&Вийти";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.addToolStripMenuItem.Text = "Додати";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.btnAddCriminal_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.editToolStripMenuItem.Text = "Редагувати";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.deleteToolStripMenuItem.Text = "Видалити";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "He&lp";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.aboutToolStripMenuItem.Text = "&Про програму...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlTop.Controls.Add(this.linkLabel1);
            this.pnlTop.Controls.Add(this.btnHome);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 92);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(912, 39);
            this.pnlTop.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.ForeColor = System.Drawing.Color.Black;
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(731, 10);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(159, 20);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.Text = "Вийти з акаунту";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Click += new System.EventHandler(this.btnLogOut_Click);
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
            this.btnHome.Size = new System.Drawing.Size(79, 20);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Головна";
            this.btnHome.VisitedLinkColor = System.Drawing.Color.Black;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlFilters
            // 
            this.pnlFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlFilters.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlFilters.Controls.Add(this.btnSearch);
            this.pnlFilters.Controls.Add(this.btnClear);
            this.pnlFilters.Controls.Add(this.label18);
            this.pnlFilters.Controls.Add(this.label14);
            this.pnlFilters.Controls.Add(this.label13);
            this.pnlFilters.Controls.Add(this.label8);
            this.pnlFilters.Controls.Add(this.txtAgeToFilter);
            this.pnlFilters.Controls.Add(this.txtHeightToFilter);
            this.pnlFilters.Controls.Add(this.txtAgeFromFilter);
            this.pnlFilters.Controls.Add(this.label17);
            this.pnlFilters.Controls.Add(this.label16);
            this.pnlFilters.Controls.Add(this.label15);
            this.pnlFilters.Controls.Add(this.label12);
            this.pnlFilters.Controls.Add(this.label11);
            this.pnlFilters.Controls.Add(this.label10);
            this.pnlFilters.Controls.Add(this.label9);
            this.pnlFilters.Controls.Add(this.label7);
            this.pnlFilters.Controls.Add(this.label6);
            this.pnlFilters.Controls.Add(this.label5);
            this.pnlFilters.Controls.Add(this.txtCrimePlaceFilter);
            this.pnlFilters.Controls.Add(this.dtpCrimeDateFilter);
            this.pnlFilters.Controls.Add(this.cmbCrimeTypeFilter);
            this.pnlFilters.Controls.Add(this.cmbEyeColorFilter);
            this.pnlFilters.Controls.Add(this.cmbHairColorFilter);
            this.pnlFilters.Controls.Add(this.txtHeightFromFilter);
            this.pnlFilters.Controls.Add(this.txtCitizenshipFilter);
            this.pnlFilters.Controls.Add(this.txtBirthPlaceFilter);
            this.pnlFilters.Controls.Add(this.cmbGenderFilter);
            this.pnlFilters.Controls.Add(this.label4);
            this.pnlFilters.Controls.Add(this.label3);
            this.pnlFilters.Controls.Add(this.label2);
            this.pnlFilters.Controls.Add(this.txtNicknameFilter);
            this.pnlFilters.Controls.Add(this.txtLastNameFilter);
            this.pnlFilters.Controls.Add(this.txtFirstNameFilter);
            this.pnlFilters.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlFilters.Location = new System.Drawing.Point(0, 130);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Size = new System.Drawing.Size(486, 573);
            this.pnlFilters.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.Location = new System.Drawing.Point(360, 489);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 30);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Пошук";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.Location = new System.Drawing.Point(185, 489);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 30);
            this.btnClear.TabIndex = 68;
            this.btnClear.Text = "Очистити";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            this.txtAgeToFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyDigit_KeyPress);
            // 
            // txtHeightToFilter
            // 
            this.txtHeightToFilter.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtHeightToFilter.Location = new System.Drawing.Point(341, 262);
            this.txtHeightToFilter.Name = "txtHeightToFilter";
            this.txtHeightToFilter.Size = new System.Drawing.Size(53, 27);
            this.txtHeightToFilter.TabIndex = 11;
            this.txtHeightToFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyDigit_KeyPress);
            // 
            // txtAgeFromFilter
            // 
            this.txtAgeFromFilter.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAgeFromFilter.Location = new System.Drawing.Point(247, 157);
            this.txtAgeFromFilter.Name = "txtAgeFromFilter";
            this.txtAgeFromFilter.Size = new System.Drawing.Size(53, 27);
            this.txtAgeFromFilter.TabIndex = 6;
            this.txtAgeFromFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyDigit_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(30, 440);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(139, 40);
            this.label17.TabIndex = 60;
            this.label17.Text = "Місце скоєння\r\nзлочину";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(40, 400);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(129, 40);
            this.label16.TabIndex = 59;
            this.label16.Text = "Дата скоєння\r\nзлочину";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(50, 372);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 20);
            this.label15.TabIndex = 58;
            this.label15.Text = "Тип злочину";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(60, 337);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 20);
            this.label12.TabIndex = 55;
            this.label12.Text = "Колір очей";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(30, 300);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 20);
            this.label11.TabIndex = 54;
            this.label11.Text = "Колір волосся";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(110, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 20);
            this.label10.TabIndex = 53;
            this.label10.Text = "Зріст";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(40, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 20);
            this.label9.TabIndex = 52;
            this.label9.Text = "Громадянство";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(3, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 20);
            this.label7.TabIndex = 50;
            this.label7.Text = "Місце народження";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(130, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 49;
            this.label6.Text = "Вік";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(110, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 48;
            this.label5.Text = "Стать";
            // 
            // txtCrimePlaceFilter
            // 
            this.txtCrimePlaceFilter.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCrimePlaceFilter.Location = new System.Drawing.Point(185, 440);
            this.txtCrimePlaceFilter.Name = "txtCrimePlaceFilter";
            this.txtCrimePlaceFilter.Size = new System.Drawing.Size(285, 27);
            this.txtCrimePlaceFilter.TabIndex = 16;
            this.txtCrimePlaceFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyLetterOrHyphenOrSpace_KeyPress);
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
            "вбивство",
            "напад",
            "згвалтування",
            "крадіжка",
            "підробка",
            "вимагання",
            "викрадення людей",
            "торгівля людьми",
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
            this.cmbCrimeTypeFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyLetterOrHyphenOrSpace_KeyPress);
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
            this.cmbEyeColorFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyLetter_KeyPress);
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
            this.cmbHairColorFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyLetter_KeyPress);
            // 
            // txtHeightFromFilter
            // 
            this.txtHeightFromFilter.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtHeightFromFilter.Location = new System.Drawing.Point(247, 262);
            this.txtHeightFromFilter.Name = "txtHeightFromFilter";
            this.txtHeightFromFilter.Size = new System.Drawing.Size(53, 27);
            this.txtHeightFromFilter.TabIndex = 10;
            this.txtHeightFromFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyDigit_KeyPress);
            // 
            // txtCitizenshipFilter
            // 
            this.txtCitizenshipFilter.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCitizenshipFilter.Location = new System.Drawing.Point(185, 227);
            this.txtCitizenshipFilter.Name = "txtCitizenshipFilter";
            this.txtCitizenshipFilter.Size = new System.Drawing.Size(285, 27);
            this.txtCitizenshipFilter.TabIndex = 9;
            this.txtCitizenshipFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyLetterOrHyphenOrSpace_KeyPress);
            // 
            // txtBirthPlaceFilter
            // 
            this.txtBirthPlaceFilter.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBirthPlaceFilter.Location = new System.Drawing.Point(185, 192);
            this.txtBirthPlaceFilter.Name = "txtBirthPlaceFilter";
            this.txtBirthPlaceFilter.Size = new System.Drawing.Size(285, 27);
            this.txtBirthPlaceFilter.TabIndex = 8;
            this.txtBirthPlaceFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyLetterOrHyphenOrSpace_KeyPress);
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
            this.cmbGenderFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyLetter_KeyPress);
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
            this.txtNicknameFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyLetterOrHyphenOrSpace_KeyPress);
            // 
            // txtLastNameFilter
            // 
            this.txtLastNameFilter.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLastNameFilter.Location = new System.Drawing.Point(185, 51);
            this.txtLastNameFilter.Name = "txtLastNameFilter";
            this.txtLastNameFilter.Size = new System.Drawing.Size(285, 27);
            this.txtLastNameFilter.TabIndex = 3;
            this.txtLastNameFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyLetterOrHyphenOrSpace_KeyPress);
            // 
            // txtFirstNameFilter
            // 
            this.txtFirstNameFilter.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFirstNameFilter.Location = new System.Drawing.Point(185, 16);
            this.txtFirstNameFilter.Name = "txtFirstNameFilter";
            this.txtFirstNameFilter.Size = new System.Drawing.Size(285, 27);
            this.txtFirstNameFilter.TabIndex = 2;
            this.txtFirstNameFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyLetterOrHyphenOrSpace_KeyPress);
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
            this.lstCriminals.Size = new System.Drawing.Size(432, 504);
            this.lstCriminals.TabIndex = 18;
            this.lstCriminals.DoubleClick += new System.EventHandler(this.lstCriminals_DoubleClick);
            // 
            // AddCriminalForm
            // 
            this.AddCriminalForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddCriminalForm.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCriminalForm.Location = new System.Drawing.Point(786, 651);
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
            this.ClientSize = new System.Drawing.Size(912, 693);
            this.Controls.Add(this.AddCriminalForm);
            this.Controls.Add(this.lstCriminals);
            this.Controls.Add(this.pnlFilters);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(930, 740);
            this.Name = "MainForm";
            this.Text = "Головна сторінка";
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
        private Button btnClear;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
    }
}