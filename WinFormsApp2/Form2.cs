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

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void coef_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '-')
                e.Handled = true;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(coef_a.Text);
            double b = Convert.ToDouble(coef_b.Text);
            double c = Convert.ToDouble(coef_c.Text);
            double temp = (b * b - 4 * a * c);
            if (temp < 0)
                await Task.Run(() => MessageBox.Show("Дискриминант меньше нуля. Нет корней в зоне действительных чисел"));
            else if (temp == 0)
                await Task.Run(() => MessageBox.Show($"D = {temp} ; Значит один корень\nx = {(-1 * b) / 2 * a}"));
            else
                await Task.Run(() => MessageBox.Show($"D = {temp}\n" +
                                               $"x1 = {(-1 * (b + Math.Pow(temp, 0.5))) / 2 * a}\n" +
                                             $"x2 = {(-1 * (b - Math.Pow(temp, 0.5))) / 2 * a}\n",
                                           "Решатель квадратных уравнений"));

        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            coef_a.ResetText();
            coef_b.ResetText();
            coef_c.ResetText();
        }

        private async void About_btn_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>MessageBox.Show(
                "ax^2 + bx + c = 0\n\n" +
                "D = b^2 - 4ac\n\n" +
                "        -b - D^0.5\n" +
                "x1 = ------------\n" +
                "            2a\n\n" +
                "        -b + D^0.5\n" +
                "x2 = -------------\n" +
                "            2a\n\n\n" +
                "Примечание: D^0.5 это корень! Степень числа 0.5 = арифметическому корню!"
                ,"Квадратное уравнение"));
        }
    }

    public static class HighDpiHelper
    {
        public static void AdjustControlImagesDpiScale(Control container)
        {
            var dpiScale = GetDpiScale(container).Value;
            if (CloseToOne(dpiScale))
                return;

            AdjustControlImagesDpiScale(container.Controls, dpiScale);
        }

        private static void AdjustButtonImageDpiScale(ButtonBase button, float dpiScale)
        {
            var image = button.Image;
            if (image == null)
                return;

            button.Image = ScaleImage(image, dpiScale);
        }

        private static void AdjustControlImagesDpiScale(Control.ControlCollection controls, float dpiScale)
        {
            foreach (Control control in controls)
            {
                var button = control as ButtonBase;
                if (button != null)
                    AdjustButtonImageDpiScale(button, dpiScale);
                else
                {
                    var pictureBox = control as PictureBox;
                    if (pictureBox != null)
                        AdjustPictureBoxDpiScale(pictureBox, dpiScale);
                }

                AdjustControlImagesDpiScale(control.Controls, dpiScale);
            }
        }

        private static void AdjustPictureBoxDpiScale(PictureBox pictureBox, float dpiScale)
        {
            var image = pictureBox.Image;
            if (image == null)
                return;

            if (pictureBox.SizeMode == PictureBoxSizeMode.CenterImage)
                pictureBox.Image = ScaleImage(pictureBox.Image, dpiScale);
        }

        private static bool CloseToOne(float dpiScale)
        {
            return Math.Abs(dpiScale - 1) < 0.001;
        }

        private static Lazy<float> GetDpiScale(Control control)
        {
            return new Lazy<float>(() =>
            {
                using (var graphics = control.CreateGraphics())
                    return graphics.DpiX / 96.0f;
            });
        }

        private static Image ScaleImage(Image image, float dpiScale)
        {
            var newSize = ScaleSize(image.Size, dpiScale);
            var newBitmap = new Bitmap(newSize.Width, newSize.Height);

            using (var g = Graphics.FromImage(newBitmap))
            {
                // According to this blog post http://blogs.msdn.com/b/visualstudio/archive/2014/03/19/improving-high-dpi-support-for-visual-studio-2013.aspx
                // NearestNeighbor is more adapted for 200% and 200%+ DPI

                var interpolationMode = InterpolationMode.HighQualityBicubic;
                if (dpiScale >= 2.0f)
                    interpolationMode = InterpolationMode.NearestNeighbor;

                g.InterpolationMode = interpolationMode;
                g.DrawImage(image, new Rectangle(new Point(), newSize));
            }

            return newBitmap;
        }

        private static Size ScaleSize(Size size, float scale)
        {
            return new Size((int)(size.Width * scale), (int)(size.Height * scale));
        }
    }
}
