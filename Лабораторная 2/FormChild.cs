using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_2
{
    public partial class FormChild : Form
    {
        // Обрабатываемое изображение
        Bitmap bmp;
        // Координаты курсора
        Point Start, End;
        // Путь к файлу
        public string FilePath;
        // Оригинальный размер изображения
        Size Orig;
        bool IsDrawing = false;
        public bool UnsavedChanges { get; set; }

        public FormChild()
        {
            InitializeComponent();
        }

        private void FormChild_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pbDraw.Width, pbDraw.Height);
            pbDraw.Image = bmp;
            Orig = panel1.Size;
            UnsavedChanges = false;
        }

        #region Операции с файлами
        // Сохранение изображения в файл по указанному пути
        public void Save(string Path)
        {
            FilePath = Path;
            pbDraw.Image.Save(Path);
            this.Text = Path.Substring(Path.LastIndexOf('\\') + 1);
            UnsavedChanges = false;
        }

        public void Save()
        {
            pbDraw.Image.Save(FilePath);
            UnsavedChanges = false;
        }

        public void Open(string Path)
        {
            FilePath = Path;
            bmp = new Bitmap(Path);
            pbDraw.Image = bmp;
            panel1.Size = bmp.Size;
            Orig = panel1.Size;
            this.Width = panel1.Width + 16;
            this.Height = panel1.Height + 40;
            string txt = Path.Substring(Path.LastIndexOf('\\') + 1);
            int Count = this.ParentForm.MdiChildren.Select(x => x.Text == this.Text).ToArray().Length - 1;
            if (Count > 0)
            {
                txt += "(" + Count.ToString() + ")";
                this.FilePath = null;
            }
            this.Text = txt;
            UnsavedChanges = false;
        }

        private void FormChild_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (UnsavedChanges)
            {
                DialogResult result = MessageBox.Show("У Вас остались несохраненные изменения, хотите сохранить их?", "Несохраненные изменения", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                if (result == DialogResult.Yes)
                    (this.ParentForm as Form1).MenuItemSave_Click(this, new EventArgs());
                else
                    UnsavedChanges = false;
            }
        }
        #endregion Операции с файлами

        #region Рисование мышью
        // Нажатие левой кнопки мыши
        private void pbDraw_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                IsDrawing = true;
                // Сохранение координат курсора
                End = Start = e.Location;
            }
        }

        // Движение мыши при зажатой левой кнопке мыши
        private void pbDraw_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsDrawing && e.Button == MouseButtons.Left)
            {
                Graphics g = Graphics.FromImage(pbDraw.Image);
                int CT = (int)(this.ParentForm as Form1).ChosenTool;
                switch (CT)
                {
                    case 0:
                        // Рисование линии между сохраненными и текущими координатами
                        End = e.Location;
                        g.DrawLine(new Pen((this.ParentForm as Form1).PenColor, (this.ParentForm as Form1).PenWidth), Start, End);
                        // Перезапись координат
                        Start = End;

                        // Обновление поля
                        pbDraw.Refresh();
                        break;
                    case 1:
                        // Рисование линии между сохраненными и текущими координатами
                        End = e.Location;
                        g.DrawLine(new Pen(Color.White, 20), Start, End);
                        // Перезапись координат
                        Start = End;

                        // Обновление поля
                        pbDraw.Refresh();
                        break;
                    case 2:
                    case 3:
                    case 4:
                        // Перезапись координат
                        End = e.Location;
                        break;
                }
            }
        }

        // Отпуск левой кнопки мыши
        private void pbDraw_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsDrawing && e.Button == MouseButtons.Left)
            {
                End = e.Location;
                Graphics g = Graphics.FromImage(pbDraw.Image);
                int CT = (int)(this.ParentForm as Form1).ChosenTool;
                switch (CT)
                {
                    case 0:
                        g.DrawLine(new Pen((this.ParentForm as Form1).PenColor, (this.ParentForm as Form1).PenWidth), Start, End);
                        pbDraw.Refresh();
                        break;
                    case 1:
                        g.DrawLine(new Pen(Color.White, 20), Start, End);
                        pbDraw.Refresh();
                        break;
                    case 2:
                        g.DrawEllipse(new Pen((this.ParentForm as Form1).PenColor, (this.ParentForm as Form1).PenWidth), Start.X, Start.Y, End.X - Start.X, End.Y - Start.Y);
                        pbDraw.Refresh();
                        break;
                    case 3:
                        PointF[] P = new PointF[11];
                        double Radius = Math.Sqrt(Math.Pow(End.X - Start.X, 2) + Math.Pow(End.Y - Start.Y, 2)), radius = Radius / 2;
                        double a = 180, da = Math.PI / 5, l;
                        for (int k = 0; k < 11; k++)
                        {
                            l = k % 2 == 0 ? radius : Radius;
                            P[k] = new PointF((float)(Start.X + l * Math.Cos(a)), (float)(Start.Y + l * Math.Sin(a)));
                            a += da;
                        }

                        g.DrawLines(new Pen((this.ParentForm as Form1).PenColor, (this.ParentForm as Form1).PenWidth), P);
                        pbDraw.Refresh();
                        break;
                    case 4:
                        g.DrawLine(new Pen((this.ParentForm as Form1).PenColor, (this.ParentForm as Form1).PenWidth), Start, End);
                        pbDraw.Refresh();
                        break;
                }
                IsDrawing = false;
                End = Start;
            }
            UnsavedChanges = true;
        }

        private void pbDraw_Paint(object sender, PaintEventArgs e)
        {
            pbDraw.Invalidate();
            int CT = (int)(this.ParentForm as Form1).ChosenTool;
            switch (CT)
            {
                case 2:
                    e.Graphics.DrawEllipse(new Pen((this.ParentForm as Form1).PenColor, (this.ParentForm as Form1).PenWidth), Start.X, Start.Y, End.X - Start.X, End.Y - Start.Y);
                    break;
                case 3:
                    PointF[] P = new PointF[11];
                    double Radius = Math.Sqrt(Math.Pow(End.X - Start.X, 2) + Math.Pow(End.Y - Start.Y, 2)), radius = Radius / 2;
                    double a = 180, da = Math.PI / 5, l;
                    for (int k = 0; k < 11; k++)
                    {
                        l = k % 2 == 0 ? radius : Radius;
                        P[k] = new PointF((float)(Start.X + l * Math.Cos(a)), (float)(Start.Y + l * Math.Sin(a)));
                        a += da;
                    }

                    e.Graphics.DrawLines(new Pen((this.ParentForm as Form1).PenColor, (this.ParentForm as Form1).PenWidth), P);
                    break;
                case 4:
                    e.Graphics.DrawLine(new Pen((this.ParentForm as Form1).PenColor, (this.ParentForm as Form1).PenWidth), Start, End);
                    break;
            }
        }

        public void ChooseColor()
        {
            ColorDialog cd = new ColorDialog();
            cd.FullOpen = true;

            //this.pbDraw.Paint -= new System.Windows.Forms.PaintEventHandler(this.pbDraw_Paint);
            if (cd.ShowDialog() == DialogResult.OK)
            {
                (this.ParentForm as Form1).PenColor = cd.Color;
            }
            //this.pbDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.pbDraw_Paint);
        }
        #endregion Рисование мышью

        #region Эффекты

        // Рельеф
        public void Effect1()
        {
            bmp = new Bitmap(pbDraw.Image);
            pbDraw.Image = bmp;
            Bitmap tempbmp = new Bitmap(pbDraw.Image);
            int i, j, DispX = 1, DispY = 1;
            int Red, Green, Blue;
            for (i = 0; i < tempbmp.Height - 1; i++)
            {
                for (j = 0; j < tempbmp.Width - 1; j++)
                {
                    Color Pixel1, Pixel2;
                    Pixel1 = tempbmp.GetPixel(j, i);
                    Pixel2 = tempbmp.GetPixel(j + DispX, i + DispY);
                    Red = Math.Min(Math.Abs(Pixel1.R - Pixel2.R + 128), 255);
                    Green = Math.Min(Math.Abs(Pixel1.G - Pixel2.G + 128), 255);
                    Blue = Math.Min(Math.Abs(Pixel1.B - Pixel2.B + 128), 255);
                    bmp.SetPixel(j, i, Color.FromArgb(Red, Green, Blue));
                }

                if (i % 10 == 0)
                {
                    pbDraw.Invalidate();
                    pbDraw.Refresh();
                }
            }
            pbDraw.Refresh();
        UnsavedChanges = true;
        }

        // Резкость
        public void Effect2()
        {
            bmp = new Bitmap(pbDraw.Image);
            pbDraw.Image = bmp;
            Bitmap tempbmp = new Bitmap(pbDraw.Image);
            int i, j, DX = 1, DY = 1;
            int Red, Green, Blue;

            for (i = DX + 1; i < tempbmp.Height; i++)
            {
                for (j = DY + 1; j < tempbmp.Width; j++)
                {
                    Red = (int)(tempbmp.GetPixel(j, i).R + 0.5 * tempbmp.GetPixel(j, i).R - tempbmp.GetPixel(j - DX, i - DY).R);
                    Green = (int)(tempbmp.GetPixel(j, i).G + 0.5 * tempbmp.GetPixel(j, i).G - tempbmp.GetPixel(j - DX, i - DY).G);
                    Blue = (int)(tempbmp.GetPixel(j, i).B + 0.5 * tempbmp.GetPixel(j, i).B - tempbmp.GetPixel(j - DX, i - DY).B);
                    Red = Math.Min(Math.Max(Red, 0), 255);
                    Green = Math.Min(Math.Max(Green, 0), 255);
                    Blue = Math.Min(Math.Max(Blue, 0), 255);
                    bmp.SetPixel(j, i, Color.FromArgb(Red, Green, Blue));
                }

                if (i % 10 == 0)
                {
                    pbDraw.Invalidate();
                    pbDraw.Refresh();
                }
            }
            pbDraw.Refresh();
        UnsavedChanges = true;
        }

        // Гладкость
        public void Effect3()
        {
            bmp = new Bitmap(pbDraw.Image);
            pbDraw.Image = bmp;
            Bitmap tempbmp = new Bitmap(pbDraw.Image);
            int i, j, DX = 1, DY = 1;
            int Red, Green, Blue;

            for (i = DX; i < tempbmp.Height - DX; i++)
            {
                for (j = DY; j < tempbmp.Width - DY; j++)
                {
                    Red = (tempbmp.GetPixel(j - 1, i - 1).R + tempbmp.GetPixel(j - 1, i).R + tempbmp.GetPixel(j - 1, i + 1).R + tempbmp.GetPixel(j, i - 1).R + tempbmp.GetPixel(j, i).R + tempbmp.GetPixel(j, i + 1).R + tempbmp.GetPixel(j + 1, i - 1).R + tempbmp.GetPixel(j + 1, i).R + tempbmp.GetPixel(j + 1, i + 1).R) / 9;
                    Green = (tempbmp.GetPixel(j - 1, i - 1).G + tempbmp.GetPixel(j - 1, i).G + tempbmp.GetPixel(j - 1, i + 1).G + tempbmp.GetPixel(j, i - 1).G + tempbmp.GetPixel(j, i).G + tempbmp.GetPixel(j, i + 1).G + tempbmp.GetPixel(j + 1, i - 1).G + tempbmp.GetPixel(j + 1, i).G + tempbmp.GetPixel(j + 1, i + 1).G) / 9;
                    Blue = (tempbmp.GetPixel(j - 1, i - 1).B + tempbmp.GetPixel(j - 1, i).B + tempbmp.GetPixel(j - 1, i + 1).B + tempbmp.GetPixel(j, i - 1).B + tempbmp.GetPixel(j, i).B + tempbmp.GetPixel(j, i + 1).B + tempbmp.GetPixel(j + 1, i - 1).B + tempbmp.GetPixel(j + 1, i).B + tempbmp.GetPixel(j + 1, i + 1).B) / 9;
                    Red = Math.Min(Math.Max(Red, 0), 255);
                    Green = Math.Min(Math.Max(Green, 0), 255);
                    Blue = Math.Min(Math.Max(Blue, 0), 255); ;
                    bmp.SetPixel(j, i, Color.FromArgb(Red, Green, Blue));
                }

                if (i % 10 == 0)
                {
                    pbDraw.Invalidate();
                    pbDraw.Refresh();
                }
            }
            pbDraw.Refresh();
        UnsavedChanges = true;
        }

        // Вернуться к начальному размеру
        public void Effect4()
        {
            Bitmap Resized = new Bitmap(Orig.Width, Orig.Height);
            Graphics gr = Graphics.FromImage(Resized);
            gr.SmoothingMode = SmoothingMode.HighQuality;
            gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
            gr.PixelOffsetMode = PixelOffsetMode.HighQuality;
            gr.DrawImage(pbDraw.Image, new Rectangle(0, 0, Orig.Width, Orig.Height));
            gr.Dispose();
            pbDraw.Image = Resized;
            panel1.Size = Resized.Size;
            this.Width = panel1.Width + 16;
            this.Height = panel1.Height + 40;
            UnsavedChanges = true;
        }

        // Масштаб 50%
        public void Effect5()
        {
            Bitmap Resized = new Bitmap(pbDraw.Width / 2, pbDraw.Height / 2);
            Graphics gr = Graphics.FromImage(Resized);
            gr.SmoothingMode = SmoothingMode.HighQuality;
            gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
            gr.PixelOffsetMode = PixelOffsetMode.HighQuality;
            gr.DrawImage(pbDraw.Image, new Rectangle(0, 0, pbDraw.Width / 2, pbDraw.Height / 2));
            gr.Dispose();
            pbDraw.Image = Resized;
            panel1.Size = Resized.Size;
            this.Width = panel1.Width + 16;
            this.Height = panel1.Height + 40;
            UnsavedChanges = true;
        }

        // Масштаб 200%
        public void Effect6()
        {
            Bitmap Resized = new Bitmap(pbDraw.Width * 2, pbDraw.Height * 2);
            Graphics gr = Graphics.FromImage(Resized);
            gr.SmoothingMode = SmoothingMode.HighQuality;
            gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
            gr.PixelOffsetMode = PixelOffsetMode.HighQuality;
            gr.DrawImage(pbDraw.Image, new Rectangle(0, 0, pbDraw.Width * 2, pbDraw.Height * 2));
            gr.Dispose();
            pbDraw.Image = Resized;
            panel1.Size = Resized.Size;
            this.Width = panel1.Width + 16;
            this.Height = panel1.Height + 40;
            UnsavedChanges = true;
        }

        // Размытие
        public void Effect7()
        {
            Bitmap bmap = new Bitmap(pbDraw.Image);
            pbDraw.Image = bmap;
            Bitmap tempbmp = new Bitmap(pbDraw.Image);
            Random rnd = new Random();
            int i, j, DX, DY;
            int Red, Green, Blue;
            for (i = 3; i < tempbmp.Height - 3; i++)
                for (j = 3; j < tempbmp.Width - 3; j++)
                {
                    DX = (int)Math.Round(rnd.NextDouble()) * 4 - 2;
                    DY = (int)Math.Round(rnd.NextDouble()) * 4 - 2;
                    Red = tempbmp.GetPixel(j + DX, i + DY).R;
                    Green = tempbmp.GetPixel(j + DX, i + DY).G;
                    Blue = tempbmp.GetPixel(j + DX, i + DY).B;
                    bmap.SetPixel(j, i, Color.FromArgb(Red, Green, Blue));
                }

            if (i % 10 == 0)
            {
                pbDraw.Invalidate();
                pbDraw.Refresh();
            }

            pbDraw.Refresh();
            UnsavedChanges = true;
        }

        // Поворот 90 против часовой
        public void Effect8()
        {
            pbDraw.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            panel1.Size = pbDraw.Image.Size;
            this.Width = panel1.Width + 16;
            this.Height = panel1.Height + 40;
            pbDraw.Refresh();
            UnsavedChanges = true;
        }

        // Поворот 90 по часовой
        public void Effect9()
        {
            pbDraw.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            panel1.Size = pbDraw.Image.Size;
            this.Width = panel1.Width + 16;
            this.Height = panel1.Height + 40;
            pbDraw.Refresh();
            UnsavedChanges = true;
        }

        // Отразить по горизонтали
        public void Effect10()
        {
            pbDraw.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pbDraw.Refresh();
            UnsavedChanges = true;
        }
        
        // Отразить по вертикали
        public void Effect11()
        {
            pbDraw.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);
            pbDraw.Refresh();
            UnsavedChanges = true;
        }

        // Изменение размера формы
        public void FormChild_ResizeEnd(object sender, EventArgs e)
        {
            if (this.Height - 40 > panel1.Height || this.Width - 16 > panel1.Width)
            {
                // Изображение с новым размером
                Bitmap Resized = new Bitmap(this.Width - 16, this.Height - 40);
                Graphics gr = Graphics.FromImage(Resized);
                // Перерисовываем старое изображение
                gr.DrawImage(pbDraw.Image, 0, 0);
                gr.Dispose();
                // Меняем размеры полотна
                pbDraw.Image = Resized;
                panel1.Size = Resized.Size;
                Orig = Resized.Size;
            }
            UnsavedChanges = true;
        }

        public void Redraw()
        {
            pbDraw.Refresh();
        }

        public void BlockPaint()
        {
            this.pbDraw.Paint -= new System.Windows.Forms.PaintEventHandler(this.pbDraw_Paint);
        }

        public void UnBlockPaint()
        {
            this.pbDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.pbDraw_Paint);
        }
        #endregion Эффекты
    }
}