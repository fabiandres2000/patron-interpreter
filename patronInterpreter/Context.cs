using System;
using System.Collections.Generic;
using System.Text;

namespace patronInterpreter
{
    public class Context
    {
        public string Expresion { get; set; }
        public int Valor { get; set; }

        public Context(string pExpresion)
        {
            Expresion = pExpresion;
            Console.WriteLine($"se evaluara {Expresion}");
        }
    }
}
