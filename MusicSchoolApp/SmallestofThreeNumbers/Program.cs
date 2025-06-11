namespace SmallestofThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minValue = int.MaxValue;
            for (int i = 1; i <=3; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number<minValue)
                {
                    minValue = number;
                }
            }
            Console.WriteLine(minValue);
        }
    }
}
