﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS.Lab_2
{
    public static class Lab_1
    {

        public class ClassPoint
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int ClassNum { get; set; }
        }

        public static void K_means(ClassPoint[] kernalImages, ClassPoint[] images, int classCount)
        {
            do
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
                
                var newKernal = FindNewKernel(images, classCount);

                if (newKernal.IsEqual(kernalImages))
                    break;

                newKernal.CopyTo(kernalImages);

            } while (true);
        }

        private static ClassPoint[] FindNewKernel(ClassPoint[] images, int classCount)
        {
            ClassPoint[] newKernals = new ClassPoint[classCount];
            double[] newClassesDist = new double[classCount];

            foreach (var image_1 in images)
            {

                double distSum = 0;

                foreach (var image_2 in images)
                {
                    if (image_2.ClassNum == image_1.ClassNum)
                    {
                        distSum += Euclidian(image_1, image_2);
                    }
                }

                if (newKernals[image_1.ClassNum] == null || newClassesDist[image_1.ClassNum] > distSum)
                {
                    newKernals[image_1.ClassNum] = image_1;
                    newClassesDist[image_1.ClassNum] = distSum;
                }
            }

            return newKernals;
        }

        private static bool IsEqual(this ClassPoint[] a, ClassPoint[] b)
        {
            for (int i = 0; i < a.Length; i++)
                if ((a[i].Y != b[i].Y) || (a[i].X != b[i].X))
                    return false;

            return true;
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
