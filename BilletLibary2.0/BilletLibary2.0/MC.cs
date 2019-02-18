using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibary2._0
{
    public class MC : Køretøj
    {
        public MC(string nummerPlade, DateTime dato)
            : base(nummerPlade, dato)
        {
            nummerPlade = Nummerplade;
            Dato = dato;
        }


        public override double Pris()
        {
            if (Brobizz == true)
            {
                return 125 * 0.95;
            }
            return 125;
        }


        public override string KøretøjsType()
        {
            return "MC";
        }
    }
}
