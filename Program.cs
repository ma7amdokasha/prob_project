using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace probability_project
{
    internal class Program
    {
//Median (1)
        static double FindMedian(int[] myArray)
        {
            Array.Sort(myArray);
            if (myArray.Length % 2 == 0)
            {
                double x = myArray[(myArray.Length / 2) - 1];
                double y = myArray[(myArray.Length / 2)];
                return (x + y) / 2;
            }
            else
            {
                return myArray[(myArray.Length / 2)];
            }
        }


        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4 };

            double m = FindMedian(arr);
            Console.WriteLine("Median: " + m);
            Console.ReadKey();

        }

    }
}



//Median (1)


namespace probability_project
{
    internal class Program
    {
        //Median (1)
        static double FindMedian(int[] myArray)
        {
            Array.Sort(myArray);
            if (myArray.Length % 2 == 0)
            {
                double x = myArray[(myArray.Length / 2) - 1];
                double y = myArray[(myArray.Length / 2)];
                return (x + y) / 2;
            }
            else
            {
                return myArray[(myArray.Length / 2)];
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the number of items: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            Console.WriteLine("Enter the items values:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            double m = FindMedian(arr);
            Console.WriteLine("Median: " + m);
            Console.ReadKey();
        }
    }
}





// Mode (2)

namespace probability_project
{
    internal class Program
    {
        static void PrintMode(int[] arr, int n)
        {
            int max = arr.Max();
            int[] count = new int[max + 1];
            for (int i = 0; i < count.Length; i++)
            {
                count[i] = 0;
            }
            for (int i = 0; i < n; i++)
            {
                count[arr[i]]++;
            }
            int mode = 0;
            int maxCount = 0;
            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] > maxCount)
                {
                    maxCount = count[i];
                    mode = i;
                }
            }
            Console.WriteLine("Mode = " + mode);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the number of items: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter the items values:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            PrintMode(arr, n);
            Console.ReadKey();
        }
    }
}




 Range (3)

namespace probability_project
{
    internal class Program
    {
        static void PrintRange(int[] arr, int n)
        {

            int min = arr.Min();
            int max = arr.Max();
            int range = max - min;
            Console.WriteLine("Range = " + range);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the number of items: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter the items values:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            PrintRange(arr, n);
            Console.ReadKey();
        }
    }
}





 first Quartile (4)

namespace probability_project
{
    internal class Program
    {
  Q1 = (n+1)*1/4
       static void PrintQ1(int[] arr, int n)
        {
            Array.Sort(arr);
            int q1 = 0;

            if (n % 2 == 0)
            {
                q1 = (arr[n / 4 - 1] + arr[n / 4]) / 2;
            }
            else
            {
               q1 = arr[n / 4];
            }

            Console.WriteLine("Q1 = " + q1);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the number of items: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter the items values:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            PrintQ1(arr, n);
           Console.ReadKey();
        }
    }
}





The third Quartile of the values  (5)

namespace probability_project
{
    internal class Program
    {
        static void PrintQ3(int[] arr, int n)
        {
    //      Q3 = (n + 1) * 3 / 4
            Array.Sort(arr);
            int q3 = 0;

            if (n % 2 == 0)
            {
                q3 = (arr[n * 3 / 4 - 1] + arr[n * 3 / 4]) / 2;
            }
            else
            {
                q3 = arr[n * 3 / 4];
            }

            Console.WriteLine("Q3 = " + q3);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the number of items: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter the items values:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            PrintQ3(arr, n);
            Console.ReadKey();
        }
    }
}





The P90 of the values (6)

namespace probability_project
{
    internal class Program
    {
        static void PrintP90(int[] arr, int n)
        {
 The P90 of the values
Size of 20 ×[ ( N + 1 ) ] / 100 th item

            Array.Sort(arr); 
            int p90 = arr[(int)(n * 0.9)]; 

            Console.WriteLine("P90 = " + p90);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the number of items: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter the items values:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            PrintP90(arr, n);
            Console.ReadKey();
        }
    }
}





The interquartile of the values  (7)

