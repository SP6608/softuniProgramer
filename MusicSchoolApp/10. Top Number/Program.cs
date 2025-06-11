
using System.Data;

namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int count=int.Parse(number);
            for (int i = 0; i <count; i++)
            {
                if (TopNumber(i.ToString())==true)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool TopNumber(string number)
        {
            int sumDigit = number.Sum(x => int.Parse(x.ToString()));
            bool searchDigit = false;
            foreach (var item in number)
            {
                if (int.Parse(item.ToString())%2!=0)
                {
                    searchDigit = true;
                    break;
                }
            }
            if (searchDigit==true&&sumDigit%8==0)
            {
                return true;
            }
            return false;
        }
    }
}
