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
            countryside c  = new countryside();
        }
        class Village
        {
          public  bool isAstrildeHere;
           public  Village nextVillage;
          public  Village prevVillage;
          public  string Villagename;

        }
        class countryside
        {
            Village maple;
            Village Toronto;
            Village ajax;
            public void run()
            {
                maple = new Village();
                maple.Villagename = "Toronto";
                maple.nextVillage = Toronto;
            }
        }
    }
}
