using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MAS.Lab_2.Lab_1;

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

        private readonly int ImagePointSize = 3;
        private readonly int KernalPointSize = 8;

        private ClassPoint[] images;
        private ClassPoint[] kernalImages;

        private void trackBarClasses_Scroll(object sender, EventArgs e)
        {
            labelClasses.Text = trackBarClasses.Value.ToString();
        }

        private void trackBarImages_Scroll(object sender, EventArgs e)
        {
            labelImages.Text = trackBarImages.Value.ToString();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {


            images = new ClassPoint[trackBarImages.Value];
            kernalImages = new ClassPoint[trackBarClasses.Value];

            ImagesRand(images, panel.Size.Width, panel.Size.Height);
            ImagesRand(kernalImages, panel.Size.Width, panel.Size.Height);

            Graphics g = panel.CreateGraphics();
            g.Clear(Color.White);
            DrawImages(images, kernalImages, g, ImagePointSize, KernalPointSize);

            var stopwatch = Stopwatch.StartNew();

            K_means(kernalImages, images, trackBarClasses.Value);

            stopwatch.Stop();
            lblElapse.Text = "Elapse time: " + stopwatch.Elapsed;

            g.Clear(Color.White);
            DrawImages(images, kernalImages, g, ImagePointSize, KernalPointSize);
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            if (images != null && kernalImages != null)
            {
                var g = e.Graphics;

                g.Clear(Color.White);
                DrawImages(images, kernalImages, g, ImagePointSize, KernalPointSize);
            }
        }

        private void DrawImages(ClassPoint[] images, ClassPoint[] kernals, Graphics g, int imageSize, int kernalSize)
        {
            Pen penKernal = new Pen(Color.Red, kernalSize);
            for (int i = 0; i < kernals.Length; i++)
            {
                g.DrawRectangle(penKernal, kernals[i].X, kernals[i].Y, 1, 1);
            }

            for (int i = 0; i < images.Length; i++)
            {
                Pen pen = new Pen(colors[images[i].ClassNum], imageSize);
                g.DrawRectangle(pen, images[i].X, images[i].Y, 1, 1);
            }

            for (int i = 0; i < kernals.Length; i++)
            {
                g.DrawRectangle(penKernal, kernals[i].X, kernals[i].Y, 1, 1);
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
