namespace Лабораторная_2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEffects = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEffect1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEffect2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEffect3 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEffect7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemEffect4 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEffect5 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEffect6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemEffect8 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEffect9 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEffect10 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEffect11 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btPen = new System.Windows.Forms.ToolStripButton();
            this.btLastik = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btLine = new System.Windows.Forms.ToolStripButton();
            this.btEllips = new System.Windows.Forms.ToolStripButton();
            this.btStar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btBlack = new System.Windows.Forms.ToolStripButton();
            this.btWhite = new System.Windows.Forms.ToolStripButton();
            this.btRed = new System.Windows.Forms.ToolStripButton();
            this.btYellow = new System.Windows.Forms.ToolStripButton();
            this.btGreen = new System.Windows.Forms.ToolStripButton();
            this.btBlue = new System.Windows.Forms.ToolStripButton();
            this.btColorBox = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btScaleInc = new System.Windows.Forms.ToolStripButton();
            this.btScaleDec = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(31, 27);
            this.trackBar1.Maximum = 50;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(150, 45);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.TickFrequency = 5;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(187, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(37, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "1";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(56, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Толщина линий";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFile,
            this.MenuItemEffects,
            this.MenuItemWindow});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuItemFile
            // 
            this.MenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemNew,
            this.MenuItemOpen,
            this.MenuItemSave,
            this.MenuItemSaveAs,
            this.MenuItemClose});
            this.MenuItemFile.Name = "MenuItemFile";
            this.MenuItemFile.Size = new System.Drawing.Size(48, 20);
            this.MenuItemFile.Text = "Файл";
            // 
            // MenuItemNew
            // 
            this.MenuItemNew.Name = "MenuItemNew";
            this.MenuItemNew.Size = new System.Drawing.Size(153, 22);
            this.MenuItemNew.Text = "Новый";
            this.MenuItemNew.Click += new System.EventHandler(this.MenuItemNew_Click);
            // 
            // MenuItemOpen
            // 
            this.MenuItemOpen.Name = "MenuItemOpen";
            this.MenuItemOpen.Size = new System.Drawing.Size(153, 22);
            this.MenuItemOpen.Text = "Открыть";
            this.MenuItemOpen.Click += new System.EventHandler(this.MenuItemOpen_Click);
            // 
            // MenuItemSave
            // 
            this.MenuItemSave.Name = "MenuItemSave";
            this.MenuItemSave.Size = new System.Drawing.Size(153, 22);
            this.MenuItemSave.Text = "Сохранить";
            this.MenuItemSave.Click += new System.EventHandler(this.MenuItemSave_Click);
            // 
            // MenuItemSaveAs
            // 
            this.MenuItemSaveAs.Name = "MenuItemSaveAs";
            this.MenuItemSaveAs.Size = new System.Drawing.Size(153, 22);
            this.MenuItemSaveAs.Text = "Сохранить как";
            this.MenuItemSaveAs.Click += new System.EventHandler(this.MenuItemSaveAs_Click);
            // 
            // MenuItemClose
            // 
            this.MenuItemClose.Name = "MenuItemClose";
            this.MenuItemClose.Size = new System.Drawing.Size(153, 22);
            this.MenuItemClose.Text = "Закрыть";
            this.MenuItemClose.Click += new System.EventHandler(this.MenuItemClose_Click);
            // 
            // MenuItemEffects
            // 
            this.MenuItemEffects.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemEffect1,
            this.MenuItemEffect2,
            this.MenuItemEffect3,
            this.MenuItemEffect7,
            this.toolStripSeparator4,
            this.MenuItemEffect4,
            this.MenuItemEffect5,
            this.MenuItemEffect6,
            this.toolStripSeparator5,
            this.MenuItemEffect8,
            this.MenuItemEffect9,
            this.MenuItemEffect10,
            this.MenuItemEffect11});
            this.MenuItemEffects.Name = "MenuItemEffects";
            this.MenuItemEffects.Size = new System.Drawing.Size(95, 20);
            this.MenuItemEffects.Text = "Изображение";
            // 
            // MenuItemEffect1
            // 
            this.MenuItemEffect1.Name = "MenuItemEffect1";
            this.MenuItemEffect1.Size = new System.Drawing.Size(260, 22);
            this.MenuItemEffect1.Text = "Чеканка";
            this.MenuItemEffect1.Click += new System.EventHandler(this.MenuItemEffect1_Click);
            // 
            // MenuItemEffect2
            // 
            this.MenuItemEffect2.Name = "MenuItemEffect2";
            this.MenuItemEffect2.Size = new System.Drawing.Size(260, 22);
            this.MenuItemEffect2.Text = "Резкость";
            this.MenuItemEffect2.Click += new System.EventHandler(this.MenuItemEffect2_Click);
            // 
            // MenuItemEffect3
            // 
            this.MenuItemEffect3.Name = "MenuItemEffect3";
            this.MenuItemEffect3.Size = new System.Drawing.Size(260, 22);
            this.MenuItemEffect3.Text = "Сглаживание";
            this.MenuItemEffect3.Click += new System.EventHandler(this.MenuItemEffect3_Click);
            // 
            // MenuItemEffect7
            // 
            this.MenuItemEffect7.Name = "MenuItemEffect7";
            this.MenuItemEffect7.Size = new System.Drawing.Size(260, 22);
            this.MenuItemEffect7.Text = "Размытие";
            this.MenuItemEffect7.Click += new System.EventHandler(this.MenuItemEffect7_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(257, 6);
            // 
            // MenuItemEffect4
            // 
            this.MenuItemEffect4.Name = "MenuItemEffect4";
            this.MenuItemEffect4.Size = new System.Drawing.Size(260, 22);
            this.MenuItemEffect4.Text = "Изначальный размер";
            this.MenuItemEffect4.Click += new System.EventHandler(this.MenuItemEffect4_Click);
            // 
            // MenuItemEffect5
            // 
            this.MenuItemEffect5.Name = "MenuItemEffect5";
            this.MenuItemEffect5.Size = new System.Drawing.Size(260, 22);
            this.MenuItemEffect5.Text = "Уменьшить размер";
            this.MenuItemEffect5.Click += new System.EventHandler(this.MenuItemEffect5_Click);
            // 
            // MenuItemEffect6
            // 
            this.MenuItemEffect6.Name = "MenuItemEffect6";
            this.MenuItemEffect6.Size = new System.Drawing.Size(260, 22);
            this.MenuItemEffect6.Text = "Увеличить размер";
            this.MenuItemEffect6.Click += new System.EventHandler(this.MenuItemEffect6_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(257, 6);
            // 
            // MenuItemEffect8
            // 
            this.MenuItemEffect8.Name = "MenuItemEffect8";
            this.MenuItemEffect8.Size = new System.Drawing.Size(260, 22);
            this.MenuItemEffect8.Text = "Поворот против часовой стрелки";
            this.MenuItemEffect8.Click += new System.EventHandler(this.MenuItemEffect8_Click);
            // 
            // MenuItemEffect9
            // 
            this.MenuItemEffect9.Name = "MenuItemEffect9";
            this.MenuItemEffect9.Size = new System.Drawing.Size(260, 22);
            this.MenuItemEffect9.Text = "Поворот по часовой стрелке";
            this.MenuItemEffect9.Click += new System.EventHandler(this.MenuItemEffect9_Click);
            // 
            // MenuItemEffect10
            // 
            this.MenuItemEffect10.Name = "MenuItemEffect10";
            this.MenuItemEffect10.Size = new System.Drawing.Size(260, 22);
            this.MenuItemEffect10.Text = "Отразить по вертикали";
            this.MenuItemEffect10.Click += new System.EventHandler(this.MenuItemEffect10_Click);
            // 
            // MenuItemEffect11
            // 
            this.MenuItemEffect11.Name = "MenuItemEffect11";
            this.MenuItemEffect11.Size = new System.Drawing.Size(260, 22);
            this.MenuItemEffect11.Text = "Отразить по горизонтали";
            this.MenuItemEffect11.Click += new System.EventHandler(this.MenuItemEffect11_Click);
            // 
            // MenuItemWindow
            // 
            this.MenuItemWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemCascade,
            this.MenuItemHorizontal,
            this.MenuItemVertical,
            this.MenuItemOrder});
            this.MenuItemWindow.Name = "MenuItemWindow";
            this.MenuItemWindow.Size = new System.Drawing.Size(48, 20);
            this.MenuItemWindow.Text = "Окно";
            // 
            // MenuItemCascade
            // 
            this.MenuItemCascade.Name = "MenuItemCascade";
            this.MenuItemCascade.Size = new System.Drawing.Size(187, 22);
            this.MenuItemCascade.Text = "Каскадом";
            this.MenuItemCascade.Click += new System.EventHandler(this.MenuItemCascade_Click);
            // 
            // MenuItemHorizontal
            // 
            this.MenuItemHorizontal.Name = "MenuItemHorizontal";
            this.MenuItemHorizontal.Size = new System.Drawing.Size(187, 22);
            this.MenuItemHorizontal.Text = "Сверху вниз";
            this.MenuItemHorizontal.Click += new System.EventHandler(this.MenuItemHorizontal_Click);
            // 
            // MenuItemVertical
            // 
            this.MenuItemVertical.Name = "MenuItemVertical";
            this.MenuItemVertical.Size = new System.Drawing.Size(187, 22);
            this.MenuItemVertical.Text = "Слева направо";
            this.MenuItemVertical.Click += new System.EventHandler(this.MenuItemVertical_Click);
            // 
            // MenuItemOrder
            // 
            this.MenuItemOrder.Name = "MenuItemOrder";
            this.MenuItemOrder.Size = new System.Drawing.Size(187, 22);
            this.MenuItemOrder.Text = "Упорядочить значки";
            this.MenuItemOrder.Click += new System.EventHandler(this.MenuItemOrder_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btPen,
            this.btLastik,
            this.toolStripSeparator1,
            this.btLine,
            this.btEllips,
            this.btStar,
            this.toolStripSeparator2,
            this.btBlack,
            this.btWhite,
            this.btRed,
            this.btYellow,
            this.btGreen,
            this.btBlue,
            this.btColorBox,
            this.toolStripSeparator3,
            this.btScaleInc,
            this.btScaleDec});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 48);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btPen
            // 
            this.btPen.Checked = true;
            this.btPen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btPen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btPen.Image = ((System.Drawing.Image)(resources.GetObject("btPen.Image")));
            this.btPen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btPen.Margin = new System.Windows.Forms.Padding(0, 1, 200, 2);
            this.btPen.Name = "btPen";
            this.btPen.Size = new System.Drawing.Size(23, 45);
            this.btPen.Text = "Перо";
            this.btPen.Click += new System.EventHandler(this.btPen_Click);
            // 
            // btLastik
            // 
            this.btLastik.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btLastik.Image = ((System.Drawing.Image)(resources.GetObject("btLastik.Image")));
            this.btLastik.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btLastik.Name = "btLastik";
            this.btLastik.Size = new System.Drawing.Size(23, 45);
            this.btLastik.Text = "Ластик";
            this.btLastik.Click += new System.EventHandler(this.btLastik_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 48);
            // 
            // btLine
            // 
            this.btLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btLine.Image = ((System.Drawing.Image)(resources.GetObject("btLine.Image")));
            this.btLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btLine.Name = "btLine";
            this.btLine.Size = new System.Drawing.Size(23, 45);
            this.btLine.Text = "Прямая";
            this.btLine.Click += new System.EventHandler(this.btLine_Click);
            // 
            // btEllips
            // 
            this.btEllips.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btEllips.Image = ((System.Drawing.Image)(resources.GetObject("btEllips.Image")));
            this.btEllips.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btEllips.Name = "btEllips";
            this.btEllips.Size = new System.Drawing.Size(23, 45);
            this.btEllips.Text = "Эллипс";
            this.btEllips.Click += new System.EventHandler(this.btEllips_Click);
            // 
            // btStar
            // 
            this.btStar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btStar.Image = ((System.Drawing.Image)(resources.GetObject("btStar.Image")));
            this.btStar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btStar.Name = "btStar";
            this.btStar.Size = new System.Drawing.Size(23, 45);
            this.btStar.Text = "Звезда";
            this.btStar.Click += new System.EventHandler(this.btStar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 48);
            // 
            // btBlack
            // 
            this.btBlack.Checked = true;
            this.btBlack.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btBlack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btBlack.Image = global::Лабораторная_2.Properties.Resources.Black;
            this.btBlack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btBlack.Name = "btBlack";
            this.btBlack.Size = new System.Drawing.Size(23, 45);
            this.btBlack.Text = "Черный";
            this.btBlack.Click += new System.EventHandler(this.btBlack_Click);
            // 
            // btWhite
            // 
            this.btWhite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btWhite.Image = global::Лабораторная_2.Properties.Resources.White;
            this.btWhite.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btWhite.Name = "btWhite";
            this.btWhite.Size = new System.Drawing.Size(23, 45);
            this.btWhite.Text = "Белый";
            this.btWhite.Click += new System.EventHandler(this.btWhite_Click);
            // 
            // btRed
            // 
            this.btRed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btRed.Image = global::Лабораторная_2.Properties.Resources.Red;
            this.btRed.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btRed.Name = "btRed";
            this.btRed.Size = new System.Drawing.Size(23, 45);
            this.btRed.Text = "Красный";
            this.btRed.Click += new System.EventHandler(this.btRed_Click);
            // 
            // btYellow
            // 
            this.btYellow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btYellow.Image = global::Лабораторная_2.Properties.Resources.Yellow;
            this.btYellow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btYellow.Name = "btYellow";
            this.btYellow.Size = new System.Drawing.Size(23, 45);
            this.btYellow.Text = "Желтый";
            this.btYellow.Click += new System.EventHandler(this.btYellow_Click);
            // 
            // btGreen
            // 
            this.btGreen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btGreen.Image = global::Лабораторная_2.Properties.Resources.Green;
            this.btGreen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btGreen.Name = "btGreen";
            this.btGreen.Size = new System.Drawing.Size(23, 45);
            this.btGreen.Text = "Зеленый";
            this.btGreen.Click += new System.EventHandler(this.btGreen_Click);
            // 
            // btBlue
            // 
            this.btBlue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btBlue.Image = global::Лабораторная_2.Properties.Resources.Blue;
            this.btBlue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btBlue.Name = "btBlue";
            this.btBlue.Size = new System.Drawing.Size(23, 45);
            this.btBlue.Text = "Синий";
            this.btBlue.Click += new System.EventHandler(this.btBlue_Click);
            // 
            // btColorBox
            // 
            this.btColorBox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btColorBox.Image = global::Лабораторная_2.Properties.Resources.ColorBox;
            this.btColorBox.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btColorBox.Name = "btColorBox";
            this.btColorBox.Size = new System.Drawing.Size(23, 45);
            this.btColorBox.Text = "Выбрать цвет";
            this.btColorBox.Click += new System.EventHandler(this.btColorBox_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 48);
            // 
            // btScaleInc
            // 
            this.btScaleInc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btScaleInc.Image = ((System.Drawing.Image)(resources.GetObject("btScaleInc.Image")));
            this.btScaleInc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btScaleInc.Name = "btScaleInc";
            this.btScaleInc.Size = new System.Drawing.Size(23, 45);
            this.btScaleInc.Text = "Увеличить масштаб";
            this.btScaleInc.Click += new System.EventHandler(this.btScaleInc_Click);
            // 
            // btScaleDec
            // 
            this.btScaleDec.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btScaleDec.Image = ((System.Drawing.Image)(resources.GetObject("btScaleDec.Image")));
            this.btScaleDec.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btScaleDec.Name = "btScaleDec";
            this.btScaleDec.Size = new System.Drawing.Size(23, 45);
            this.btScaleDec.Text = "Уменьшить масштаб";
            this.btScaleDec.Click += new System.EventHandler(this.btScaleDec_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Графический редактор";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem MenuItemNew;
        private System.Windows.Forms.ToolStripMenuItem MenuItemOpen;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSave;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSaveAs;
        private System.Windows.Forms.ToolStripMenuItem MenuItemClose;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEffects;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEffect1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEffect2;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEffect3;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEffect4;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEffect5;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEffect6;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEffect7;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEffect8;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEffect9;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEffect10;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEffect11;
        private System.Windows.Forms.ToolStripMenuItem MenuItemWindow;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCascade;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHorizontal;
        private System.Windows.Forms.ToolStripMenuItem MenuItemVertical;
        private System.Windows.Forms.ToolStripMenuItem MenuItemOrder;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btPen;
        private System.Windows.Forms.ToolStripButton btLastik;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btLine;
        private System.Windows.Forms.ToolStripButton btEllips;
        private System.Windows.Forms.ToolStripButton btStar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btBlack;
        private System.Windows.Forms.ToolStripButton btWhite;
        private System.Windows.Forms.ToolStripButton btRed;
        private System.Windows.Forms.ToolStripButton btGreen;
        private System.Windows.Forms.ToolStripButton btBlue;
        private System.Windows.Forms.ToolStripButton btYellow;
        private System.Windows.Forms.ToolStripButton btColorBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btScaleInc;
        private System.Windows.Forms.ToolStripButton btScaleDec;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}

