using System;

namespace BilletLibary2._0
{
    public abstract class Køretøj
    {



        private string _nummerplade;


        /// <summary>
        /// En bool for at se om man har en Brobizz (true eller false)
        /// </summary>
        public bool Brobizz { get; set; }

        public DateTime Dato { get; set; }


        /// <summary>
        /// Alle køretøjer skal have en nummerplade og en dato
        /// </summary>
        /// <param name="nummerplade">En nummerplade</param>
        /// <param name="dato">En dato</param>
        public Køretøj(string nummerplade, DateTime dato)
        {

            _nummerplade = nummerplade;

            if (nummerplade.Length > 7)
            {
                throw new ArgumentException();
            }
            Dato = dato;
            Brobizz = false;
        }


        /// <summary>
        /// Nummerpladen må ikke være mere ind 7 tegn
        /// </summary>
        public string Nummerplade
        {
            get
            {
                    return _nummerplade;
            }
            set { _nummerplade = value; }
        }

        /// <summary>
        /// Pris for billet
        /// </summary>
        /// <returns></returns>
        public abstract double Pris();

        /// <summary>
        /// Hvilken slags køretøj vi har med at gøre
        /// </summary>
        /// <returns></returns>
        public abstract string KøretøjsType();

    }
}
