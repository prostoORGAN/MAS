using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MAS.Lab_2.Lab_2;

namespace MAS.Lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Color[] colors = new Color[] {
            Color.Purple,
            Color.Aqua,
            Color.WhiteSmoke,
            Color.Black,
            Color.Yellow,
            Color.HotPink,
            Color.Orange,
            Color.Khaki,
            Color.Lime,
            Color.Navy,
            Color.Tomato
        };

        private readonly int ImagePointSize = 1;
        private readonly int KernalPointSize = 8;

        private ClassPoint[] images;
        private ClassPoint[] kernalImages;

        private void trackBarImages_Scroll(object sender, EventArgs e)
        {
            labelImages.Text = trackBarImages.Value.ToString();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            images = new ClassPoint[trackBarImages.Value];

            ImagesRand(images, panel.Size.Width, panel.Size.Height);

            Graphics g = panel.CreateGraphics();
            g.Clear(Color.White);
            DrawImages(images, g, ImagePointSize);

            Maximin(out kernalImages, images);

            g.Clear(Color.White);
            DrawImages(images, g, ImagePointSize);
            DrawKernalImages(kernalImages, g, KernalPointSize);
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            if (images != null && kernalImages != null)
            {
                var g = e.Graphics;

                g.Clear(Color.White);
                DrawImages(images, g, ImagePointSize);
            }
        }

        private void DrawImages(ClassPoint[] images, Graphics g, int imageSize)
        {
            for (int i = 0; i < images.Length; i++)
            {
                Pen pen = new Pen(colors[images[i].ClassNum], imageSize);
                g.DrawRectangle(pen, images[i].X, images[i].Y, 1, 1);
            }
        }

        private void DrawKernalImages(ClassPoint[] kernals, Graphics g, int imageSize)
        {
            for (int i = 0; i < kernals.Length; i++)
            {
                Pen pen = new Pen(Color.Red, imageSize);
                g.DrawRectangle(pen, kernals[i].X, kernals[i].Y, 1, 1);
            }
        }

        private void ImagesRand(ClassPoint[] images, int xMax, int yMax)
        {
            Random r = new Random();
            for(int i = 0; i < images.Length; i++)
            {
                images[i] = new ClassPoint();
                images[i].X = r.Next(0, xMax);
                images[i].Y = r.Next(0, yMax);
            }
        }

    }
}