namespace probability_project
{
    internal class Program
    {
        static void PrintInterquartileRange(int[] arr, int n)
        {
            //  IQR interquartile

            Array.Sort(arr); 
            //  Q1
            int q1 = 0;
            if (n % 2 == 0) 
            {
                q1 = (arr[n / 4 - 1] + arr[n / 4]) / 2;
            }
            else 
            {
                q1 = arr[n / 4];
            }
            //  Q3
            int q3 = 0;
            if (n % 2 == 0) 
            {
                q3 = (arr[3 * n / 4 - 1] + arr[3 * n / 4]) / 2;
            }
            else 
            {
                q3 = arr[3 * n / 4];
            }
            // IQR
            int iqr = q3 - q1;

            Console.WriteLine("Interquartile Range = " + iqr);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the number of items: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter the items values:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            PrintInterquartileRange(arr, n);
            Console.ReadKey();
        }
    }
}





The boundaries of the outlier region. (8)

namespace probability_project
{
    internal class Program
    {
        static void PrintOutlierBoundaries(int[] arr, int n)
        {
            // The boundaries of the (outlier region) (8)
            Array.Sort(arr); 
            // Q1
            int q1 = 0;
            if (n % 2 == 0) 
            {
                q1 = (arr[n / 4 - 1] + arr[n / 4]) / 2;
            }
            else 
            {
                q1 = arr[n / 4];
            }
            //  Q3
            int q3 = 0;
            if (n % 2 == 0) 
            {
                q3 = (arr[n / 2 + n / 4 - 1] + arr[n / 2 + n / 4]) / 2;
            }
            else 
            {
                q3 = arr[n / 2 + n / 4];
            }
            //  IQR
            int iqr = q3 - q1;
            int lower = q1 - (int)(1.5 * iqr);
            int upper = q3 + (int)(1.5 * iqr);

            Console.WriteLine("Outlier Boundaries: [" + lower + ", " + upper + "]");
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the number of items: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter the items values:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            PrintOutlierBoundaries(arr, n);
            Console.ReadKey();
        }
    }
}





 Determine whether an input value is an outlier or not. (9)

namespace probability_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of items: ");
            int n = int.Parse(Console.ReadLine());

            double[] arr = new double[n];
            Console.WriteLine("Enter the items values:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = double.Parse(Console.ReadLine());
            }

            double lowerBound = arr.Average() - (3 * StdDev(arr));
            double upperBound = arr.Average() + (3 * StdDev(arr));
            Console.WriteLine($"Outlier Boundaries: [{lowerBound}, {upperBound}]");

            Console.Write("Enter a value to check if it is an outlier: ");
            double value = double.Parse(Console.ReadLine());
            if (value < lowerBound || value > upperBound)
            {
                Console.WriteLine($"{value} is an outlier.");
            }
            else
            {
                Console.WriteLine($"{value} is not an outlier.");
            }
        }

        static double StdDev(double[] values)
        {
            double mean = values.Sum() / values.Length;
            double sumOfSquaresOfDifferences = 0.0;
            foreach (double value in values)
            {
                double diff = value - mean;
                sumOfSquaresOfDifferences += diff * diff;
            }
            return Math.Sqrt(sumOfSquaresOfDifferences / values.Length);
        }
   }
}









 Determine whether an input value is an outlier or not. (9)
namespace probability_project
{
    internal class Program
    {
        static bool isOutlier(int[] myArray, int n)
        {
            Array.Sort(myArray);
            int m = myArray.Length;
            int index_of_q1 = (m + 1) * (1 / 4);
            int q1 = myArray[index_of_q1];
            int index_of_q3 = (m * 3 / 4);
            int q3 = myArray[index_of_q3];
            int IQR = q3 - q1;
            double left_limit = (q1) - 1.5 * IQR;
            double right_limit = (q3) + 1.5 * IQR;
            return (n < left_limit || n > right_limit);
        }

        static void Main(string[] args)
        {
            int num = 85;
            int[] arr = { 25, 29, 3, 32, 85, 33, 27, 28 };
            bool result = isOutlier(arr, num);
            Console.WriteLine($"Is the number {num} an outlier value? {result}");
            Console.ReadKey();
        }
    }

}

