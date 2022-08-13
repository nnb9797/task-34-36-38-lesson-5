using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_34_36_38_lesson_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void Zadacha34()
            {
                //Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
                //Напишите программу, которая покажет количество чётных чисел в массиве.
                //[345, 897, 568, 234] -> 2
                Console.Clear();
                int[] numbers = new int[10];
                void FillArray(int[] array)
                {
                    Random random = new Random();
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = random.Next(100, 999);
                    }
                }

                void WriteArray(int[] array)
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.Write(array[i] + " ");
                    }
                    Console.WriteLine();
                }

                int QuantityPositive(int[] array)
                {
                    int result = 0;
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] % 2 == 0)
                        {
                            result++;
                        }
                    }
                    return result;
                }

                FillArray(numbers);
                WriteArray(numbers);
                Console.WriteLine();

                int quantity = QuantityPositive(numbers);
                Console.WriteLine($"Количество чётных чисел в массиве: {quantity}");
                Console.ReadKey();
            }
            void Zadacha38()
            {
                // Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
                // [3,21 7,04 22,93 - 2,71 78,24] -> 75,53
                double[] mas = new double[] { 3.21, 7.04, 22.93, -2.71, 78.24 };
                Array.Sort(mas);
                double min = mas[0];
                double max = mas[mas.Length - 1];
                double res = max - min;
                Console.WriteLine("Минимум: {0}", min);
                Console.WriteLine("Максимум: {0}", max);
                Console.WriteLine("Разность: {0}", res);
                Console.ReadKey();

            }
            void Zadacha36()
            {
                //Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
                //[3, 7, 23, 12] -> 19
                //[-4, -6, 89, 6]-> 0

                Console.Clear();
                int[] numbers = new int[6];
                int sum = 0;
                void FillArray(int[] array)
                {
                    Random random = new Random();
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = random.Next(-15, 15);
                    }
                }
                void PrintArray(int[] array)
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.Write(array[i] + " ");
                    }
                    Console.WriteLine();
                }
                void SumOdd(int[] array)
                {
                    for (int i = 0; i < array.Length; i = i+2)
                    {
                     sum = sum + array[i];
                    }
                }
                FillArray(numbers);
                PrintArray(numbers);
                SumOdd(numbers);
                Console.WriteLine();

                Console.WriteLine($"Сумма чисел, стоящих на нечетных позициях в массиве: {sum} ");
                Console.ReadKey();
            }
            //Zadacha34();
            //Zadacha38();
            //Zadacha36();

        }

    }
    }

