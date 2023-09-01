using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restart
{
    public class Naidisid
    {
        public static void Main(string[] args)
        {
            /*
            Student studentJohn = new Student("John", 18, "London");

            Console.WriteLine(studentJohn.Name);
            Console.WriteLine(studentJohn.Age);
            Console.WriteLine(studentJohn.GetCity());
            Console.WriteLine(studentJohn.Status);
            Console.WriteLine(studentJohn.BornYear());

            Console.WriteLine();

            studentJohn.ShowInfo();
            */



            Message m1 = new Message("Hello", "John", DateTime.Now.AddDays(-10));
            m1.ShowInfo();
            m1.AddLike();

            Message m2 = new Message("Hi", "Mary", DateTime.Now.AddMinutes(-13));
            Message m3 = new Message("H1i", "Mary", DateTime.Now.AddMinutes(-13));
            Message m4 = new Message("H2i", "Mary", DateTime.Now.AddMinutes(-13));
            Message m5 = new Message("H3i", "Mary", DateTime.Now.AddMinutes(-13));
            for (int i = 0; i < 100; i++)
            {
                m1.AddLike();
            }
            m2.ShowInfo();

            m1.WhoIsPopularity(m2);
            m2.WhoIsPopularity(m1);
            m1.WhoIsPopularity(m1);
            m2.WhoIsPopularity(m2);
            List<Message> list = new List<Message>();
            list.Add(m2);
            list.Add(m3);
            list.Add(m4);
            list.Add(m5);
            m1.WhoIsPopularityN(list);
        }
    }
}
