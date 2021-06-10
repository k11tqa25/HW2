using System;

namespace Exercise5
{
    public class Box
    {
        private double length;
        private double breadth;
        private double height;
        public double getVolume()
        {
            return length * breadth * height;
        }
        public void setLength(double len)
        {
            length = len;
        }

        public void setBreadth(double bre)
        {
            breadth = bre;
        }

        public void setHeight(double hei)
        {
            height = hei;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            for (int i = 0; i < 3; i++)
            {
                Box b = new Box();
                b.setLength(random.Next(51));
                b.setHeight(random.Next(51));
                b.setBreadth(random.Next(51));
                Console.WriteLine($"Volumn of box{i+1} = {b.getVolume()}");
            }
        }
    }
}
