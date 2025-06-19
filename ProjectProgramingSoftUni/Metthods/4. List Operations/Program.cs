namespace _4._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var elements = Console.ReadLine().Split().Select(int.Parse).ToList();
            var command = Console.ReadLine().Split().ToList();
            int number;int index;int count;string direction;
            while (command[0]!= "End")
            {
                switch (command[0])
                {
                    case "Add":
                        number=int.Parse(command[1]);
                        elements.Add(number);
                        break;
                    case "Insert":
                        number=int.Parse(command[1]);
                        index=int.Parse(command[2]);
                        if (index < 0 || index > elements.Count - 1)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else { elements.Insert(index, number); }
                        break;
                    case "Remove":
                        index=int.Parse(command[1]);
                        if (index < 0 || index > elements.Count - 1)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else { elements.RemoveAt(index); }
                        break;
                    case "Shift":
                        direction = command[1];
                        count = int.Parse(command[2]);
                        if (direction=="left")
                        {
                            for (int i = 1; i <=count; i++)
                            {
                                int element = elements[0];
                                elements.RemoveAt(0);
                                elements.Add(element);
                            }
                        }
                        if (direction=="right")
                        {
                            for (int i = 1; i <=count; i++)
                            {
                                int element = elements[elements.Count - 1];
                                elements.RemoveAt(elements.Count - 1);
                                elements.Insert(0, element);
                            }
                        }

                        break;
                }
                command = Console.ReadLine().Split().ToList();
            }//end while
            Console.WriteLine(string.Join(' ',elements));
        }
    }
}
