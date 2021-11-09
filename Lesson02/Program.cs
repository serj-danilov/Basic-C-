using System;

namespace Lesson02
{
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

        }


        static void Prog3()
        {

        }


        static void Prog4()
        {

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


                    default:
                        Console.Clear();
                        Console.WriteLine("Задач всего 4шт. Нажмите Enter и введите число от 1 до 4");
                        Console.ReadKey();
                        Console.Clear();
                        break;


                }

            }









            }
        }
}
