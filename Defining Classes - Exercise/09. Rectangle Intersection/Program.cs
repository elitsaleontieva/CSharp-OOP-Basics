using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_12.Rectangle_Intersection
{
    class Rectangle
    {
        private string id;
        private double width;
        private double height;
        private double[] topLeft;

        public Rectangle(string id, double width, double height, double[] topLeft)
        {
            this.id = id;
            this.width = width;
            this.height = height;
            this.topLeft = new double[] { topLeft[0], topLeft[1] };
        }

        public static bool Intersect(Rectangle r1, Rectangle r2)
        {
            bool intersect = false;

            //A.X1 < B.X2: 
            //A.X2 > B.X1: 
            //A.Y1 < B.Y2: 
            //A.Y2 > B.Y1: 


            //2 1
            //Pesho 2 2 0 0
            //Gosho 2 2 0 0
            //Pesho Gosho

            if (Math.Abs(r1.topLeft[0]) < Math.Abs(r2.topLeft[0] + r2.width))
            {
                if (Math.Abs(r1.topLeft[0] + r1.width) >= Math.Abs(r2.topLeft[0]))
                {
                    if (r1.topLeft[1] < Math.Abs((r2.topLeft[1] - r2.height)))
                    {
                        if (Math.Abs(r1.topLeft[1] + r1.height) >= Math.Abs(r2.topLeft[1]))
                        {
                            intersect = true;
                        }
                    }
                }
            }

            return intersect;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //their ID, width, height and coordinates

            int[] param = Console.ReadLine()
                                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                                    .ToArray();
            int recNum = param[0];
            int intersecCheck = param[1];

            Dictionary<string, Rectangle> rectangles = new Dictionary<string, Rectangle>();

            for (int i = 0; i < recNum; i++)
            {
                string[] dateStrings = Console.ReadLine()
                                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                    .ToArray();
                Rectangle rectangle = new Rectangle(dateStrings[0], double.Parse(dateStrings[1]), double.Parse(dateStrings[2]), new double[] { double.Parse(dateStrings[3]), double.Parse(dateStrings[4]) });

                rectangles[dateStrings[0]] = rectangle;
            }

            for (int i = 0; i < intersecCheck; i++)
            {
                string[] recIds = Console.ReadLine()
                                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                    .ToArray();

                if (rectangles.ContainsKey(recIds[0]) && rectangles.ContainsKey(recIds[1]))
                {
                    Console.WriteLine(Rectangle.Intersect(rectangles[recIds[0]], rectangles[recIds[1]]).ToString().ToLower());
                }
            }
        }



    }
}
