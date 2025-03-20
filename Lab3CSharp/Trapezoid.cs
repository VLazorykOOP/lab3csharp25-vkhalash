using System.Drawing;

namespace Lab3CSharp
{
    public class Trapezoid
    {
        private float height, longBase, shortBase;
        private Color color;

        public float Height { get { return height; } set { height = value; } }
        public float LongBase { get { return longBase; } set { longBase = value; } }
        public float ShortBase { get { return shortBase; } set { shortBase = value; } }
        public Color Color { get { return color; } set { color = value; } }

        public Trapezoid(float height, float longBase, float shortBase)
        {
            color = Color.White;
            this.height = height;
            this.longBase = longBase;
            this.shortBase = shortBase;
        }

        public Trapezoid(Color color, float height, float longBase, float shortBase)
        {
            this.color = color;
            this.height = height;
            this.longBase = longBase;
            this.shortBase = shortBase;
        }

        public void Display()
        {
            Console.WriteLine($"Long base length = {longBase}, short base length = {shortBase}, height = {height}");
        }

        public double Perimeter()
        {
            double side = Math.Sqrt(Math.Pow((longBase - shortBase) / 2, 2) + Math.Pow(height, 2));
            return longBase + shortBase + side * 2;
        }

        public double Area()
        {
            return 0.5 * (shortBase + longBase) * height;
        }

        public bool IsSquare()
        {
            return longBase == shortBase && height == longBase;
        }
    }
}
