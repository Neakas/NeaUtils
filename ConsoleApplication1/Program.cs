using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeaUtils.Extensions.ErrorHandling;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int value = 256;
            //value.ConditionalErrorCheck(x => x > 255,true);
            string inputtext = "Hallo Welt";
            inputtext.ConditionalErrorCheck(x => x.Contains("Hallo"), true);
        }
    }
}
