using System;
using BilletLibary2._0;

namespace StoreBaeltBilletLibrary
{
    public class WeekendsRabat
    {

        public double WeekendRabat(Bil testBil)
        {

           
            if (testBil.Dato.DayOfWeek == DayOfWeek.Saturday 
                || testBil.Dato.DayOfWeek == DayOfWeek.Sunday)
            {
                return testBil.Pris() * 0.8;
            }


            return testBil.Pris();
        }

    }
}
