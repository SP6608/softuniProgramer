namespace _4._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            bool isValid = true;
            if (text.Length<6||text.Length>10)
            {
                Console.WriteLine($"Password must be between 6 and 10 characters");
                isValid = false;
            }
            int count = 0;
            foreach (char s in text) 
            {
                if (!char.IsLetter(s)&&!char.IsDigit(s))
                {
                    Console.WriteLine($"Password must consist only of letters and digits");
                    isValid= false;
                    break;
                }
                if (char.IsDigit(s))
                {
                    count++;
                }
            }
            if (count<2)
            {
                Console.WriteLine($"Password must have at least 2 digits");
                isValid = false;
            }
            if (isValid) 
            {
                Console.WriteLine($"Password is valid");
            }
        }
    }
}
