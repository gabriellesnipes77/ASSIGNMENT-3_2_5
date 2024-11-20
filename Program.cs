using System.Linq.Expressions;

namespace ASSIGNMENT_3_2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find Index Problem");
            Console.WriteLine();
            Console.WriteLine("How many elements in your array?");
            int arrayLength = Convert.ToInt32(Console.ReadLine());
            int[] inputArray = EnterStringArray(arrayLength);
            Console.WriteLine();
            Console.WriteLine("What is the target value? ");
            int targetValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int indexValue = FindIndexofTarget(inputArray, targetValue);

            Console.WriteLine(indexValue);



            static int[] EnterStringArray(int arrayLength)
            {
                Console.WriteLine("Input an array, one element at a time. Type \"exit\" to finish array entry.");
                int[] inputArray = new int[arrayLength];


                for (int i = 0; i < inputArray.Length; i++)
                {

                    inputArray[i] = Convert.ToInt32(Console.ReadLine());

                }

                Console.WriteLine($"The array you entered is: ");
                foreach (int input in inputArray)
                {
                    Console.Write(input + " ");
                }
                return inputArray;
            }


            static int FindIndexofTarget(int[] inputArray, int targetIndex)
            {
                for (int i = 0; i < inputArray.Length; i++)
                {
                    if (inputArray[i].Equals(targetIndex))
                    {
                        return i;

                    }

                }
                return -1;
            }
        }
    }
}
