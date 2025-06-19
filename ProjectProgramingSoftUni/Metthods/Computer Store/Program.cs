namespace Computer_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double sumPrice = 0.0;
            double taxes = 0.0;
            double price = 0.0;
            while (true)
            {
                if (command=="special")
                {
                    if (sumPrice==0)
                    {
                        Console.WriteLine("Invalid order!");
                        return;
                    }
                    taxes = sumPrice * 0.20;
                    Console.WriteLine($"Congratulations you've just bought a new computer!");
                    Console.WriteLine($"Price without taxes: {(sumPrice):f2}$");
                    Console.WriteLine($"Taxes: {taxes:f2}$");
                    Console.WriteLine("-----------");
                    Console.WriteLine($"Total price: {(taxes + sumPrice)*0.90:f2}$");
                    break;
                }
                else if (command== "regular")
                {
                    if (sumPrice == 0)
                    {
                        Console.WriteLine("Invalid order!");
                        return;
                    }
                    taxes = sumPrice * 0.20;
                    Console.WriteLine($"Congratulations you've just bought a new computer!");
                    Console.WriteLine($"Price without taxes: {(sumPrice):f2}$");
                    Console.WriteLine($"Taxes: {taxes:f2}$");
                    Console.WriteLine("-----------");
                    Console.WriteLine($"Total price: {(taxes + sumPrice):f2}$");
                    break;
                }
                price=double.Parse(command);
                if (price <= 0)
                {
                    Console.WriteLine("Invalid price!");
                   
                }
                else { sumPrice += price; }

                command = Console.ReadLine();
            }
            
        }
    }
}
