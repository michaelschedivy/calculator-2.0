using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalkulačka_1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string uvod = "Zadejte znak kterým budete počítat.";
            Console.Out.WriteLine(uvod);

            string znak = Console.ReadLine();

            if (znak == "+")
            {

                string aa1 = "Zadejte první sčítanec.";
                Console.Out.WriteLine(aa1);

                string scitanec1 = Console.ReadLine();
                int scitanecb1 = int.Parse(scitanec1);


                string aa2 = "Zadejte druhý sčítanec.";
                Console.Out.WriteLine(aa2);

                string scitaneca2 = Console.ReadLine();
                int scitanecb2 = int.Parse(scitaneca2);


                string va = "Součet je:";
                Console.Out.WriteLine(va);

                int soucet = scitanecb1 + scitanecb2;
                Console.Out.WriteLine(soucet);

            }
            else if (znak == "-")
            {

                string ba1 = "Zadejte menšenec.";
                Console.Out.WriteLine(ba1);

                string mensenec = Console.ReadLine();
                int mensenecb = int.Parse(mensenec);


                string ba2 = "Zadejte menšitel.";
                Console.Out.WriteLine(ba2);

                string mensitel = Console.ReadLine();
                int mensitelb = int.Parse(mensitel);


                string vb = "Rozdíl je:";
                Console.Out.WriteLine(vb);

                int rozdil = mensenecb - mensitelb;
                Console.Out.WriteLine(rozdil);
            }
            else if (znak == "*")
            {

                string ca1 = "Zadejte první činitel.";
                Console.Out.WriteLine(ca1);

                string cinitel1 = Console.ReadLine();
                int cinitelb1 = int.Parse(cinitel1);


                string ca2 = "Zadejte druhý činitel.";
                Console.Out.WriteLine(ca2);

                string cinitel2 = Console.ReadLine();
                int cinitelb2 = int.Parse(cinitel2);


                string vc = "Součin je:";
                Console.Out.WriteLine(vc);

                int soucin = cinitelb1 * cinitelb2;
                Console.Out.WriteLine(soucin);
            }

            else if (znak == "/")
            {

                string da1 = "Zadejte dělenec.";
                Console.Out.WriteLine(da1);

                string delenec = Console.ReadLine();
                int delenecb = int.Parse(delenec);


                string da2 = "Zadejte dělitel.";
                Console.Out.WriteLine(da2);

                string delitel = Console.ReadLine();
                int delitelb = int.Parse(delitel);


                string vd = "Podíl je:";
                Console.Out.WriteLine(vd);

                int podil = delenecb / delitelb;
                Console.Out.WriteLine(podil);
            }
            else
            {

                string spatnyznak = "Zadali jste špatný znak!";
                Console.Out.WriteLine(spatnyznak);
            }
            string off = "stisknutim klávesy ENTER ukončíte program, pro vypočítání dalšího příkladu program znova zapněte.";
            Console.Out.WriteLine(off);

            string off2 = Console.ReadLine();
            
           
        }  
         


    }
}
