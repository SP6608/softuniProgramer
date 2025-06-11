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
            int index=int.Parse(Console.ReadLine());
            elements=Exchange(elements,index);
            Console.WriteLine("["+string.Join(", ",elements)+"]");
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
