using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister
{
    public class SpyPrinter : Printer
    {
        public bool Hasprint { get; set; }
        public override void Print(string content)
        {
            base.Print(content);
            Hasprint = true;
            // send message to a real printer
        }
    }
}
