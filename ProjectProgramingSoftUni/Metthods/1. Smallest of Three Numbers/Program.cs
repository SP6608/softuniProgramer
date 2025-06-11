namespace _1._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minNumber=int.MaxValue;
            for (int i = 1; i <=3; i++)
            {
                int n = int.Parse(Console.ReadLine());
                if (n < minNumber)
                {
                    minNumber = n;
                }
            }
            Console.WriteLine(minNumber);
        }
    }
}
