// Задайте двумерный массив. Напишите программу, к
// оторая упорядочит по возрастанию элементы каждой строки двумерного массива.
// // Например, задан массив:

namespace GB
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine($"\n Введите размер массива m x n и диапазон случайных значений: ");
            int m = InputNumbers(" Введите m: ");
            int n = InputNumbers(" Введите n: ");
            int range = InputNumbers(" Введите диапазон: от 1 до ");

            int[,] array = new int[m, n];
            CreateArray(array);
            WriteArray(array);

            Console.WriteLine($"\n Отсортированный массив: ");
            OrderArrayLines(array);
            WriteArray(array);

            void OrderArrayLines(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        for (int k = 0; k < array.GetLength(1) - 1; k++)
                        {
                            if (array[i, k] < array[i, k + 1])
                            {
                                int temp = array[i, k + 1];
                                array[i, k + 1] = array[i, k];
                                array[i, k] = temp;
                            }
                        }
                    }
                }
            }

            int InputNumbers(string input)
            {
                Console.Write(input);
                int output = Convert.ToInt32(Console.ReadLine());
                return output;
            }

            void CreateArray(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = new Random().Next(range);
                    }
                }
            }

            void WriteArray(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }

}
