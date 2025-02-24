using System;
using System.Security.Cryptography.X509Certificates;



class Program
{ 
    static void Main()
    {
        while (true)
        {

            //Data Access Layer
            Dictionary<string, int> names = new Dictionary<string, int>();

            Console.WriteLine("1) Добавить пользователя 2) Удалить пользователя 3) Показать пользователя 4) Показать список всех пользователей - ");
            int Choice = int.Parse(Console.ReadLine());

            if (Choice == 1)
            {
                bool EmptyNames;
                // Presentation Layer
                Console.WriteLine("Введите сначало имя пользователя, нажмите enter. Затем придумайте индекс человеку и запишите - ");
                string Username = Console.ReadLine();
                // Business layer
                EmptyNames = String.IsNullOrEmpty(Username);
                if (EmptyNames = false)
                {
                    Console.WriteLine("Не оставляйте поле путсым - ");
                    Username = Console.ReadLine();
                }
                // Presentation Layer
                int NameIndex = int.Parse(Console.ReadLine());
                names.Add(Username, NameIndex);

            }

            else if (Choice == 2)
            {
                // Presentation Layer
                Console.WriteLine("Введите индекс пользователя, которого хотите удалить - ");
                string DeleteNames = Console.ReadLine();
                names.Remove(DeleteNames);
            }

            else if (Choice == 3)
            {
                // Presentation Layer
                Console.WriteLine("Введите индекс пользователя, которого хотите увидеть имя - ");
                string ShowName = Console.ReadLine();
                Console.WriteLine(names[ShowName]);
            }
            
            
            else if (Choice == 4)
            {


                foreach (var list in names)
                {
                    Console.WriteLine("{0}, {1}",
                    list.Key,
                    list.Value);
                }

            }
            else
            {
                Console.WriteLine("Введите верное значение.");
            }

        }
        
    }
}


