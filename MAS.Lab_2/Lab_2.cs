using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS.Lab_2
{
    public static class Lab_2
    {

        public class ClassPoint
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int ClassNum { get; set; }
        }

        public static void Maximin(out ClassPoint[] kernalImages, ClassPoint[] images)
        {
            FindFirstKernals(out kernalImages, images);

            ClassPoint classesMaxImage;
            do
            {
                ClassifyImages(kernalImages, images);

                classesMaxImage = FindClassesMaxImage(kernalImages, images);

            } while (CheckIfNewKernal(ref kernalImages, classesMaxImage));

        }

        private static bool CheckIfNewKernal(ref ClassPoint[] kernalImages, ClassPoint newKernal)
        {
            double newKernalDist = Euclidian(newKernal, kernalImages[newKernal.ClassNum]);

            double kernalDistsSum = 0;

            for (int i = 0; i < kernalImages.Length; i++)
            {
                for (int j = i + 1; j < kernalImages.Length; j++)
                {
                    kernalDistsSum += Euclidian(kernalImages[i], kernalImages[j]);
                }
            }

            double midAr = kernalDistsSum / kernalImages.Length;

            if (newKernalDist > midAr / 2)
            {
                ClassPoint[] oldKernals = kernalImages;
                kernalImages = new ClassPoint[kernalImages.Length + 1];

                oldKernals.CopyTo(kernalImages);
                kernalImages[kernalImages.Length - 1] = newKernal;

                return true;
            }

            return false;
        }

        private static ClassPoint FindClassesMaxImage(ClassPoint[] kernalImages, ClassPoint[] images)
        {
            ClassPoint classesMaxImage = null;
            double maxDist = 0;

            foreach (var image in images)
            {

                double newDist = Euclidian(image, kernalImages[image.ClassNum]);
                if (classesMaxImage == null || maxDist < newDist)
                {
                    classesMaxImage = image;
                    maxDist = newDist;
                }
            }

            return classesMaxImage;
        }

        private static void ClassifyImages(ClassPoint[] kernalImages, ClassPoint[] images)
        {
            for (int i = 0; i < images.Length; i++)
            {
                double dist = 0;

                for (int j = 0; j < kernalImages.Length; j++)
                {
                    double newDist = Euclidian(images[i], kernalImages[j]);
                    if (j == 0 || newDist < dist)
                    {
                        images[i].ClassNum = j;
                        dist = newDist;
                    }
                }

            }
        }

        private static void FindFirstKernals(out ClassPoint[] kernalImages, ClassPoint[] images)
        {
            kernalImages = new ClassPoint[2];

            Random random = new Random();
            kernalImages[0] = images[random.Next(0, images.Length)];

            double maxDist = 0;

            foreach (var image in images)
            {
                double newDist = Euclidian(image, kernalImages[0]);

                if(newDist > maxDist)
                {
                    kernalImages[1] = image;
                    maxDist = newDist;
                }
            }
        }
        
        private static void CopyTo(this ClassPoint[] a, ClassPoint[] b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = a[i];
            }
        }

        private static double Euclidian(ClassPoint a, ClassPoint b)
        {
            return Math.Sqrt(Math.Pow((a.X - b.X), 2) + Math.Pow((a.Y - b.Y), 2));
        }
    }
}
