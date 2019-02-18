using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibary2._0
{
    public class Bil : Køretøj
    {
        public Bil(string nummerPlade, DateTime dato)
            : base(nummerPlade, dato)
        {
            nummerPlade = Nummerplade;
            Dato = dato;


        }

        public override double Pris()
        {
            if (Brobizz == true)
            {
                return 240 * 0.95;
            }
            return 240;
        }

        public override string KøretøjsType()
        {
            return "Bil";
        }
    }
}
