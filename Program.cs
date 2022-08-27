namespace triangle
{
    class Program
    {
        static bool isItTriangle(double a, double b, double c)
        {
            return a + b > c && a + c > b && c + b > a;
        }

        static double sideLength(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        static bool isEquiTriangle(double a, double b, double c)
        {
            return a == b && b == c & c == a;
        }

        static bool isIsoscelTraingle(double a, double b, double c)
        {
            return a == b || b == c || c == a;
        }

        static bool isRightTriangle(double a, double b, double c)
        {
            var delta = 0.000001;
            bool alphaRightCond = Math.Pow(a, 2) + Math.Pow(b, 2) - Math.Pow(c, 2) <= delta;
            bool betaRightCond = Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2) <= delta;
            bool gammaRightCond = Math.Pow(c, 2) + Math.Pow(c, 2) - Math.Pow(b, 2) <= delta;

            return alphaRightCond || betaRightCond || gammaRightCond;
        }

        static double perimeter(double a, double b, double c)
        {
            return a + b + c;
        }

        static string outputString(bool state)
        {
            return state ? "IS" : "IS NOT";
        }

        static void Main(string[] args)
        {

            Console.WriteLine();
            Console.WriteLine("Enter coordinate x of dot A: ");
            var xA = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate y of dot A: ");
            var yA = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate x of dot B: ");
            var xB = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate y of dot B: ");
            var yB = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate x of dot C: ");
            var xC = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate y of dot C: ");
            var yC = Double.Parse(Console.ReadLine());

            double a = sideLength(xA, yA, xB, yB);
            double b = sideLength(xB, yB, xC, yC);
            double c = sideLength(xC, yC, xA, yA);

            if (isItTriangle(a, b, c))
            {
                Console.WriteLine();
                Console.WriteLine($"Length of AB is: '{a}'");
                Console.WriteLine($"Length of BC is: '{b}'");
                Console.WriteLine($"Length of AC is: '{c}'");
                Console.WriteLine();
                Console.WriteLine($"Triagle {outputString(isEquiTriangle(a, b, c))} 'Equilateral'");
                Console.WriteLine($"Triagle {outputString(isIsoscelTraingle(a, b, c))} 'Isosceles'");
                Console.WriteLine($"Triagle {outputString(isRightTriangle(a, b, c))} 'Right'");
                Console.WriteLine();
                Console.WriteLine($"Perimeter: '{perimeter(a, b, c)}'");
                Console.WriteLine();
                Console.WriteLine("Parity numbers in range from 0 to triangle perimeter:");
                Console.WriteLine();

                for (int i = 0; i <= Convert.ToInt32(Math.Floor(perimeter(a, b, c))); i+=2)
                {
                   Console.WriteLine(i); 
                }
            }
        }
    }
}
