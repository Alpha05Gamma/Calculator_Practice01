namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double num01 = 0, num02 = 0;
            int variator = 0;
            bool checker = true;

            Console.WriteLine("Калькулятор");
            
            do 
            {
                Console.WriteLine("1. Сложить 2 числа");
                Console.WriteLine("2. Вычесть первое из второго");
                Console.WriteLine("3. Перемножить два числа");
                Console.WriteLine("4. Разделить первое на второе");
                Console.WriteLine("5. Возвести в степень N первое число");
                Console.WriteLine("6. Найти квадратный корень из числа");
                Console.WriteLine("7. Найти 1 процент от числа");
                Console.WriteLine("8. Найти факториал из числа");
                Console.WriteLine("9. Выйти из программы");
                
                variator = Convert.ToInt32(Console.ReadLine());
                             
                switch (variator)
                {
                    case 1:
                        Console.WriteLine("Введите первое слагаемое");
                        num01 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе слагаемое");
                        num02 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Результат: ", num01 + num02);
                        Console.WriteLine("Ведите другую операцию");
                        break;
                    case 2:
                        Console.WriteLine("Введите первое число");
                        num01 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе число");
                        num02 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Результат: ",num02 - num01);
                        Console.WriteLine("Ведите другую операцию");
                        break;
                    case 3:
                        Console.WriteLine("Введите первое число");
                        num01 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе число");
                        num02 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Результат: ", num02 * num01);
                        Console.WriteLine("Ведите другую операцию");
                        break;
                    case 4:
                        Console.WriteLine("Введите первое число");
                        num01 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе число");
                        num02 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Результат: ", num01 / num02);
                        Console.WriteLine("Ведите другую операцию");
                        break;
                    case 5:
                        Console.WriteLine("Введите число");
                        num01 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите степень");
                        num02 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Результат: ", Math.Pow(num01, num02));
                        Console.WriteLine("Ведите другую операцию");
                        break;
                    case 6:
                        Console.WriteLine("Введите число");
                        num01 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Результат: ", Math.Sqrt(num01));
                        Console.WriteLine("Ведите другую операцию");
                        break;
                    case 7:
                        Console.WriteLine("Введите число");
                        num01 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Результат: ", num01/100);
                        Console.WriteLine("Ведите другую операцию");
                        break;
                    case 8:
                        Console.WriteLine("Введите число");
                        num01 = Convert.ToDouble(Console.ReadLine());
                        double factorial = 1;
                        for (int i = 1; i <= num01; i++)
                        {
                            factorial *= i;
                        }
                        Console.Write("Результат: ");
                        Console.WriteLine(factorial);
                        Console.WriteLine("Ведите другую операцию");
                        break;
                    case 9:
                        checker = false;
                        break;
                    default: Console.WriteLine("Ошибка, введите другую операцию"); 
                        break;

                }
            } while (checker);
            
        }
    }
}