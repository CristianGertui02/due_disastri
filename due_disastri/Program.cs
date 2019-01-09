using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace due_disastri
{
    class Program
    {
        static void Main(string[] args)
        {
            double errore=0; //inizializzo l'errore che verrà inserito in seguito
            double ore=0;
            double calcolo_errore = 0;
            double spazio=0;
            double velocità=0;

             Console.WriteLine("inserire le ore dell'attivazione del patriot"); //chiedo di inserire le ore in cui è stato attivo il patriot

            ore = Convert.ToDouble (Console.ReadLine()); //inserisco le ore

            Console.WriteLine("inserire l'errore"); //chiedo di inserire l'errore per cui si desidera sapere ilmargine di errore

            errore = Convert.ToDouble (Console.ReadLine()); //inserisco l'errore

            calcolo_errore = errore * ore * 60 * 60 * 10; //calcolo l'errore

            calcolo_errore=Math.Round(calcolo_errore,2); //approssimo il numero alla seconda cifra decimale

            Console.WriteLine($"l'errore di calcolo è di {calcolo_errore} secondi"); //riporto il margine di errore creato

            Console.WriteLine("inserire la velocità del missile"); //chiedo di inserire la velocità del missile

            velocità = Convert.ToDouble (Console.ReadLine()); //inserisco la velocità

            spazio=velocità*calcolo_errore; //calcolo lo spazio percorso nel tempo di errore

            Console.WriteLine($" in {calcolo_errore} secondi il issile ha percorso {spazio} metri"); //restituisci lo spazio percorso
            
          
            Console.ReadLine();


        }
    }
}
