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

        }
        class village
        {
          public  bool isAstrildeHere;
           public  village nextvillage;
          public  village prevvillage;
          public  string villagename;

        }
        class countryside
        {
            village maple;
            village Toronto;
            village ajax;
            public void run()
            {
                maple = new village();
                maple.villagename = "Toronto";
                maple.nextvillage = Toronto;
            }
        }
    }
}
