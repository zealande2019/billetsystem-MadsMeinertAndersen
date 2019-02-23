using System;
using BilletLibary2._0;

namespace OeresundLibary
{
    public class OeresundPriser
    {
        public double Priser(Køretøj køretøj)
        {
            if (køretøj.KøretøjsType() == "Bil")
            {
                if (køretøj.Brobizz == true)
                {
                    return 161;
                }

                return 410;
            }

            if (køretøj.KøretøjsType() == "MC")
            {
                if (køretøj.Brobizz == true)
                {
                    return 73;
                }

                return 210;
            }

            return 1;
        }

        public string Køretøj(Køretøj køretøj)
        {
            if (køretøj.KøretøjsType() == "Bil")
            {
                return "Øresund Bil";
            }

            return "Øresund MC";
        }
    }
}
