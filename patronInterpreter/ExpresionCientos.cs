using System;
using System.Collections.Generic;
using System.Text;

namespace patronInterpreter
{
    class ExpresionCientos : Expresion
    {

        public override string Cinco()
        {
            return "D";
        }

        public override string Cuatro()
        {
            return "CD";
        }

        public override int Factor()
        {
            return 100;
        }

        public override string Nueve()
        {
            return "CM";
        }

        public override string Unidad()
        {
            return "C";
        }

    }
}
