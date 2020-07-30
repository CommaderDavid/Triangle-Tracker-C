namespace TriangleTracker.Models
{
    public class Triangle
    {
        // properties, constructors, methods, etc. go here
        // propteries side1, side2, side3
        public int Side1 { get; set; }
        public int Side2 { get; set; }
        public int Side3 { get; set; }

        // constructor
        public Triangle(int side1, int side2, int side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        // methods
        public string GetTriangleType()
        {
            if (Side1 == Side2 && Side2 == Side3)
            {
                return "Your triangle is an Equilateral triangle";
            }

            else if (Side1 == Side2 || Side2 == Side3)
            {
                return "Your Triangle is an Isosceles triangle";
            }

            else
            {
                return "That is not a Triangle";
            }
        }

    }
}