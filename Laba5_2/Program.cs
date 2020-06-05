using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Laba5_2
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Second> list = new List<Second>()
            {
                new Second() { name  = "Glek",secondname = "Petrov",comment = "Itsgood",nubmers =2,day = "Monday" },
                new Second() { name  = "Glek",secondname = "Petrov",comment = "Itsbad",nubmers =3,day = "Tuesday" },
                new Second() { name  = "Glek",secondname = "Petrov",comment = "Itsbad",nubmers =4,day = "Friday" }
            };
            
            


            while (true)
            {

                Console.Write("Введiть дiю" + " \n");
                Console.WriteLine("Сортувати 'A'");
                Console.WriteLine("Показати всi данi нажми 'B'");
                Console.WriteLine("Сумарна кiлькiсть вiдвiдувачiв 'C'");
                Console.WriteLine("Пошук за назвою 'D'");
                Console.WriteLine("Видалення 'Delete'");
                Console.WriteLine("Почистити конколь 'Enter'/Назад");

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.A:

                        new Second().A(list);


                        break;

                    case ConsoleKey.B:
                        Console.WriteLine("Name" + "\t" + "Comment" + "\t" + "SName" + "\t" + "How" + "\t" + "Day");
                        foreach (Second item in list)
                        {

                            Console.WriteLine(item.name + "\t" + item.comment + "\t" + item.secondname + "\t" + item.nubmers + "\t" + item.day);
                        }

                        break;

                    case ConsoleKey.C:

                        new Second().C(list);

                        break;


                    case ConsoleKey.Enter:


                        Console.Clear();

                        break;

                    case ConsoleKey.Escape:
                        Environment.Exit(0);

                        break;

                    case ConsoleKey.D:
                        Console.WriteLine("Введіть назву  для пошуку");
                        string s1 = Console.ReadLine();
                        var found = list.Find(item => item.name == s1);
                        Console.WriteLine("Назва =" + found.name + " " + found.secondname);
                        break;

                    case ConsoleKey.Delete:

                        Console.WriteLine("Введить номер елемента який хочете видалити");
                        int s = int.Parse(Console.ReadLine());
                        list.RemoveAt(s);
                        foreach (First el in list)
                        {
                            Console.WriteLine(el);
                        }
                        break;


                }







            }
        }

        
    }
}
