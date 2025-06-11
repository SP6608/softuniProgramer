




namespace AddandSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first=int.Parse(Console.ReadLine());
            int second=int.Parse(Console.ReadLine());
            int third=int.Parse(Console.ReadLine());
            int secondCalculate=CalculateDiv(first,second,third);
            Console.WriteLine(secondCalculate);
        }

        private static int CalculateDiv(int first, int second, int third)
        {
            return CalculateAdd(first, second) - third;
        }
        private static int CalculateAdd(int first, int second)
        {
           return first + second;
        }
        
    }
}
