namespace areaOfCirculi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //area of circuli
            Console.WriteLine("wellcome to area of circuli app ");

            // ask user to enter raduis
            Console.WriteLine("please enter raduis ");
            //read raduis 
            double dRaduis = 0;
            bool isConverted = double.TryParse(Console.ReadLine(), out dRaduis);
            // calc area
            const double pi = 3.14;
            double calcArea = dRaduis * dRaduis * pi;
            // print area
            Console.WriteLine($"area of circuli:{calcArea}");
            Console.WriteLine("\n");
        }
    }
}
