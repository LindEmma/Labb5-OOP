namespace Labb5_OOP
{
    public class Circle
    {
        //field variables
        private double _pi;
        private int _radius { get; set; }

        //default constructor
        public Circle()
        {
            _pi = Math.PI; // sets _pi as the mathematically correct pi-value
            _radius = 0; // _radius = 0 as default, if no value is chosen
        }

        // instance constructor with one parameter (int radius)
        public Circle(int radius) //constructor
        {
            _pi = Math.PI;
            _radius = radius;
        }

        //method to get area from a circle
        public void GetAreaCircle()
        {
            double area = _radius * _radius * _pi;
            Console.WriteLine("Arean av en cirkel med " + _radius + " cm i radie är: " + Math.Round(area, 1) + "cm²."); // Math.Round(area,1) avrundar talet till 1 decimal
        }

        //method to get circumference of a circle
        public void GetCircumferenceCircle()
        {
            double circumference = (_radius * 2) * _pi;
            Console.WriteLine("Omkretsen av en cirkel med " + _radius + "cm i radie är: " + Math.Round(circumference, 1) + "cm.");
        }

        //method to get area of a sphere
        public void GetAreaSphere()
        {
            double area = 4 * _pi * (Math.Pow(_radius, 2)); // Math.Pow() is to calculate the power of, or in this case the square of, _radius.
            Console.WriteLine("Arean av en sfär med radien " + _radius + "cm är: " + Math.Round(area, 1) + "cm².");
        }

        //method to get volume of a sphere
        public void GetVolumeSphere()
        {
            double volume = 4 * _pi * (Math.Pow(_radius, 3)) / 3;
            Console.WriteLine("Volymen av en sfär med radien " + _radius + " cm är: " + Math.Round(volume, 1) + "ml.");
        }
    }
}
