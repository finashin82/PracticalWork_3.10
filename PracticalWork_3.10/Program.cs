using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork_3._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///<summary>
            ///Проверка числа на чётность
            /// </summary>
            #region            
            
            Console.Write("Проверка числа на чётность. Введите число: ");
            double number = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            if (number % 2 == 0)
            {
                Console.WriteLine($"Число {number} чётное.");
            }
            else
            {
                Console.WriteLine($"Число {number} нечётное.");
            }

            Console.WriteLine();
            Console.WriteLine("Для продолжения нажмите любую клавишу.");
            Console.WriteLine();
            Console.ReadKey();
            #endregion

            ///<summary>
            /// Сумма карт в Игре 21
            /// </summary>
            #region            
            double summaGame = 0;
            string mapGame;

            Console.Write("Сумма карт в игре 21. Сколько у Вас карт? : ");
            double quantityMap = Convert.ToDouble(Console.ReadLine());
            
            
            for (int i = 1; i <= quantityMap; i++)
            {
                Console.WriteLine("Какая у Вас карта? (6, 7, 8, 9, 10, Валет(J), Дама(Q), Король(K), Туз(T))? ");
                Console.Write("Введите карту: ");
                mapGame = Convert.ToString(Console.ReadLine());
                Console.WriteLine();
                
                switch (mapGame)
                {
                    case "6":
                        summaGame += 6;
                        break;
                    case "7":
                        summaGame += 7;
                        break;
                    case "8":
                        summaGame += 8;
                        break;
                    case "9":
                        summaGame += 9;
                        break;
                    case "10":
                        summaGame += 10;
                        break;
                    case "J":
                        summaGame += 10;
                        break;
                    case "Q":
                        summaGame += 10;
                        break;
                    case "K":
                        summaGame += 10;
                        break;
                    case "T":
                        summaGame += 10;
                        break;
                }                
            }

            Console.WriteLine();
            Console.WriteLine($"Сумма Ваших карт = {summaGame}");

            Console.WriteLine();
            Console.WriteLine("Для продолжения нажмите любую клавишу.");
            Console.WriteLine();
            Console.ReadKey();
            #endregion

            ///<summary>
            /// Проверка простого числа
            /// </summary>
            #region
            int numberSimple;
            double numberCycle = 2;
            bool check = false;

            Console.Write("Проверка простого числа. Введите число: ");
            numberSimple = Convert.ToInt32(Console.ReadLine());

            while (numberCycle <= numberSimple - 1)
            {
                if (numberSimple % numberCycle == 0)
                {
                    check = true;
                }
                
                numberCycle++;
            }

            if (check == false)
            {
                Console.Write($"Число {numberSimple} - простое");
            }
            else
            {
                Console.Write($"Число {numberSimple} - составное");
            }

            Console.WriteLine();
            Console.WriteLine("Для продолжения нажмите любую клавишу.");
            Console.WriteLine();
            Console.ReadKey();
            #endregion

            ///<summary>
            /// Наименьший элемент в последовательности
            /// </summary>
            #region
            int min = int.MaxValue;
            int currentElement;

            Console.Write("Наименьший элемент в последовательности. Введите количество элементов: ");
            int numberOfElements = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= numberOfElements; i++)
            {
                Console.Write($"Введите {i} элемент последовательности: ");
                currentElement = Convert.ToInt32(Console.ReadLine());

                if ( currentElement < min ) 
                {
                    min = currentElement;
                }
            }

            Console.WriteLine();
            Console.Write($"Наименьший элемент в последовательности: {min}");

            Console.WriteLine();
            Console.WriteLine("Для продолжения нажмите любую клавишу.");
            Console.WriteLine();
            Console.ReadKey();
            #endregion

            ///<summary>
            /// Игра "Угадай число"
            /// </summary>
            #region
            Random rand = new Random();
            int numberOfRandom, intCustomNumber; 
            string strCustomNumber;

            Console.Write("Игра \"Угадай число\". Диапазон чисел от 1 до  ");
            int numberOfRange = Convert.ToInt32(Console.ReadLine());

            numberOfRandom = rand.Next(numberOfRange);

            while (true)
            {
                Console.Write("Введите число: ");
                strCustomNumber = Convert.ToString(Console.ReadLine());

                if (strCustomNumber == " ") break;
                else intCustomNumber = Convert.ToInt32(strCustomNumber);

                if (intCustomNumber == numberOfRandom)
                {
                    Console.WriteLine($"Поздравляю! Вы угадали. Это число {intCustomNumber}");
                    break;
                }
                else if (intCustomNumber > numberOfRandom)
                {
                    Console.WriteLine("Число, которое вы ввели больше задуманного.");
                }
                else
                {
                    Console.WriteLine("Число, которое вы ввели меньше задуманного.");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Для продолжения нажмите любую клавишу.");
            Console.WriteLine();
            Console.ReadKey();
            #endregion
        }
    }
}
