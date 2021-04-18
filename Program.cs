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
            //* которых кратны трем.

            double[] Z = new double[16];
            double sumOfEven = 0;
            double sumMultiplesOfThree = 0;
            double difference = 0;

            for (int i = 0; i < Z.Length; i++)
            {
                Z[i] = Math.Round((rand.NextDouble() * 100), 5);
                Console.WriteLine($"{Z[i]}");
            }

            for (int i = 0; i < Z.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sumOfEven += Z[i];
                }

                if (i % 3 == 0)
                {
                    sumMultiplesOfThree += Z[i];
                }
            }

            if (sumOfEven > sumMultiplesOfThree)
            {
                difference = Math.Round((sumOfEven - sumMultiplesOfThree), 5);
                Console.WriteLine($"{sumOfEven} > {sumMultiplesOfThree}");
                Console.WriteLine($"Разность между суммой элементов с четными индексами и элементов с индексами кратные трем = {difference}");
            }
            else if (sumOfEven < sumMultiplesOfThree)
            {
                difference = Math.Round((sumMultiplesOfThree - sumOfEven), 5);
                Console.WriteLine($"{sumOfEven} < {sumMultiplesOfThree}");
                Console.WriteLine($"Разность между суммой элементов с четными индексами и элементов с индексами кратные трем = {difference}");
            }
            else
            {
                Console.WriteLine("Сумма элементов с четными индексами = сумме элементов с индексами кратные трем");
            }

            //* Ввести массив, состоящий из 15-ти элементов (двузначные целые числа). 
            //* Изменить разрядность цифр, образующих элементы исходного массива и, 
            //* таким образом, сформировать новый массив. Например, исходный
            //* массив: 25 71 84…, новый массив: 52 17 48….
        }
    }
}
