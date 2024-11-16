using System.ComponentModel.Design;
using System.Transactions;

namespace Glenn_Lab_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of columns: ");
            int columns = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, columns];
            int cells = rows * columns;
            Console.WriteLine();

            int[] cellCount = GetAllNumbers(cells);
            int[] cellCountRnd = RandomizeNumbers(cellCount);
           
            Console.WriteLine("Matrix after filled with random values: ");
            int k = 0;
            while (k < cells)
            {
                for (int m = 0; m < rows; m++)
                {
                    for (int n = 0; n < columns; n++)
                    {
                        matrix[m, n] = cellCountRnd[k];
                        Console.Write("{0, -6}", matrix[m, n]);
                        k++;
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine();

            Console.WriteLine("Matrix after row exchanges based on the first column: ");
            List<int> firstColValues = new List<int>();
            for (int a = 0; a < cells; a++)
            {
                if (a % columns == 0)
                {
                    firstColValues.Add(cellCountRnd[a]);
                }
            }
            ExchangeRowIndice(firstColValues.ToArray(), out int[] newRowIndice);
            int[] newRowValues; // Unlike int[] newRowIndice, this array is used in a loop and hence needs to be initialized first.
            for (int x = 0; x < newRowIndice.Length; x++)
            {
                ExchangeRowValues(columns, newRowIndice[x], cellCountRnd, out newRowValues);
                Console.WriteLine();
            }
        }
        static int[] GetAllNumbers(int number)
        {
            int[] numberArr = new int[number];
            for (int i = 0; i < number; i++)
            {
                numberArr[i] = i;
            }
            return numberArr;
        }
        static int[] RandomizeNumbers (int[] numbers)
        {
            int[] numbersCopy = new int[numbers.Length];
            Array.Copy(numbers, numbersCopy, numbers.Length);
            Random rnd = new Random();
            for (int j = 0; j < numbersCopy.Length; j++)
            {
                int lot = rnd.Next(j, numbersCopy.Length);
                int temp = numbersCopy[j];
                numbersCopy[j] = numbersCopy[lot];
                numbersCopy[lot] = temp;
            }
            return numbersCopy;
        }
        static void ExchangeRowIndice (int[] arr, out int[] acIndiceArr)
        {
            acIndiceArr = new int[arr.Length];
            Array.Copy(arr, acIndiceArr, arr.Length);
            Array.Sort(acIndiceArr);
            for (int b = 0; b < acIndiceArr.Length; b++)
            {
                acIndiceArr[b] = Array.IndexOf(arr, acIndiceArr[b]);
            }
        }
        static void ExchangeRowValues (int y, int z, int[] arr2, out int[] acValuesArr)
        {
            acValuesArr = new int[y];
            Array.Copy(arr2, y*z, acValuesArr, 0, y);
            foreach (int acva in acValuesArr)
            {
                Console.Write("{0, -6}", acva);
            }
        }
    }
}
