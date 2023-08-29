using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restart
{
    public class Student
    {
        public string Name { get; set; }
        public int age;
        private readonly string _city;
        public string status;

        public Student(string name, int age, string city)
        {
            Name = name;
            Age = age;
            _city = city;
        }

        public int Age
        {
            get { return age; }
            set
            {
                age = value;
                if (age<18) status="alaelaline";
                else status="täiskasvanud";
            }
        }

        public string Status
        { 
            get { return status; }
        }

        public string GetCity()
        {
            return _city;
        }

        public void ShowInfo()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Age);
            Console.WriteLine(GetCity());
            Console.WriteLine(Status);
            Console.WriteLine(BornYear());
        }

        public int BornYear()
        {
            return DateTime.Now.Year-age;
        }
    }
}
