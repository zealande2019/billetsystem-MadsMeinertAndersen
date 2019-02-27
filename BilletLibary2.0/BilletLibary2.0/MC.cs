using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibary2._0
{
    public class MC : Køretøj
    {
        /// <summary>
        /// Alle MCer skal have en nummerplade og dato
        /// </summary>
        /// <param name="nummerPlade">Nummerpladen må ikke være mere ind 7 tegn</param>
        /// <param name="dato">Dato</param>
        public MC(string nummerPlade, DateTime dato)
            : base(nummerPlade, dato)
        {
        }

        /// <summary>
        /// Billetpris for en MC
        /// </summary>
        /// <returns></returns>
        public override double Pris()
        {
            if (Brobizz == true)
            {
                return 125 * 0.95;
            }
            return 125;
        }

        /// <summary>
        /// Køretøjstype
        /// </summary>
        /// <returns></returns>
        public override string KøretøjsType()
        {
            return "MC";
        }
    }
}
