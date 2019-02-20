using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textadventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo, ist da jemand? Ich bin hier auf einer einsammen Insel gestrandet.");
            Console.WriteLine("Wie ist dein Name?");
            string ichname = (Console.ReadLine());
            Console.WriteLine("Gute Tag " + ichname);
            Console.WriteLine("Mein Name ist Hans, zum Glück bist du da.");
            Console.WriteLine(ichname + " wie heißt diese Insel?");
            string inselname = (Console.ReadLine());
            Console.WriteLine(inselname + " interessanter Name, klingt nach einer Karibikinsel");
            Console.WriteLine("Hier vorne, wie heißt diese Frucht?");
            string fruchtname = (Console.ReadLine());
            Console.WriteLine("Die " + fruchtname + " sieht lecker aus, ich denke ich probiere mal.");
            Console.WriteLine("Hans bekommt einen Anfall schnell " + ichname + " hilf ihm" + " er hat sich an der " + fruchtname + " vergiftet");
            Console.ReadKey();
        }
    }
}
