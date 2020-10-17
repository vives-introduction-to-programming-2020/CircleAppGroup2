using System;

namespace CircleAppGroup2
{
    class Program
    {
        public static double RequestRadius()
        {
            Console.Write("Please enter the circle radius: ");
            return Convert.ToDouble(Console.ReadLine());
        }

        public static double RequestHeight()
        {
            Console.Write("Please enter the height of the cilinder: ");
            return Convert.ToDouble(Console.ReadLine());
        }

        public static double CalculateArea(double radius)
        {
            return radius * radius * Math.PI;
        }

        public static void OutputResult(double radius, double area, double volume)
        {
            Console.WriteLine("For a cilinder with a radius of "
                + radius + " the area is " + area + " and the volume is "
                + volume);
        }

        public static double CalculateVolume(double radius, double height)
        {
            return CalculateArea(radius) * height;
        }

        static void Main(string[] args)
        {
            // Step 1 - Request Radius
            double radius = RequestRadius();

            // Step 2 - Request height
            double height = RequestHeight();

            // Step 3 - Calculate Area
            double area = CalculateArea(radius);

            // Step 4 - Calculate Cilinder Volume
            double volume = CalculateVolume(radius, height);

            // CalculateVolume(area, height); ?
            //      << Verplicht gebruiker eerst CalculateArea() aan te roepen
            // OF:
            // CalculateVolume(radius, height); ? <<== VOORKEUR

            // Step 5 - Show result to user
            OutputResult(radius, area, volume);
        }
    }
}
