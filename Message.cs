using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace restart
{
    public class Message
    {
        private readonly string _content;
        private readonly string _author;
        private readonly DateTime _time;
        private int _likes;

        public Message(string content, string author, DateTime time)
        {
            this._content = content;
            this._author = author;
            this._time = time;
        }

        public int Likes { get => _likes; }
        public DateTime Time { get => _time; }
        public string Author { get => _author; }
        public string Content { get => _content; }

        public void AddLike()
        {
            _likes++;
        }

        public double GetPopularity()
        {
            double elapsed = DateTime.Now.Subtract(this._time).TotalSeconds;
            if (elapsed == 0)
            {
                return _likes;
            }
            return _likes / elapsed;

        }

        public void ShowInfo()
        {
            Console.WriteLine("\n("+Author+") - "+Content+"\nTime: "+Time+"\nLikes: "+Likes+"\nPopularity: "+GetPopularity()+"\n");
        }

        public void WhoIsPopularity(Message m2)
        {
            string p = "";
            if (Math.Round(GetPopularity(), 6)==Math.Round(m2.GetPopularity(), 6))
            {
                p="Mitte keegi";
            }
            else if (GetPopularity()>m2.GetPopularity())
            {
                p=Author;
            }
            else
            {
                p=m2.Author;
            }
            Console.WriteLine("{0} sõnum on populaarsem", p);
        }

        public void AddMessage()
        {
            
        }

        public void WhoIsPopularityN(List<Message> messages)
        {
            double p = 0;
            List<Message> messages2 = new List<Message>();
            for (int i = 0; i < messages.Count(); i++)
            {
                if (Math.Round(messages[i].GetPopularity(),6)==Math.Round(p, 6))
                {
                    messages2.Add(messages[i]);
                }
                else if (messages[i].GetPopularity()>p)
                {
                    messages2.Clear();
                    p=messages[i].GetPopularity();
                }
            }
            switch (messages2.Count)
            {
                case 1: Console.WriteLine("{0} sõnum on populaarsem", messages2[0].Content); break;
                case 2: Console.WriteLine("{0} ja {1} sõnumeid on populaarsem", messages2[0].Content, messages2[1].Content); break;
                case 3: Console.WriteLine("{0}, {1} ja {2} sõnumeid on populaarsem", messages2[0].Content, messages2[1].Content, messages2[2].Content); break;
                default:
                    for (int i = 0; i < messages2.Count - 1; i++)
                    {
                        Console.Write("{0}, ", messages2[i].Content);
                    }
                    Console.WriteLine("{0} sõnumeid on populaarsem", messages2[messages2.Count-1].Content);
                    break;
            }
        }
    }
}
