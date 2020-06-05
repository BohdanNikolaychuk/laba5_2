using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Laba5_2
{
   public class Second : First
    {
        public string name { get; set; }
        public string secondname { get; set; }

      
       

        public  void A (List<Second> list)
        {
            list.Sort(delegate (Second t1, Second t2)   // sort
            {
                return t2.nubmers.CompareTo(t1.nubmers);

            });

            foreach (First el in list)
            {
                Console.WriteLine("День з найбiльшою кiлькiстю вiдвiдувачiв=" + el.day + "\n" + "__________________________________________________________");
                break;
            }

            list.Sort(delegate (Second t1, Second t2)   // sort
            {
                return t1.comment.CompareTo(t2.comment);

            });

            foreach (Second el in list)
            {
                Console.WriteLine("день з найбiльшою кiлькістю слiв у коментарi=" + el.day + "\n" + "__________________________________________________________");
                break;
            }

        }


        public void C(List<Second> list)
        {
            int sum = 0;
            foreach (First item in list)
            {
                sum += item.nubmers;

            }
            Console.WriteLine("Сумарна кiлькiсть вiдвiдувачiв = " + sum);
        }


    }
}
