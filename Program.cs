using System;

namespace MKR_2
{
    interface IShape
    {
        string sizeFigure { get; }
        string Type();
        string Area();
    }
    
    class   Square : IShape
    {
        protected double r { get; set; }
        public Square(double r)
        {
            this.r = r;
        }
        public string sizeFigure
        {
            get
            {
                return $"Розмiр сторони: {r}";
            }
        }
        public string Area()
        {
            double s = r * r;
            return $"Площа квадрату = {s.ToString("F")}";
        }
        public string Type()
        {
            return "Тип: квадрат";
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Square[] rectangle = { new Square(3.45), new Square(4), new Square(7.75) };
            foreach (Square str in rectangle)
            {
                Console.WriteLine($"{str.Type()}\n{str.sizeFigure}\n{str.Area()}\n");
            }
        }
    }
}

