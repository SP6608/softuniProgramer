
namespace _8._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
           long FirstNum = long.Parse(Console.ReadLine());
            long SecondNum = long.Parse(Console.ReadLine());

            double resultOne = Factoriel(FirstNum); 
            double resultTwo = Factoriel(SecondNum);
            Console.WriteLine($"{resultOne / resultTwo:F2}");
        }

        private static double Factoriel(long firstNum)
        {
            if (firstNum == 1 || firstNum == 0)
            {
                return 1;
            }
            return firstNum * Factoriel(firstNum - 1);

        }
    }
}
