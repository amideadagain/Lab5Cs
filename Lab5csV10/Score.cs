using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5csV10
{
    class Score : IDocument, ITurnover
    {
        string content;
        DateTime dateTime;
        string signature;
        int price;

        public Score(string content, DateTime dateTime, string signature, int price)
        {
            Create(content, dateTime, signature);
            this.price = price;
        }

        public string Content { get => content; set => content = value; }
        public DateTime DateTime { get => dateTime; set => dateTime = value; }

        public string Signature => signature;

        public int Price { get => price; set => price = value; }

        public void Create(string content, DateTime dateTime, string signature)
        {
            this.content = content;
            this.dateTime = dateTime;
            this.signature = signature;
        }

        public void Send(string email, string document)
        {
            // допустим отправилось
        }

        public void Subscribe(string signature)
        {
            this.signature = signature;
        }
    }
}
