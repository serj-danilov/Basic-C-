using System;

namespace Lesson02
{


    //Данилов Сергей Владимирович. Курс Unity

    class MainClass
    {

        static void Prog1()
        {
            Console.Clear();

            Console.Write("Введите первое число:");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число:");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Введите третье число:");
            int num3 = int.Parse(Console.ReadLine());


            int max = num1;

            if (num2 > num1) max = num2;

            if (num3 > max) max = num3;


            /*  max = num2 > num1 ? mum2 : num1;
                max = max > num3 ? max : num3; */

            Console.Clear();

            Console.Write("Максимальное число = " + max);

            Console.ReadKey();
            Console.Clear();


        }


        static void Prog2()
        {

            static int CountDigitByString(int n)
            {
                return Math.Abs(n).ToString().Length;
            }

            Console.Clear();
            Console.Write("Введите любое число:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Количество цифр в цисле = " + CountDigitByString(n));
            Console.ReadKey();
            Console.Clear();

        }


        static void Prog3()
        {


            Console.Clear();
            bool flag = true;
            int count = 0;
            int sum = 0;
            int sumNech = 0;

            while (flag)
            {

                Console.Clear();
                Console.Write("Введите любое число от 0 до 100. Выход 0:");
                int n = int.Parse(Console.ReadLine());

                if (n == 0)
                    flag = false;

                if (n % 2 != 0)
                    sumNech = sumNech + n;

                Console.WriteLine($"Число {n}.  Всего цифр было введено {count=count+1} ");
                Console.WriteLine($"Сумма всех чисел = {sum=sum+n} ");
                Console.WriteLine($"Сумма всех нечетнх чисел = {sumNech} ");

                Console.ReadKey();



            }




        }


        static void Prog4()
        {

            string login = "root";
            string pass = "GeekBrains";
            // по хорошему нужно все хранить в MD5))

            for (int i = 1; i <= 3; i++)

            {
                int count = 3;

                Console.Clear();
                Console.Write("Введите логин:");
                string userLogin = Console.ReadLine();

                Console.Clear();
                Console.Write("Введите пароль:");
                string userPass = Console.ReadLine();


                if (userLogin == login && userPass == pass)
                {
                    Console.Clear();
                    Console.Write("Доступ разрешен!");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }

                else
                {
                    Console.Write($"Логин или пароль неверны, повторите ввод, осталось {count=count-i} попыток");
                    Console.ReadKey();
                    if (count == 0)
                    {
                        Console.Clear();
                        Console.Write("Доступ запрещен!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                }

            }

            


        }




        public static void Main(string[] args)
        {
            Console.Clear();

            bool flag = true;

            while (flag)

            {

                Console.Write("Введите номер задачи 1-4:");

                int caseSwitch = int.Parse(Console.ReadLine());

                switch (caseSwitch)
                {
                    case 1:
                        Console.WriteLine("Задача 1");
                        Prog1();
                        break;

                    case 2:
                        Console.WriteLine("Задача 2");
                        Prog2();
                        break;

                    case 3:
                        Console.WriteLine("Задача 3");
                        Prog3();
                        break;

                    case 4:
                        Console.WriteLine("Задача 4");
                        Prog4();
                        break;

                    case 0:
                        Console.WriteLine("Выход");
                        Console.ReadKey();
                        flag = false;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Задач всего 4шт. Нажмите Enter и введите число от 1 до 4. Выход 0");
                        Console.ReadKey();
                        Console.Clear();
                        break;


                }

            }









            }
        }
}
