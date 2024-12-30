using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TannenBaum_console
{
    internal class Model
    {

        public void Menue()
        {
            Console.WriteLine("MENUE");
            Console.WriteLine("UP ------------Type--- 1");
            Console.WriteLine("Down ----------Type--- 2");
            Console.WriteLine("TannenBaum ----Type--- 3");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Gebe eine Zahl ein wie groß der TannenBaum sein soll!");
            int z = Convert.ToInt32(Console.ReadLine());
            if (x == 1)
            {
                Up(z);
            }
            else if (x == 2)
            {
                Down(z);
            }
            else if (x == 3)
            {
                Baum(z);
            }
            else
            {
                Console.WriteLine("Falsche Zahl!");
                Menue();
            }
        }

        public void Down(int zahl)
        {
            string stern = "*";
            for (int i = 0; i < zahl; i++)
            {
                Console.WriteLine(stern);
                stern += "*"; 
            }
            Console.WriteLine("\n\n");
            Menue();
        }

        public void Up(int zahl)
        {
            string lucke = " ";
            string stern = "*";
            for (int i = 1; i < zahl; i++)
            {
                lucke += " ";
            }
            for (int i = 0; i < zahl; i++)
            {
                Console.Write(lucke);
                Console.WriteLine(stern);
                lucke = lucke.Remove(0, 1);
                stern += "*";
            }
            Console.WriteLine("\n\n");
            Menue();
        }

        public void Baum(int zahl)
        {
            string lucke = " ";
            string lucke2 = " ";
            string stern = "*";
            string stern2 = "*";
            for (int i = 1; i < zahl; i++)
            {
                lucke += " ";
            }
            for (int i = 1; i < zahl - zahl/5; i++)
            {
                lucke2 += " ";
            }
            for (int i = 0; i < zahl; i++)
            {
                
                Console.Write(lucke);
                Console.Write(stern);
                Console.WriteLine(stern);
                lucke = lucke.Remove(0, 1);
                stern += "*";
            }
            for (int i = 0; i < zahl/4; i++)
            {
                stern2 += "*";
            }
            for (int i = 0; i < zahl / 4; i++)
            {
                Console.Write(lucke2);
                Console.WriteLine(stern2);
            }
            Console.WriteLine("\n\n");
            Menue();

        }
        

    }
}
