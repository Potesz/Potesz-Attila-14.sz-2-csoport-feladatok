using System;

namespace Potesz_Attila_14.sz_2_csoport_feladatok
{
    class Program
    {
        static void Main(string[] args)
        {
// fagy
            Console.WriteLine("Adja meg a hömérségletett");

            int x = Convert.ToInt32(Console.ReadLine());
            if (x < 0)
            {
                Console.WriteLine("fagy ");
            }
            else
            {
                Console.WriteLine("nem fagy");
            }
  //paritás

            Console.WriteLine("Adja meg egy egész számot");

            int i = Convert.ToInt32(Console.ReadLine());
            if (i %2==0)
            {
                Console.WriteLine("osztható");
            }
            else
            {
                Console.WriteLine("nem oszthato");      
            }

            //oszthato3

            double z = Convert.ToDouble(Console.ReadLine());
            if (z % 2 == 0)
            {
                Console.WriteLine("osztható");
            }
            else
            {
                Console.WriteLine("nem oszthato");
            }


            //hetnapjai 
            Console.WriteLine("irjon be 1-7 egy számot ") ;
           int nap = int.Parse(Console.ReadLine());
             switch (nap)
            {
              case 1: Console.WriteLine("Hétfő.") ; break;
              case 2: Console.WriteLine("Kedd.") ; break;
              case 3: Console.WriteLine("Szerda.") ; break;
              case 4: Console.WriteLine("Csütörtök.") ; break;
              case 5: Console.WriteLine("Péntek.") ; break;
              case 6: Console.WriteLine("Szombat.") ; break;
              case 7: Console.WriteLine("Vasárnap.") ; break;
             default: Console.WriteLine(" hiba ");
             break;
             }
            
 Console.ReadKey();



        }
    }
}
