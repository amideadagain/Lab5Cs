using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5csV10
{
    class Receipt : IDocument, ITurnover
    {
        string owner;
        string content;
        DateTime dateTime;
        string signature;

        public string Owner { get => owner; set => owner = value; }
        public string Content { get => content; set => content = value; }
        public DateTime DateTime { get => dateTime; set => dateTime = value; }
        public string Signature { get => signature; }

        public Receipt(string owner, string content, DateTime dateTime, string signature)
        {
            this.owner = owner;
            Create(content, dateTime, signature);
        }

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
