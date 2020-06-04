using System;
using System.Collections.Generic;
using System.Text;

namespace patronInterpreter
{
    class ExpresionUnidad : Expresion
    {
        public override string Cinco()
        {
            return "V";
        }

        public override string Cuatro()
        {
            return "IV";
        }

        public override int Factor()
        {
            return 1;
        }

        public override string Nueve()
        {
            return "IX"; 
        }

        public override string Unidad()
        {
            return "I";
        }
    }
}
