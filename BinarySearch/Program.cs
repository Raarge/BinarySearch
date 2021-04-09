using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] {1, 5, 0, 34, 3, 9};

            Console.WriteLine("Original Array Order: ");
            foreach (var number in numbers)
            {
               Console.Write(number + " "); 
            }

            Console.WriteLine();


            //prereq for binary is have the array sorted
            Array.Sort(numbers);

            Console.WriteLine("Sorted for Binary Search: ");
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("\n");

            //var index = LinearSearch(numbers, 3);
           // var index = BinarySearch(numbers, 3);
            var index = BinarySearchRecursive(numbers, 3);

            Console.WriteLine("Index where 3 is located: " + index + ". ");

            Console.ReadKey();
        }

        private static int LinearSearch(int[] array, int item)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == item)
                {
                    return i;
                }
            }

            return -1;
        }

        private static int BinarySearch(int[] array, int item)
        {
            int left = 0;
            int right = array.Length - 1;
            var pass = 0;

            Console.WriteLine("Entering Binary Search!");
            Console.Write("\nThe initial left is " + left + " and the initial right is " + right + ". \n");

            while (left <= right)
            {
                pass++;

                var middle = (left + right) / 2;
                Console.Write("Pass #: " + pass + " middle is " + middle + ". ");

                if (array[middle] == item)
                    return middle;

                if (item < array[middle])
                    right = middle - 1;
                else
                {
                    left = middle + 1;
                }
            }

            return -1;
        }

        private static int BinarySearchRecursive(int[] array, int item)
        {
            return BinarySearchRecursive(array, 0, array.Length - 1, item);
        }
        private static int BinarySearchRecursive(int[] array, int left, int right, int item)
        {
            var pass = 0;

            Console.WriteLine("Entering Binary Recursive Search!");
            Console.Write("\nThe initial left is " + left + " and the initial right is " + right + ". \n");

            if (right >= left)
            {
                pass++;

                var middle = left + (right - left) / 2;
                Console.Write("Pass #: " + pass + " middle is " + middle + ". ");

                if (array[middle] == item)
                    return middle;

                if (array[middle] > item)
                    return BinarySearchRecursive(array, left, middle - 1, item);
                else
                    return BinarySearchRecursive(array, middle + 1, right, item);
            }

            return -1;
        }
    }
}
