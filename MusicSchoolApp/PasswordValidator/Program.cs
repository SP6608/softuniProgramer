namespace PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password=Console.ReadLine();
            bool sign = true;
            if (password.Length<6||password.Length>10)
            {
                Console.WriteLine($"Password must be between 6 and 10 characters");
                sign = false;
            }
            int count = 0;
            for (int i = 0; i < password.Length; i++)
            { 
                if (!char.IsLetter(password[i]) && !char.IsDigit(password[i]))
                {
                    Console.WriteLine($"Password must consist only of letters and digits");
                    sign = false;
                    break;
                }
                if (char.IsDigit(password[i]))
                {
                    count++;
                }
            }
            if (count<2)
            {
                Console.WriteLine($"Password must have at least 2 digits");
                sign=false;
            }
            if (sign)
            {
                Console.WriteLine($"Password is valid");
            }
        }
    }
}
