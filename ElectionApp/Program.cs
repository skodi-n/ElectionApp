using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string K1Name = "Trump";
            string K2Name = "Harris";
            string P1Name = "Republicans";
            string P2Name = "Democratic";
            
            
            Kandidat kandidat1 = new Kandidat(K1Name, P1Name);
            Kandidat kandidat2 = new Kandidat(K2Name, P2Name);
            Wahl wahl1 = new Wahl(K1Name, K2Name, P1Name, P2Name);
            
            
            wahl1.KandidatHinzufuegen();
            
            wahl1.StimmeAbgeben(K1Name);
            wahl1.StimmeAbgeben(K2Name);
            wahl1.StimmeAbgeben(K1Name);
            Console.WriteLine(wahl1.Ergebnis());
            


        }
    }
}