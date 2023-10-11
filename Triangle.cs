using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5_OOP
{
    internal class Triangle
    {
        //field variables
        private int _height { get; set; }
        private int _width { get; set; }

        //default constructor
        public Triangle()
        {
            _height = 0;
            _width = 0;
        }

        // instance constructor with two parameters
        public Triangle(int height, int width) 
        {
            _height = height;
            _width = width;
        }
        public void GetAreaTriangle() //method to get the area of a triangle
        {
            float area = (_height * _width) / 2; //how to calculate the area of a triangle

            Console.WriteLine("En triangel med höjden " + _height + "cm och bredden " + _width + "cm har arean: " + Math.Round(area, 1) + "cm².");
        }
    }
}
