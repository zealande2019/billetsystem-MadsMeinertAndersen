using System;

namespace BilletLibary2._0
{
    public abstract class Køretøj
    {


        private string _nummerplade;

        public bool Brobizz { get; set; }

        public DateTime Dato { get; set; }

        public Køretøj(string nummerplade, DateTime dato)
        {
            _nummerplade = nummerplade;
            Dato = dato;
            Brobizz = false;
        }

        public string Nummerplade
        {
            get
            {
                if (_nummerplade.Length > 7)
                {
                    throw new ArgumentException();
                }
                else

                    return _nummerplade;
            }
            set { _nummerplade = value; }
        }

        public abstract double Pris();

        public abstract string KøretøjsType();

    }
}
