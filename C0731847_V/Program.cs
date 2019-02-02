using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0731847_V
{
    class Program
    {
        static void Main(string[] args)
        {
            countryside c = new countryside();
            c.run();

        }
        class Village
        {
            public bool isAstrildeHere;
            public Village nextVillage;
            public Village prevVillage;
            public string Villagename;

        }

        class countryside
        {
            Village maple;
            Village Toronto;
            Village ajax;
            public void run()
            {
                maple = new Village();
                Toronto = new Village();
                ajax = new Village();
                maple.Villagename = "Toronto";
                maple.nextVillage = Toronto;
            }
        }
        class LearningExperiment
        {
            private Village Toronto;

            public void run()
            {
                Village Toronto;
                Toronto = new Village();
                Village a, b, c;
                Toronto.Villagename = "version A";
                a = Toronto;
                Console.WriteLine(a.Villagename);
                Toronto = new Village();
                Toronto = new Village();
                Toronto.Villagename = "version B";
                b = Toronto;
                Console.WriteLine(b.Villagename);
                Toronto = new Village();
                Toronto.Villagename = "version C";
                c = Toronto;
                Console.WriteLine(c.Villagename);
            }
            public void travel()
            {
                Village currentvillage = Toronto;
                while (!currentvillage.isAstrildeHere)
                {
                    if (currentvillage.isAstrildeHere)
                        Console.WriteLine("You found Astrilde in " + currentvillage);
                    else
                        currentvillage = currentvillage.nextVillage;

                }

            }
        }
    }
}

