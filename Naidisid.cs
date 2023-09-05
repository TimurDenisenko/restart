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
            while (true)
            {
                Message m = new Message("", "", DateTime.Now);
                List<Message> autors = new List<Message>();

                Console.WriteLine("Kui palju inimesi lisame?");
                int arv = Int32.Parse(Console.ReadLine());
                for (int i = 0; i < arv; i++)
                {
                    m = m.CreateAutor();
                    m.AddLikes();
                    m.ShowInfo();
                    autors.Add(m);
                }
                m.WhoIsPopularityN(autors);
            }
        }
    }
}
