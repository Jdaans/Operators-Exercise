namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 40;
            int b = 50;

            int sumAdd = a + b;
            Console.WriteLine(sumAdd);

            int sumSubtract = a - b;
            Console.WriteLine(sumSubtract);

            int sumMultiply = a * b;
            Console.WriteLine(sumMultiply);


            int x = 24;
            int y = 12;

            int quotient = x / y;
            
            int remainder = x % y;

            Console.WriteLine($"{x}/{y} is {quotient} remainder {remainder}");

            double radius = double.Parse(Console.ReadLine());

            AreaOfCircle(radius);

           
        }

        public static double AreaOfCircle(double radius)
        {
           

           
        return Math.PI * Math.Pow(radius, 2);



        }
    }
}
