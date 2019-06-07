using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5csV10
{
    class Invoice : IDocument, ITurnover
    {
        string content;
        DateTime dateTime;
        string signature;
        string product;
        string weight;

        public Invoice(string content, DateTime dateTime, string signature, string product, string weight)
        {
            Create(content, dateTime, signature);
            this.product = product ?? throw new ArgumentNullException(nameof(product));
            this.weight = weight ?? throw new ArgumentNullException(nameof(weight));
        }

        public string Content { get => content; set => content = value; }
        public DateTime DateTime { get => dateTime; set => dateTime = value; }

        public string Signature => signature;

        public string Product { get => product; set => product = value; }
        public string Weight { get => weight; set => weight = value; }

        public void Create(string content, DateTime dateTime, string signature)
        {
            this.content = content;
            this.dateTime = dateTime;
            this.signature = signature;
        }

        public void Send(string email, string document)
        {
            //допустим отправили
        }

        public void Subscribe(string signature)
        {
            this.signature = signature;
        }
    }
}
