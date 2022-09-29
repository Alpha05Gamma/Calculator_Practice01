using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool finisher = true;
            do
            {
                Console.WriteLine("Выберите программу");
                Console.WriteLine("1. Игра \"Угадай число\"");
                Console.WriteLine("2. Таблица умножения");
                Console.WriteLine("3. Вывод делителей числа");
                Console.WriteLine("4. Выход");

                int menuUi = Convert.ToInt32(Console.ReadLine());

                switch (menuUi)
                {
                    case 1:
                        RandomNumber();
                        break;

                    case 2:
                        MultTable();
                        break;

                    case 3:
                        NumberDivs();
                        break;

                    case 4:
                        finisher = false;
                        break;
                        default: Console.WriteLine("Выбрана несуществующая программа");
                        break;
                }
            } while (finisher);


            static void RandomNumber ()
            {
                Random random = new Random();
                int Rnumber = random.Next(0, 100);
                bool winner = true;
                do
                {
                    Console.WriteLine("Введите любое число");
                    int number = Convert.ToInt32(Console.ReadLine());
                    if (number == Rnumber)
                    {
                        winner = false;
                        Console.WriteLine("Поздравляю, вы угадали!");
                    }
                    else if (number > Rnumber)
                    {
                        Console.WriteLine("Слишком много");
                    }
                    else
                    {
                        Console.WriteLine("Маловато будет");
                    }
                } while (winner);
            }
             static void MultTable ()
            {
                int[,] line01 = new int[9, 9];

                for (int i = 0; i < line01.GetLength(0); i++)
                {
                    for (int j = 0; j < line01.GetLength(1); j++)
                    {
                        line01[i, j] = (i + 1) * (j + 1);
                    }
                }
                for (int i = 0; i < line01.GetLength(0); i++)
                {
                    for (int j = 0; j < line01.GetLength(1); j++)
                    {
                        Console.Write(line01[i, j] + "\t\t");
                    }
                    Console.WriteLine();
                }
             }

            static void NumberDivs ()
            {
                Console.WriteLine("Введите целое число");
                Console.WriteLine("Что бы выйти, введите \"выйти\"");
                string outWord;
                int number;
                do
                {
                    outWord = Console.ReadLine();
                    if (outWord != "выйти")
                    {
                        number = Convert.ToInt32(outWord);
                    }
                    else
                    {
                        break;
                    }
                    List<int> numberDivs = new List<int>();
                    for (int i = 1; i < number; i++)
                    {
                        if ((number % i) == 0)
                        {
                            numberDivs.Add(i);
                        }
                    }

                    for (int i = 0; i < numberDivs.Count; i++)
                    {
                        Console.Write(numberDivs[i] + "; ");
                    }
                    Console.WriteLine();
                } while (outWord != "выйти");
            }
        }
    }
}
