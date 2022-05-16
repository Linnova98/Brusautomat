using System;
using System.Collections.Generic;
using System.Diagnostics;

//Implementer en brusautomat. Ulike drikker har ulik pris. Automaten har en lagerbeholdning. Man kan putte på mynter (1kr, 5kr, 10kr, 20kr).
//Man trykker på en knapp for en bestemt drikk - hvis man har puttet på nok får man denne og saldoen reduseres tilsvarende.
//Det finnes en knapp for å få gjeldende saldo tilbake.

namespace Kodetime09._05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var display = new Display();

            Console.WriteLine(display);
        }
    }

}