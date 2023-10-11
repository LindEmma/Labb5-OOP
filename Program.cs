//Emma Lind, Edugrade .NET23

namespace Labb5_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(5); //creates object circle1, gives it int-value 5 (the radius of the circle)
            circle1.GetAreaCircle(); //calls for GetAreaCircle method and implements it on circle1

            Console.WriteLine();

            Circle circle2 = new Circle(6); //circle2 has a radius of 6 (cm)
            circle2.GetAreaCircle();

            circle2.GetCircumferenceCircle();

            circle2.GetVolumeSphere();

            circle2.GetAreaSphere();
            Console.WriteLine();

            Triangle triangle1 = new Triangle(5, 7); // triangle1 has the height of 5 (cm) and width of 7 (cm)
            triangle1.GetAreaTriangle();
        }
    }
}