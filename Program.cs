using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    internal class Program
    {
        private static Random ran=new Random();
        public static int[] input(int size,int minval,int maxval) //generating random values for input 
        {
            int[] arr = new int[size];
            for(int i = 0; i < size; i++)
            {
                arr[i] = ran.Next(minval,maxval+1);
            }

            return arr;
        }

        public static void BubbleSort(int[] arr) //creating bubble sort 
        {
            int n = arr.Length;
            bool swap;
            for (int i = 0; i < n - 1; i++)
            {
                swap = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swap = true;

                    }
                }
                if (!swap)
                {
                    break;
                }
            }
        }
        public static void print(int[] arr) // To read the values
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n");
        }
        public static bool Check(int[] arr) // Checking input array is sorted or not
        {
            int n= arr.Length;
            for(int i = 0; i < n-1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    return false;
                }
            }
            return true;
        }
        public static void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }

        public static void SelectionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }
        }
        static void Main(string[] args)
        {
            int size = 500;
            int minval = 1;
            int maxval = 1000;
            int[] arr = input(size,minval,maxval);
            Console.WriteLine("Input for bubble sort before sorting :");
            print(arr);
            Stopwatch sw = new Stopwatch();
            sw.Start();
            BubbleSort(arr);
            sw.Stop();
            Console.WriteLine("After Bubble Sort operation:");
            print(arr);
            Console.WriteLine($"ArraySize {arr.Length} Time taken in bubble sort {sw.Elapsed.TotalMilliseconds} milliSeconds");
            bool Checked =Check(arr);
            Console.WriteLine("Bubble Sort Performed :\t"+Checked);
            
            int[] arr2 = input(size, minval, maxval);
            Console.WriteLine("Input for insertion sort before sorting :");
            print(arr);
            Stopwatch sw1 = new Stopwatch();
            sw1.Start();
            InsertionSort(arr);
            sw1.Stop();
            Console.WriteLine("After insertion Sort operation:");
            print(arr);
            Console.WriteLine($"ArraySize {arr.Length} Time taken in insertion sort {sw.Elapsed.TotalMilliseconds} milliSeconds");

            int[] arr3 = input(size, minval, maxval);
            Console.WriteLine("Input for Selection sort before sorting :");
            print(arr);
            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            InsertionSort(arr);
            sw2.Stop();
            Console.WriteLine("After selection Sort operation:");
            print(arr);
            Console.WriteLine($"ArraySize {arr.Length} Time taken in selection sort {sw.Elapsed.TotalMilliseconds} milliSeconds");
            Console.ReadKey();
        }

        
    }
}
