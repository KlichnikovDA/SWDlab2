using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_2
{
    public partial class Form1 : Form
    {
        public enum DrawingTools { Pen, Lastik, Ellips, Star, Line };
        public DrawingTools ChosenTool;
        public Color PenColor;
        public int PenWidth;
        public int OpenedForms;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ChosenTool = DrawingTools.Pen;
            PenColor = Color.Black;
            PenWidth = 1;
            OpenedForms = 0;
        }

        #region Операции с файлами
        // Создание нового рабочего окна
        private void MenuItemNew_Click(object sender, EventArgs e)
        {
            FormChild frm = new FormChild();
            frm.MdiParent = this;
            PenWidth = trackBar1.Value;
            OpenedForms++;
            frm.Text += "(" + OpenedForms + ")";
            frm.Show();            
        }

        // Открыть файл
        private void MenuItemOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Bitmap файлы (*.bmp)|*.bmp|JPG файлы (*.jpg)|*.jpg|Все файлы (*.*)|*.*";
            ofd.Title = "Открытие изображения";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FormChild frm = new FormChild();
                frm.MdiParent = this;
                frm.Show();
                frm.Open(ofd.FileName);
            }
        }

        // Сохранить как
        public void MenuItemSaveAs_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();

                sfd.Filter = "Bitmap файлы (*.bmp)|*.bmp|JPG файлы (*.jpg)|*.jpg|Все файлы (*.*)|*.*";
                sfd.Title = "Сохранение изображения";
                sfd.FileName = (this.ActiveMdiChild as FormChild).Text;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    (this.ActiveMdiChild as FormChild).Save(sfd.FileName);
                }
            }
        }

        // Сохранить
        public void MenuItemSave_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
                if ((this.ActiveMdiChild as FormChild).FilePath != null)
                    (this.ActiveMdiChild as FormChild).Save();
                else
                    MenuItemSaveAs_Click(this, new EventArgs());
        }

        // Закрыть форму
        private void MenuItemClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.MdiChildren.Any(x => (x as FormChild).UnsavedChanges))
            {
                DialogResult result = MessageBox.Show("У Вас остались несохраненные изменения, хотите сохранить их?", "Несохраненные изменения", MessageBoxButtons.YesNo,
                      MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                if (result == DialogResult.Yes)
                    foreach (FormChild Child in this.MdiChildren)
                        if (Child.UnsavedChanges)
                        {
                            this.ActivateMdiChild(Child);
                            this.MenuItemSave_Click(this, new EventArgs());
                        }
            }
        }
        #endregion Операции с файлами

        #region Эффекты
        private void MenuItemEffect1_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
                (this.ActiveMdiChild as FormChild).Effect1();
        }

        private void MenuItemEffect2_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
                (this.ActiveMdiChild as FormChild).Effect2();
        }

        private void MenuItemEffect3_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
                (this.ActiveMdiChild as FormChild).Effect3();
        }

        private void MenuItemEffect4_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
                (this.ActiveMdiChild as FormChild).Effect4();
        }

        private void MenuItemEffect5_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
                (this.ActiveMdiChild as FormChild).Effect5();
        }

        private void MenuItemEffect6_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
                (this.ActiveMdiChild as FormChild).Effect6();
        }

        private void MenuItemEffect7_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
                (this.ActiveMdiChild as FormChild).Effect7();
        }

        private void MenuItemEffect8_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
                (this.ActiveMdiChild as FormChild).Effect8();
        }

        private void MenuItemEffect9_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
                (this.ActiveMdiChild as FormChild).Effect9();
        }

        private void MenuItemEffect10_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
                (this.ActiveMdiChild as FormChild).Effect10();
        }

        private void MenuItemEffect11_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
                (this.ActiveMdiChild as FormChild).Effect11();
        }
        #endregion Эффекты

        #region Инструменты
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = trackBar1.Value.ToString();
            PenWidth = trackBar1.Value;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int val;
            if (Int32.TryParse(textBox1.Text, out val) && val > 0 && val < 101)
                trackBar1.Value = val;
            else
                textBox1.Text = trackBar1.Value.ToString();
        }

        private void btPen_Click(object sender, EventArgs e)
        {
            ChosenTool = DrawingTools.Pen;
            btPen.Checked = true;
            btLastik.Checked = btLine.Checked = btEllips.Checked = btStar.Checked = false;
        }

        private void btLastik_Click(object sender, EventArgs e)
        {
            ChosenTool = DrawingTools.Lastik;
            btLastik.Checked = true;
            btPen.Checked = btLine.Checked = btEllips.Checked = btStar.Checked = false;
        }

        private void btLine_Click(object sender, EventArgs e)
        {
            ChosenTool = DrawingTools.Line;
            btLine.Checked = true;
            btLastik.Checked = btPen.Checked = btEllips.Checked = btStar.Checked = false;
        }

        private void btEllips_Click(object sender, EventArgs e)
        {
            ChosenTool = DrawingTools.Ellips;
            btEllips.Checked = true;
            btLastik.Checked = btLine.Checked = btPen.Checked = btStar.Checked = false;
        }

        private void btStar_Click(object sender, EventArgs e)
        {
            ChosenTool = DrawingTools.Star;
            btStar.Checked = true;
            btLastik.Checked = btLine.Checked = btEllips.Checked = btPen.Checked = false;
        }

        private void btScaleInc_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
                (this.ActiveMdiChild as FormChild).Effect6();
        }

        private void btScaleDec_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
                (this.ActiveMdiChild as FormChild).Effect5();
        }
        #endregion Инструменты

        #region Цвета
        private void btBlack_Click(object sender, EventArgs e)
        {
            PenColor = Color.Black;
            btBlack.Checked = true;
            btWhite.Checked = btRed.Checked = btYellow.Checked = btGreen.Checked = btBlue.Checked = btColorBox.Checked = false;
        }

        private void btWhite_Click(object sender, EventArgs e)
        {
            PenColor = Color.White;
            btWhite.Checked = true;
            btBlack.Checked = btRed.Checked = btYellow.Checked = btGreen.Checked = btBlue.Checked = btColorBox.Checked = false;
        }

        private void btRed_Click(object sender, EventArgs e)
        {
            PenColor = Color.Red;
            btRed.Checked = true;
            btWhite.Checked = btBlack.Checked = btYellow.Checked = btGreen.Checked = btBlue.Checked = btColorBox.Checked = false;
        }

        private void btYellow_Click(object sender, EventArgs e)
        {
            PenColor = Color.Yellow;
            btYellow.Checked = true;
            btWhite.Checked = btRed.Checked = btBlack.Checked = btGreen.Checked = btBlue.Checked = btColorBox.Checked = false;
        }

        private void btGreen_Click(object sender, EventArgs e)
        {
            PenColor = Color.Green;
            btGreen.Checked = true;
            btWhite.Checked = btRed.Checked = btYellow.Checked = btBlack.Checked = btBlue.Checked = btColorBox.Checked = false;
        }

        private void btBlue_Click(object sender, EventArgs e)
        {
            PenColor = Color.Blue;
            btBlue.Checked = true;
            btWhite.Checked = btRed.Checked = btYellow.Checked = btGreen.Checked = btBlack.Checked = btColorBox.Checked = false;
        }

        private void btColorBox_Click(object sender, EventArgs e)
        {
            btColorBox.Checked = true;
            btWhite.Checked = btRed.Checked = btYellow.Checked = btGreen.Checked = btBlue.Checked = btBlack.Checked = false;

            if (this.MdiChildren.Length == 0)
            {
                ColorDialog cd = new ColorDialog();
                cd.FullOpen = true;

                if (cd.ShowDialog() == DialogResult.OK)
                {
                    PenColor = cd.Color;
                }
            }
            else
            {
                foreach (FormChild Child in this.MdiChildren)
                    Child.BlockPaint();
                (this.ActiveMdiChild as FormChild).ChooseColor();
                foreach (FormChild Child in this.MdiChildren)
                    Child.UnBlockPaint();
            }
        }
        #endregion Цвета

        #region Расположение окон

        private void MenuItemCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
            foreach (FormChild Child in this.MdiChildren)
            {
                Child.FormChild_ResizeEnd(Child, new EventArgs());
                Child.Redraw();
            }
        }
        
        private void MenuItemHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
            foreach (FormChild Child in this.MdiChildren)
            {
                Child.FormChild_ResizeEnd(Child, new EventArgs());
                Child.Redraw();
            }
        }

        private void MenuItemVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
            foreach (FormChild Child in this.MdiChildren)
            {
                Child.FormChild_ResizeEnd(Child, new EventArgs());
                Child.Redraw();
            }
        }

        private void MenuItemOrder_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
            foreach (FormChild Child in this.MdiChildren)
            {
                Child.FormChild_ResizeEnd(Child, new EventArgs());
                Child.Redraw();
            }
        }

        #endregion Расположение окон
    }
}