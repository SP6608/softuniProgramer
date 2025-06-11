using System;
using System.Linq;
using System.Collections.Generic;

namespace ArrayManupulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] commandParts = input.Split();
                string command = commandParts[0];

                switch (command)
                {
                    case "exchange":
                        int index = int.Parse(commandParts[1]);
                        elements = Exchange(elements, index);
                        break;

                    case "max":
                        string maxType = commandParts[1];
                        int maxIndex = MaxEvenOdd(elements, maxType);
                        if (maxIndex != -1)
                        {
                            Console.WriteLine(maxIndex);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                        break;

                    case "min":
                        string minType = commandParts[1];
                        int minIndex = MinEvenOdd(elements, minType);
                        if (minIndex != -1)
                        {
                            Console.WriteLine(minIndex);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                        break;

                    case "first":
                        int countFirst = int.Parse(commandParts[1]);
                        string typeFirst = commandParts[2];
                        if (countFirst > elements.Length)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            var firstResult = GetFirst(elements, countFirst, typeFirst);
                            Console.WriteLine("[" + string.Join(", ", firstResult) + "]");
                        }
                        break;

                    case "last":
                        int countLast = int.Parse(commandParts[1]);
                        string typeLast = commandParts[2];
                        if (countLast > elements.Length)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            var lastResult = GetLast(elements, countLast, typeLast);
                            Console.WriteLine("[" + string.Join(", ", lastResult) + "]");
                        }
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("[" + string.Join(", ", elements) + "]");
        }

        private static int[] Exchange(int[] elements, int index)
        {
            if (index < 0 || index >= elements.Length)
            {
                Console.WriteLine("Invalid index");
                return elements;
            }

            int[] tempArray = new int[elements.Length];
            int tempIndex = 0;

            for (int i = index + 1; i < elements.Length; i++)
            {
                tempArray[tempIndex++] = elements[i];
            }

            for (int i = 0; i <= index; i++)
            {
                tempArray[tempIndex++] = elements[i];
            }

            return tempArray;
        }

        private static int MaxEvenOdd(int[] elements, string type)
        {
            int searchIndex = -1;
            int max = int.MinValue;

            for (int i = 0; i < elements.Length; i++)
            {
                bool isMatch = (type == "even" && elements[i] % 2 == 0) ||
                               (type == "odd" && elements[i] % 2 != 0);

                if (isMatch && elements[i] >= max)
                {
                    max = elements[i];
                    searchIndex = i;
                }
            }

            return searchIndex;
        }

        private static int MinEvenOdd(int[] elements, string type)
        {
            int searchIndex = -1;
            int min = int.MaxValue;

            for (int i = 0; i < elements.Length; i++)
            {
                bool isMatch = (type == "even" && elements[i] % 2 == 0) ||
                               (type == "odd" && elements[i] % 2 != 0);

                if (isMatch && elements[i] <= min)
                {
                    min = elements[i];
                    searchIndex = i;
                }
            }

            return searchIndex;
        }

        private static List<int> GetFirst(int[] elements, int count, string type)
        {
            List<int> result = new List<int>();

            foreach (int element in elements)
            {
                if ((type == "even" && element % 2 == 0) ||
                    (type == "odd" && element % 2 != 0))
                {
                    result.Add(element);
                    if (result.Count == count)
                    {
                        break;
                    }
                }
            }

            return result;
        }

        private static List<int> GetLast(int[] elements, int count, string type)
        {
            List<int> result = new List<int>();

            for (int i = elements.Length - 1; i >= 0; i--)
            {
                if ((type == "even" && elements[i] % 2 == 0) ||
                    (type == "odd" && elements[i] % 2 != 0))
                {
                    result.Add(elements[i]);
                    if (result.Count == count)
                    {
                        break;
                    }
                }
            }

            result.Reverse();
            return result;
        }
    }
}
