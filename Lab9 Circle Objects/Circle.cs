using System;
using System.Xml.Linq;

namespace Lab9_Circle_Objects
{
    public class Circle
    {
        //properties
        public double Radius { get; set; }

        //constructor
        public Circle(double _radius)
        {
            Radius = _radius;
        }

        //default
        public Circle()
        {
            Radius = 0;
        }

        //methods
        public double CalculateCircumfrence()
        {
            double circumfrence = 2 * Math.PI * Radius;
            return circumfrence;
        }

        public string CalculateFormattedCircumfrence()
        {
            return FormatNumber(CalculateCircumfrence());
        }
        public double CalculateArea()
        {
            double area = Radius * Radius * Math.PI;
            return area;
        }
        public string CalculateFormattedArea()
        {
            return FormatNumber(CalculateArea());
        }
        private string FormatNumber(double x)
        {
            string formattedArea = Math.Round(x, 2).ToString();
            return formattedArea;
        }
    }
}




       