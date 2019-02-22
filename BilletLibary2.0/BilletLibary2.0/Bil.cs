using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibary2._0
{
    public class Bil : Køretøj
    {


        /// <summary>
        /// Alle biler skal have en nummerplade og dato
        /// </summary>
        /// <param name="nummerPlade">Nummerplade må ikke være mere ind 7 tegn</param>
        /// <param name="dato">Dato</param>
        public Bil(string nummerPlade, DateTime dato)
            : base(nummerPlade, dato)
        {
            nummerPlade = Nummerplade;

            Dato = dato;
            

        }

        /// <summary>
        /// Billetpris for en bil
        /// </summary>
        /// <returns></returns>
        public override double Pris()
        {
            if (Brobizz == true)
            {
                return 240 * 0.95;
            }
            return 240;
        }

        /// <summary>
        /// Køretøjstype
        /// </summary>
        /// <returns></returns>
        public override string KøretøjsType()
        {
            return "Bil";
        }

    }
}
