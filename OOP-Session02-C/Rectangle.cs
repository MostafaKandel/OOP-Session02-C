using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session02_C
{
    internal struct Rectangle
    {
        // Attributes
        private double width;
        private double height;

        // Properties
        public double Width
        {
            get { return width; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Width must be greater than zero.");
                width = value;
            }
        }
        public double Height
        {
            get { return height; }
            set
            {
                if (value >=0)
                    height = value;
                else
                    Console.WriteLine("Height must be greater than zero.");
            }
        }
        
        // Methods

        // Read-only property
        public double Area
        {
            get { return width * height; }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Rectangle: Width = {width}, Height = {height}, Area = {Area}");
        }
    }
}
