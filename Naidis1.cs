using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restart
{
    public class Naidis1
    {
        public static void Main(string[] args)
        {
            Student studentJohn = new Student("John", 18, "London");

            Console.WriteLine(studentJohn.Name);
            Console.WriteLine(studentJohn.Age);
            Console.WriteLine(studentJohn.GetCity());
            Console.WriteLine(studentJohn.Status);
            Console.WriteLine(studentJohn.BornYear());

            Console.WriteLine();

            studentJohn.ShowInfo();
        }
    }
}
