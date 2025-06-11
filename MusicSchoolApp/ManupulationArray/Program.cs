namespace ManupulationArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]elements=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string[]command=Console.ReadLine().Split(' ').ToArray();
            while (command[0]!="end")
            {
                switch (command[0])
                {
                    case "exchange":
                        //Pravim masiv sas sashtata dalgina
                        int index=int.Parse(command[1]);
                        int[]tempArray=new int[elements.Length];
                        for (int i = index+1; i < elements.Length; i++)
                        {
                            for (int j = 0; j < elements.Length-(index+1); j++)
                            {
                                tempArray[j] = elements[i];
                            }
                        }
                        Console.WriteLine(string.Join(' ',tempArray));
                        break;
                   
                }

                command = Console.ReadLine().Split(' ').ToArray();
            }
        }
    }
}
