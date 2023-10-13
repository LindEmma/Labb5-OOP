//Emma Lind, Edugrade .NET23

namespace Labb5_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // instance of class Circle/ creates object circle1 
            Circle circle1 = new Circle(5); //int-value 5 in parameter (the radius of the circle)
            circle1.GetAreaCircle(); //calls for GetAreaCircle method and implements it on circle1

            Console.WriteLine();

            Circle circle2 = new Circle(6); //circle2 has a radius of 6 (cm)
            circle2.GetAreaCircle();

            circle2.GetCircumferenceCircle();
            Console.WriteLine();

            circle2.GetVolumeSphere();

            circle2.GetAreaSphere();
            Console.WriteLine();
            
            Triangle triangle1 = new Triangle(5.75f, 7.5f); // triangle1 height: 5,75 cm, and width: 7,5 cm
            triangle1.GetAreaTriangle();
        }
    }
}