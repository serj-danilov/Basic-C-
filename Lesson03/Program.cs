using System;

namespace Lesson03
{
   class Complex
        {

            // Данилов Сергей Владимирович

            #region Поля (Fields)

            /// <summary>
            /// Мнимая часть комплексного числа
            /// </summary>
            private double im;

            /// <summary>
            /// Действительная часть комплексного числа
            /// </summary>
            private double re; // private

            #endregion

            #region Свойства

            public double Im
            {
                get
                {
                    return im;
                }

                set
                {
                    if (value == 0)
                    {
                        throw new Exception("Недопустимое значение.");
                    }

                    im = value;
                }
            }

            public double Re
            {
                get
                {
                    return re;
                }

                set
                {
                    re = value;
                }
            }

            #endregion

            #region Конструктор класса

            public Complex(double re, double im)
            {

                this.re = re;
                this.im = im;

            }

            public Complex()
            {

            }

            #endregion

            #region Поведение (Methods)

            public Complex Plus(Complex complex)
            {
                return new Complex(this.re + complex.re, this.im + complex.im);
            }

            // Данилов Сергей Владимирович 
            public Complex Minus(Complex complex)
            {
                return new Complex(this.re - complex.re, this.im - complex.im);
            }
            // Данилов Сергей Владимирович
            #endregion

            public override string ToString()
            {

                return $"({re} и {im}i)";
            }


        }

        class Program
        {
            //Описание меню программы 
            static void refreshMenu()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("=====================");
                Console.WriteLine("Данилов Сергей Владимирович ");
                Console.WriteLine("1 - Работа с классом Complex.");
                Console.WriteLine("2 - подсчитать сумму всех нечётных положительных чисел.");
                Console.WriteLine("0 - Завершение работы приложения.");
                Console.WriteLine("=====================");
                Console.WriteLine("Введите номер задачи: ");
                Console.ResetColor();
            }
            static void errorMenu()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Вы ввели некорректный номер задачи.\nПовторите попытку ввода.");
                Console.WriteLine("Нажмите любую кнопку для возврата в меню.");
                Console.ReadKey();
                refreshMenu();
            }

            // Обработчики ошибок
            static int returnNumber()
            {
                string userNum = Console.ReadLine();
                bool isNum = int.TryParse(userNum, out int number);
                if (!isNum)
                {

                    Console.Write($"Вы ввели - \"{userNum}\", введены не числоыве символы. Ввдите произвольное число. ");
                    number = returnNumber();
                };
                return number;
            }

            static void waitZero()
            {
                Console.Clear();
                Console.WriteLine("С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.");
                Console.Write("Введите произвольное число или 0 для завершения работы. ");
                int number = returnNumber();
                string alluserNum = "";
                string alluserNotEvenNum = "";
                int summNum = 0;
                while (number != 0)
                {
                    if (number % 2 != 0 && number > 0)
                    {
                        summNum = summNum + number;
                        alluserNotEvenNum = alluserNotEvenNum + number + " ";
                    }
                    alluserNum = alluserNum + number + " ";
                    Console.Write("Введите произвольное число или 0 для завершения работы. ");
                    number = returnNumber();


                };
                Console.WriteLine($"Введено число {number}.\nКонец работы.");
                Console.WriteLine($"Вы ввели числа {alluserNum}.\nИз них нечетные положительных числа {alluserNotEvenNum}\nСумма этих чисел равна {summNum}.");
                Console.WriteLine("Для возврата в меню нажмите любую клавишу.");
                Console.ReadKey();
                Console.Clear();
            }


            static Complex complexInputFirsth()
            {

                Console.WriteLine("Ввод первого комплексного числа.");
                Console.Write("Введите действительную часть комплексного числа.");
                double re = double.Parse(returnNumber().ToString());
                Console.Write("Введите мнимую часть комплексного числа.");
                double im = double.Parse(returnNumber().ToString());
                Complex complex01 = new Complex(re, im);

                return complex01;


            }

            static Complex complexInputSecond()
            {

                Console.WriteLine("Ввод второго комплексного числа.");
                Console.Write("Введите действительную часть комплексного числа.");
                double re = double.Parse(returnNumber().ToString());
                Console.Write("Введите мнимую часть комплексного числа.");
                double im = double.Parse(returnNumber().ToString());
                Complex complex02 = new Complex(re, im);
                return complex02;
            }

            static void complexMinus()
            {
                Console.Clear();

                Complex complex01 = complexInputFirsth();

                Complex complex02 = complexInputSecond();

                Complex complex03 = complex01.Minus(complex02);

                Console.WriteLine($"Результат вычитания комплексных чисел {complex01} - {complex02} >>> {complex03}");
                Console.ReadKey();
            }

            static void complexPlus()
            {
                Console.Clear();

                Complex complex01 = complexInputFirsth();

                Complex complex02 = complexInputSecond();

                Complex complex03 = complex01.Plus(complex02);

                Console.WriteLine($"Результат сложения комплексных чисел {complex01} + {complex02} >>> {complex03}");
                Console.ReadKey();
            }


            static void refreshComplexMenu()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("=====================");
                Console.WriteLine("Работа с комплексными числами");
                Console.WriteLine("1 - Сложение двух комплексных чисел");
                Console.WriteLine("2 - Вычитание двух комплексных чисел");
                Console.WriteLine("0 - Возврат в основное меню приложения.");
                Console.WriteLine("=====================");
                Console.WriteLine("Введите номер операции: ");
                Console.ResetColor();
            }
            static void complexWork()
            {

                // Меню работы с классом Complex
                bool flag = true;

                while (flag)
                {
                    refreshComplexMenu();

                    int taskNumber = returnNumber();

                    switch (taskNumber)
                    {
                        case 1:
                            complexPlus();
                            break;
                        case 2:
                            complexMinus();
                            break;
                        case 0:
                            flag = false;
                            break;
                        default:
                            errorMenu();
                            break;
                    }
                }

                //Console.ReadKey();
            }

            static void Main(string[] args)
            {
                bool flag = true;

                while (flag)
                {


                    refreshMenu();

                    int taskNumber = returnNumber();

                    switch (taskNumber)
                    {
                        case 1:
                            //1.
                            //а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
                            //б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
                            //в) Добавить диалог с использованием switch демонстрирующий работу класса.
                            complexWork();
                            break;
                        case 2:
                            //2. С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse.
                            waitZero();
                            break;
                        case 0:
                            flag = false;
                            break;
                        default:
                            errorMenu();
                            break;
                    }
                }


                Console.WriteLine("Завершение работы приложения.");
                Console.ReadKey();


            }
        }




    }
   

