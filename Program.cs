// Задача 6. Определение четного числа
//Console.Write("Введите число: ");
//int number = Convert.ToInt32(Console.ReadLine());
//if(number % 2 == 0)
//{
    //Console.WriteLine("да");
//}
//else
//{
    //Console.WriteLine("нет");
//}

//Задача 2. Сравнение двух чисел
//Console.Write("Введите первое число: ");
//int number1 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите второе число: ");
//int number2 = Convert.ToInt32(Console.ReadLine());
//int max = number1;
//if(number2 > max)
//{
    //Console.WriteLine("max=" + number2);
//}
//else
//{
    //Console.WriteLine("max=" + number1);
//}

//Задача 4. Сравнение трех чисел
//Console.Write("Введите первое число: ");
//int number1 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите второе число: ");
//int number2 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите третье число: ");
//int number3 = Convert.ToInt32(Console.ReadLine());
//int max = number1;
//if(number1 > max) max = number1;
//if(number2 > max) max = number2;
//if(number3 > max) max = number3;
//Console.WriteLine(max);

//Задача 8. На входе число N, на выходе все четные от 1 до N
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int number = 1;
while (numberN >= number)
{
   if(number % 2 == 0)
    {
        Console.Write(number + ",");
    }
    number++;
}
Console.WriteLine("");