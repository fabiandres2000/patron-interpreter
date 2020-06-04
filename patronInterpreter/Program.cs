using System;
using System.Collections.Generic;

namespace patronInterpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            string expresion = "MMCXCIX";

            Context contexto = new Context(expresion);

            List<Expresion> arbol = new List<Expresion>();
            arbol.Add(new ExpresionMiles());
            arbol.Add(new ExpresionCientos());
            arbol.Add(new ExpresionDecenas());
            arbol.Add(new ExpresionUnidad());

            foreach (Expresion ex in arbol)
            {
                ex.interpretar(contexto);
            }

            Console.WriteLine($"el numero {expresion} es {contexto.Valor}");
        }
    }
}
