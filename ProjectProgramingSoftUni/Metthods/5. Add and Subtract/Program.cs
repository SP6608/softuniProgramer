
namespace _5._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());  
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int sumNumbers = SumFirstAndSecond(firstNum, secondNum);
            int result = sumNumbers - thirdNum;
            Console.WriteLine(result);
        }

        private static int SumFirstAndSecond(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }
    }
}
