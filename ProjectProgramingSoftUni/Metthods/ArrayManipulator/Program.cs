using System.ComponentModel.DataAnnotations;
using System.Security.Authentication;

namespace ArrayManipulator
{
    public class Program
    {/*
      [1, 2, 3, 4, 5] 
      [4, 5, 1, 2, 3]
      */
        static void Main()
        {
            int[]elements=Console.ReadLine().Split().Select(int.Parse).ToArray();
            var command = Console.ReadLine().Split();
            while (command[0]!="end")
            {
                switch (command[0])
                {
                    case "exchange":
                        int index=int.Parse(command[1]);
                        elements=Exchange(elements,index);
                        break;
                    case "max":
                        string type=command[1];
                        MaxEventOdd(elements,type);
                        break;
                }
                command = Console.ReadLine().Split();
            }
        }

        static void MaxEventOdd(int[]numbers,string type)
        {
            var numbersOdd=numbers.Where(x => x%2!=0).ToArray();
            var numbersEven=numbers.Where(x=>x%2==0).ToArray();
            if (numbersOdd.Length==0)
            {
                Console.WriteLine("No matches");
                return;
            }
            if (numbersEven.Length == 0)
            {
                Console.WriteLine("No matches");
                return;
            }
            
        }

        static int[] Exchange(int[]elements,int index)
        {
            //Допълнителна проверка
            if (index<0||index>elements.Length-1)
            {
                Console.WriteLine("Invalid index!");
                return elements;
            }
            int[] copyArray = new int[elements.Length];
            int tempIndexFirst = 0;
            for (int i = index+1; i < elements.Length; i++)
            {
                copyArray[tempIndexFirst] = elements[i];
                tempIndexFirst++;
            }
            int tempIndexSecond =0;
            for (int i = tempIndexFirst; i < elements.Length; i++)
            {
                copyArray[i] = elements[tempIndexSecond];
                tempIndexSecond++;
            }
            return copyArray;
        }//end1
    }
}
