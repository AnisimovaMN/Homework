using System;
namespace Seminar2
{
    class Program
    {
        static void Main(string[] args)

        // Задача 10. Напишите программу, которая принимает на вход трехзначное число и на выходе
        // показывает вторую цифру этого числа.

        //{
            //Console.Write("Введите трехзначное число: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            
            //int number1 = number / 10;
            //int number2 = number1 % 10;
            
            //Console.WriteLine($"Вторая цифра числа {number} = {number2} ");
        //}

        // Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
        // что третьей цифры нет.

        //{
            //Console.Write("Введите любое число до 10000: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            
            //if(number>10000)
            //{
                //Console.WriteLine("Bad number");
            //}
            //else 
            //{
                //if(number<100)
                //{
                    //Console.WriteLine($"Третьей цифры у числа {number} нет");
                //}
                //else
                //{
                    //if(number<1000)
                    //{
                        //int number1 = number % 10;
                
                        //Console.WriteLine($"Третья цифра числа {number} = {number1} ");
                    //}
                    //else
                    //{
                        //int number1 = number / 10;
                        //int number2 = number1 % 10;

                        //Console.WriteLine($"Третья цифра числа {number} = {number2} ");
                    //}
                //}
            //}
        //}              
        

        // Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую
        // день недели, и проверяет, является ли этот день выходным 

        //{
            //Console.Write("Введите число дня недели от 1 до 7: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            
                        
            //if(number>7)
            //{
                //Console.WriteLine("Bad number");
            //}
            //else
            //{
                //if(number<6)
                //{
                    //Console.WriteLine("нет");
                //}
                //else
                //{
                    //Console.WriteLine("да");
                //}
            //}
        //}

        // Задача. Напишите программу, которая принимает на вход число и проверяет, 
        // кратно ли оно одновременно 7 и 23.

        {
            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            
                        
            if(number % 7 == 0 && number % 23 == 0)
            {
                Console.WriteLine("да");
            }
            else
            {
                Console.WriteLine("нет");
            }
                
        }
    }    
}
