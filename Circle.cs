namespace Labb5_OOP
{
    class Circle
    {
        //field variables
        private double _pi;
        private double _radius;

        //default constructor
        public Circle()
        {
            _pi = Math.PI; // sets _pi as the correct pi-value
            _radius = 0; // _radius = 0 as default if no value is chosen
        }

        // instance constructor with one parameter (int radius)
        public Circle(int radius) 
        {
            _pi = Math.PI;
            Radius = radius;
        }

        // get/set that change value of Radius to 0 if it's a negative number (must be positive).
        public double Radius
        {
            get { return _radius; }
            set
            {
                if (value > 0)
                {
                    _radius = value;
                }
                else
                {
                    _radius = 0;
                }
            }
        }
        //method to get area of a circle
        public void GetAreaCircle()
        {
            double area = _radius * _radius * _pi;
            // Math.Round(area,1) round up the number to one decimal
            Console.WriteLine("Arean av en cirkel med " + _radius + " cm i radie är: " + Math.Round(area, 1) + "cm².");
        }

        //method to get circumference of a circle
        public void GetCircumferenceCircle()
        {
            double circumference = (_radius * 2) * _pi;
            Console.WriteLine("Omkretsen av en cirkel med " + _radius + "cm i radie är: " + Math.Round(circumference, 1) + "cm.");
        }

        //method to get area of a sphere
        public void GetAreaSphere()
        {// Math.Pow() is to calculate the power of, or in this case the square of, _radius.
            double area = 4 * _pi * (Math.Pow(_radius, 2));
            Console.WriteLine("Arean av en sfär med " + _radius + "cm i radie är: " + Math.Round(area, 1) + "cm².");
        }

        //method to get volume of a sphere
        public void GetVolumeSphere()
        {
            double volume = 4 * _pi * (Math.Pow(_radius, 3)) / 3;
            Console.WriteLine("Volymen av en sfär med " + _radius + " cm i radie är: " + Math.Round(volume, 1) + "ml.");
        }
    }
}
