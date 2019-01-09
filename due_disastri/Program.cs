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
            double calcolo_errore = 0;

            Console.WriteLine("inserire l'errore"); //chiedo di inserire l'errore per cui si desidera sapere ilmargine di errore
            errore = Convert.ToDouble (Console.ReadLine()); //inserisco l'errore
            calcolo_errore = errore * 100 * 60 * 60 * 10; //calcolo l'errore
            Console.WriteLine($"l'errore di calcolo è di {calcolo_errore} secondi"); //riporto il margine di errore creato
            Console.ReadLine();


        }
    }
}
