
namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int n=int.Parse(number);
            for (int i = 1; i <=n; i++) 
            {
                IsTopNum(i.ToString());
            }

        }

        private static void IsTopNum(string number)
        {
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                sum += int.Parse(number[i].ToString());
            }
            bool isOdd = false;
            for (int i = 0; i < number.Length; i++)
            {
                if (int.Parse(number[i].ToString()) % 2 != 0)
                {
                    isOdd = true;
                    break;
                }
            }
            if (isOdd && sum % 8 == 0)
            {
                Console.WriteLine(number);
            }
        }

    }
}
