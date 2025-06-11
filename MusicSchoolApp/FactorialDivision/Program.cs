namespace FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double first=double.Parse(Console.ReadLine());
            double second=double.Parse(Console.ReadLine());
            Console.WriteLine($"{(Factoriel(first)/Factoriel(second)):f2}");
        }
        static double Factoriel(double number)
        {
            if (number == 0||number==1) 
            {
                return 1;
            }
            return number*Factoriel(number-1);
        }
    }
}
