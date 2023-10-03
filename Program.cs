//Emma Lind, Edugrade .NET23

namespace Labb5_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(5); //creates object circle1, gives it int-value 5 (the radius of the circle)
            circle1.GetArea(); //calls for GetArea method and implements it on circle1

            Circle circle2 = new Circle(6);

            circle2.GetArea();

            circle2.GetCircumference();

            circle2.GetVolumeOfSphere();

            circle2.GetAreaOfSphere();

            Triangle triangel = new Triangle(5, 7);
            triangel.GetTriangleArea();
        }
    }
    class Circle
    {
        double _pi = Math.PI; //field
        int _Radius;

        public Circle(int radius) //constructor
        {
            _pi = Math.PI;
            _Radius = radius;

        }
        public void GetArea() //method to get area from a circle
        {
            double area = _Radius * _Radius * _pi;
            Console.WriteLine("Arean av en cirkel med " + _Radius + " cm i radie är: " + Math.Round(area,1) + "cm²."); //Math.Round(area,1) avrundar talet till 1 decimal
        }

        public void GetCircumference() //method to get circumference of a circle
        {
            double circumference = (_Radius * 2) * _pi;
            Console.WriteLine("Omkretsen av cirkel med " + _Radius + "cm i radie är: " + Math.Round(circumference,1) + "cm².");
        }

        public void GetAreaOfSphere() //method to get area of a sphere
        {
            double area = 4 * _pi * (Math.Pow(_Radius,2));
            Console.WriteLine("Arean av en sfär med radien " + _Radius + "cm är: " + Math.Round(area,1));
        }

        public void GetVolumeOfSphere() //method to get volume of a sphere
        {
            double volume = 4 * _pi * (Math.Pow(_Radius,3)) / 3;
            Console.WriteLine("Volymen av en sfär med radien " + _Radius + " cm är: " + Math.Round(volume,1));
        }
    }

    class Triangle
    {
        //field variables
        int _height;
        int _width;

        public Triangle(int height, int width) //constructor
        {
            _height = height;
            _width = width;
        }
        public void GetTriangleArea() //method to get area of a triangle
        {
            float area = (_height * _width) / 2; //how to calculate area of triangle
           
            Console.WriteLine("En triangel med höjden " + _height + "cm och bredden " + _width + "cm har arean: " + Math.Round(area,1) + "cm².");
        }



    }


}