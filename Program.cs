
using System;
class Program
{
    static void Main()
    {
        
        // Простой калькулятор:
        Console.WriteLine("Введите 1 число - ");
          int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите 2 число - ");
          int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Выберите математическое действие (1 - Сложение, 2 - Вычитание, 3 - Умножение, 4 - Деление.) --  ");
          int c = int.Parse(Console.ReadLine());

        if(c == 1)
        {
            Console.WriteLine($"Произведено сложение - {a + b} ");
        }
        else if (c == 2)
        {
            Console.WriteLine($"Произведено вычитание - {a - b} ");
        }
        else if (c == 3)
        {
            Console.WriteLine($"Произведено умножение - {a * b} ");
        }
        else if (c == 4)
        {
            if(b == 0)
            {
                Console.WriteLine("Нельзя делить на ноль!!!");
                return;
            }
            Console.WriteLine($"Произведено деление - {a / b} ");
        }
        else
        {
            Console.WriteLine("Ошибка!!!");
        }
        
        
        // Игра - Угадай число!
        Random rnd = new Random();
        Console.WriteLine("Угадайте число от 1 до 10! --");
        int num = rnd.Next(1, 11);
        int PlayerNum = int.Parse(Console.ReadLine());
        if (PlayerNum > num)
        {
            Console.WriteLine("Число Игрока больше загадонного (у вас ещё одна попытка)! Повторно введтие число -- ");
        }
        else if (PlayerNum < num)
        {
            Console.WriteLine("Число Игрока меньше загадонного (у вас ещё одна попытка)! Повторно введтие число -- ");
        }

        else if (PlayerNum == num)
        {
            Console.WriteLine("Вы угадали!!!");
        }
        else
        {
            Console.WriteLine("Число Игрока не может быть меньше 1 или больше 10!!!");
        }
        int PlayerNum1 = int.Parse(Console.ReadLine());
        if (PlayerNum1 == num)
        {
            Console.WriteLine("Вы угадали со 2 попытки!!!!");
        }
        else
        {
            Console.WriteLine("Вы проиграли :( ");
        }


    }


}

