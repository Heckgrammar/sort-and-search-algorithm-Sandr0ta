using System.Diagnostics;
using System.Security.Cryptography;

namespace compare_algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random n = new Random();
            Stopwatch sw = new Stopwatch();
            Console.WriteLine("What size would you want your array?");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] ints = CreateArray(size, n);
            menu();


        }
        static int[] CreateArray(int size, Random r)
        {
            int[] numbers = new int[size];
            for (int i = 0; i < numbers.Length; i++)
            { 
                numbers[i] = r.Next(1, 1000);
            }
            return numbers;

        }
        static void menu()
        {
            Console.WriteLine("Algorithm Compresser");
            Console.WriteLine("=============================");
            Console.WriteLine(""

        }
        
        static void BubbleSort(int[] a)
        {
            Console.WriteLine("How many numbers?");
            int length = Convert.ToInt16(Console.ReadLine());
            int[] numbers = new int[length];
            for (int i = 0; i < length; i++)
                numbers[i] = Convert.ToInt16(Console.ReadLine());

            int temp;


            bool swaps = false;

            do
            {
                swaps = false;
                for (int j = 0; j <= numbers.Length - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        temp = numbers[j];

                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                        swaps = true;

                    }
                }
            } while (swaps);

            Console.WriteLine("The array is sorted");
            foreach (int i in numbers)
            {
                Console.WriteLine(i);

            }
        static void Merge(int[] a, int low, int mid, int high)
        {
            int i, j, k;
            int num1 = mid - low + 1;
            int num2 = high - mid;
            int[] L = new int[num1];
            int[] R = new int[num2];
            for (i = 0; i < num1; i++)
            {
                L[i] = a[low + i];
            }
            for (j = 0; j < num2; j++)
            {
                R[j] = a[mid + j + 1];
            }
            i = 0;
            j = 0;
            k = low;
            while (i < num1 && j < num2)
            {
                if (L[i] <= R[j])
                {
                    a[k] = L[i];
                    i++;
                }
                else
                {
                    a[k] = R[j];
                    j++;
                }
                k++;
            }
            while (i < num1)
            {
                a[k] = L[i];
                i++;
                k++;
            }
            while (j < num2)
            {
                a[k] = R[j];
                j++; k++;
            }
        }
        static void MergeSortRecursive(int[] a, int low, int high)
        {
            if (low < high)
            {
                int mid = (low + high) / 2;
                MergeSortRecursive(a, low, mid);
                MergeSortRecursive(a, mid + 1, high);
                Merge(a, low, mid, high);
            }
        }
        static bool LinearSearch(int[] a, int numToFind)
        {
           
;
            int length = a.Length;
            for (int i = 0; i < length; i++)
            {
                if (a[i] == numToFind)
                {
                    Console.WriteLine($"{numToFind} was found at index {i}");
                    return true;
                }
            }
            return false;
        
        }
        
        static bool BinarySearch(int[] a, int numToFind)
        {
                int lower = 0, upper = a.Length - 1, mid;
                while (lower < upper)
                {
                    mid = (lower + upper) / 2;
                    if (a[mid] == numToFind)
                    {
                        Console.WriteLine($"{numToFind} was found at index {mid}");
                        return true;

                    }
                    else if (a[mid] > numToFind)
                    {
                        upper = mid - 1;
                    }
                    else
                    {
                        lower = mid + 1;
                    }


                }
                return false;
        }

            
    }
}
