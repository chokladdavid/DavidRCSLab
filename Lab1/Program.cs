using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            double dowJonesSink = 4.6,
                   nasdaqSink = 4.1, 
                   stockholmSink = -2.4, 
                   milanoSink = -6.7, 
                   parisSink = -5.5;
            Console.WriteLine("Dow Jones sjönk med {0} procent och Nasdaq med {1} procent.\r\nStockholm {2} procent, Milano {3} procent, Paris {4} procent.", dowJonesSink, nasdaqSink, stockholmSink, milanoSink, parisSink);

            dowJonesSink = 2.3;
            nasdaqSink = 3.7;
            stockholmSink = -1.0;
            milanoSink = 0.3;
            parisSink = -7.4;
            Console.WriteLine("Dow Jones sjönk med {0} procent och Nasdaq med {1} procent.\r\nStockholm {2} procent, Milano {3} procent, Paris {4} procent.", dowJonesSink, nasdaqSink, stockholmSink, milanoSink, parisSink);

            string talet = "PI";
            const double piMedeum = 3.141592654, 
                   piShort = 3.14;
            int piShortest = 3;
            Console.WriteLine($"Talet {talet} är cirka {piMedeum} men kan avrundas till {piShort} och kan lite grovt skrivas som {piShortest}.");

            talet = "X";
            //piMedeum = 24.8753108642;
            //piShort = 5.1483;
            piShortest = 1;
            Console.WriteLine($"Talet {talet} är cirka {piMedeum} men kan avrundas till {piShort} och kan lite grovt skrivas som {piShortest}.");

            string jonas = "Han heter Jonas och bor i Helsingborg på Statterna vid Hemköp.";

            Console.WriteLine(jonas);

            jonas = "Han heter Jonas och bor i Västervik på Lysinsvägen vid Torino.";
            Console.WriteLine(jonas);

        }
    }
}
