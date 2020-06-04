using System;
using System.Collections.Generic;
using System.Text;

namespace patronInterpreter
{
    class ExpresionDecenas : Expresion { 
   public override string Cinco()
    {
        return "L";
    }

    public override string Cuatro()
    {
        return "XL";
    }

    public override int Factor()
    {
        return 10;
    }

    public override string Nueve()
    {
        return "XC";
    }

    public override string Unidad()
    {
        return "X";
    }
  }
}
