using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5csV10
{
    interface IDocument
    {
        string Content { get; set; }
        DateTime DateTime { get; set; }
        string Signature { get; }

        void Subscribe(string signature);
        void Create(string content, DateTime dateTime, string signature);
    }
}
