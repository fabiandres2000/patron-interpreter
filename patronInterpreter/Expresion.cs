using System;
using System.Collections.Generic;
using System.Text;

namespace patronInterpreter
{
    abstract class Expresion
    {
        public void interpretar(Context contexto) {

            if (contexto.Expresion.Length == 0)
            {
                return;
            }
            if (contexto.Expresion.StartsWith(Nueve()))
            {
                contexto.Valor += (9*Factor());
                //ya sea IX, XC o CM
                contexto.Expresion = contexto.Expresion.Substring(2);
            }
            else if (contexto.Expresion.StartsWith(Cuatro()))
            {
                contexto.Valor += (4 * Factor());
                // IV, XL , CD
                contexto.Expresion = contexto.Expresion.Substring(2);
            }
            else if (contexto.Expresion.StartsWith(Cinco()))
            {
                contexto.Valor += (5 * Factor());
                contexto.Expresion = contexto.Expresion.Substring(1);
            }

            while (contexto.Expresion.StartsWith(Unidad()))
            {
                contexto.Valor += (1 * Factor());
                contexto.Expresion = contexto.Expresion.Substring(1);
                //III, XXX
            }
        }

        public abstract string Unidad();
        public abstract string Cuatro();
        public abstract string Cinco();
        public abstract string Nueve();
        public abstract int Factor();


    }
}
