namespace Labb5_OOP
{
    class Triangle
    {
        //field variables
        private float _height;
        private float _width;

        //default constructor with no parameters
        public Triangle()
        {
            _height = 0;
            _width = 0;
        }

        // instance constructor with two parameters
        public Triangle(float height, float width)
        {
            Height = height;
            Width = width;
        }
        // get/set properties prevents Height and Width from being negative numbers.
        // if they are negative, the value will be 0 instead.
        public float Height
        {
            get { return _height; }

            set
            {
                if (value > 0)
                {
                    _height = value;
                }
                else
                {
                    _height = 0;
                }
            }
        }
        public float Width
        {
            get { return _width; }
            set
            {
                if (value > 0)
                {
                    _width = value;
                }
                else
                {
                    _width = 0;
                }
            }
        }
        public void GetAreaTriangle() //method to get the area of a triangle
        {
            float area = (_height * _width) / 2; //how to calculate the area of a triangle

            Console.WriteLine("En triangel med höjden " + _height + "cm och bredden " + _width + "cm har arean: " + Math.Round(area, 1) + "cm².");
        }
    }
}
