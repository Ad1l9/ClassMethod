using ClassMethod.Models;

namespace ClassMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TASK 1
            //Student student = new Student("Adil", "Nasirli", "681s1", 94);
            //student.GetInfo();
            //student.CheckGraduation();
            //student.GetDiplomDeg();

            // TASK 2 Dersde yazilib

            // TASK 3
            //string text = "";
            //var arr = FillArray(text);
            //ShowArray(arr);

            // TASK 4 
            //string text = Console.ReadLine();

            //Console.Write(Trim(text));

            //Console.Write(TrimStart(text));

            //Console.Write(TrimEnd(text));

            // TASK 5
            //Console.WriteLine("arrayin uzunlugunu daxil edin");
            //int n = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Fill array 1");
            //int[,] nums1 = FillArray(n);
            //Console.WriteLine("Fill array 1");
            //int[,] nums2 = FillArray(n);

            //Console.WriteLine("Array 1");
            //ShowArray(nums1, n);
            //Console.WriteLine("Array 2");
            //ShowArray(nums2, n);

            //var sum = Sum(nums1, nums2, n);
            //Console.WriteLine("arraylarin cemi");
            //ShowArray(sum, n);

        }

        // TASK 3
        public static string[] FillArray(string text)
        {
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                    count++;
            }
            string[] arr = new string[count + 1];

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < text.Length; j++)
                {
                    if (text[j] != ' ')
                        arr[i] += text[j];
                    else i++;
                }
            }
            return arr;
        }
        public static void ShowArray(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        // TASK 4
        public static string Trim(string text)
        {
            string result = "";
            TrimStart(text);
            TrimEnd(text);
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ')
                    result += text[i];
            }
            return result;
        }
        public static string TrimEnd(string text)
        {
            string result = "";
            int endIndex = text.Length - 1;

            while (endIndex >= 0 && text[endIndex] == ' ')
            {
                endIndex--;
            }

            for (int i = 0; i < endIndex; i++)
            {
                result += text[i];

            }
            return result;
        }
        public static string TrimStart(string text)
        {
            string result = "";
            int startIndex = 0;

            while (startIndex < text.Length && text[startIndex] == ' ')
            {
                startIndex++;
            }

            for (int i = startIndex; i < text.Length; i++)
            {
                result += text[i];

            }
            return result;
        }

        // TASK 5
        public static int[,] FillArray(int n)
        {
            int[,] nums = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    nums[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return nums;
        }
        public static void ShowArray(int[,] arr, int n)
        {
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static int[,] Sum(int[,] arr1, int[,] arr2, int n)
        {
            int[,] nums = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    nums[i, j] = arr1[i, j] + arr2[i, j];
                }
            }
            return nums;
        }
    }
}