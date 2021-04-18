using System;

namespace Task9v7
{
    class Program
    {
        static void Main(string[] args)
        {
            //* Задан массив, состоящий из 15 элементов вещественного типа. 
            //* Определить количество элементов, значения которых больше первого элемента.

            double[] numberArray = new double[15];
            string input;
            Random rand = new Random(DateTime.Now.Millisecond);
            int count = 0;

            for (int i = 0; i < numberArray.Length; i++)
            {
                /*Console.Write($"Введите {i + 1} число: ");
                input = Console.ReadLine();
                numberArray[i] = int.Parse(input);*/

                numberArray[i] = Math.Round((rand.NextDouble() * 100), 5);
                //Console.WriteLine($"{numberArray[i]}");
            }

            for (int i = 1; i < numberArray.Length; i++)
            {
                if (numberArray[i] > numberArray[0])
                {
                    count++;
                }
            }

            Console.WriteLine($"Количество элементов, которые больше {numberArray[0]} = {count}");


            //* Дан массив вещественных чисел Z(16) . Определить разность между 
            //* суммой элементов c четными индексами и суммой элементов, индексы 
            //*которых кратны трем.


            //* Ввести массив, состоящий из 15-ти элементов (двузначные целые числа). 
            //* Изменить разрядность цифр, образующих элементы исходного массива и, 
            //* таким образом, сформировать новый массив. Например, исходный
            //* массив: 25 71 84…, новый массив: 52 17 48….
        }
    }
}
