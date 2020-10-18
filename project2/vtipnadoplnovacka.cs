using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    class Program
    {
        static void Main(string[] args)
        {

            string jmeno, nabytek, aktivita, aktivita2, zarizeni, aktivita3;
            string napoj, jidlo, aktivita4, obleceni, nabytek2, vozidlo, misto;

            Console.Write("napis jmeno: ");
            jmeno =Console.ReadLine();

            Console.Write("napis nabytek: ");
            nabytek = Console.ReadLine();

            Console.Write("napis aktivita: ");
            aktivita = Console.ReadLine();

            Console.Write("napis aktivita2: ");
            aktivita2 = Console.ReadLine();

            Console.Write("napis zarizeni: ");
            zarizeni = Console.ReadLine();

            Console.Write("napis aktivita3: ");
            aktivita3 = Console.ReadLine();

            Console.Write("napis napoj: ");
            napoj = Console.ReadLine();

            Console.Write("napis jidlo: ");
            jidlo = Console.ReadLine();

            Console.Write("napis aktivita4: ");
            aktivita4 = Console.ReadLine();

            Console.Write("napis obleceni: ");
            obleceni = Console.ReadLine();

            Console.Write("napis nabytek2: ");
            nabytek2 = Console.ReadLine();

            Console.Write("napis vozidlo: ");
            vozidlo = Console.ReadLine();

            Console.Write("napis misto: ");
            misto = Console.ReadLine();


            Console.WriteLine(jmeno + " se probudil");
            Console.WriteLine("vstal z " + nabytek);
            Console.WriteLine("protahl se a sel si " + aktivita + " zuby");
            Console.WriteLine("zasel si na " + zarizeni);
            Console.WriteLine(aktivita2 + " si ruce");
            Console.WriteLine("potom se " + aktivita3);
            Console.WriteLine("nalil si " + napoj);
            Console.WriteLine("uvaril si " + jidlo);
            Console.WriteLine(aktivita4 + " nadobi");
            Console.WriteLine("oblekl si " + obleceni);
            Console.WriteLine("zamknul " + nabytek2);
            Console.WriteLine("nasedl do " + vozidlo);
            Console.WriteLine("odjel do " + misto);



            Console.ReadLine();
        }
    }
}
