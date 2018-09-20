using System;

namespace First
{
    class Program
    {
        /* Maak een array en initialiseer deze op de getallen 1 tot en met 10.
         * Lees de array a als volgt uit: 1 2 3 ... 10
		 */
        public static void ToonArray1()
        {
            // schrijf hier je code
        }

        /* Maak een array van 5 doubles en lees deze als volgt uit: 1.1 2.5 2.3 5.7 2.1 
         * Opmerking: gebruik de waarden uit het voorbeeld.
		 */
        public static void ToonArray2()
        {
            // schrijf hier je code
        }

        /* Maak een array van 4 strings en lees deze als volgt uit: noord oost zuid west
		 * Opmerking: gebruik de waarden uit het voorbeeld.
		 */
        public static void ToonArray3()
        {
            // schrijf hier je code
        }

        /* Tel beide arrays (functieargumenten) samen in een derde array en geef deze resultaatarray
         * als functieresultaat. 
		 */
        public static int[] TelSamen(int[] a, int[] c)
        {
            int[] som = new int[10];

            // schrijf hier je code

            return som;
        }
        /* Bereken de som van de elementen van de array a (functieargument) en toon deze som. 
		 */
        public static int BerekenSom(int[] a)
        {
            // schrijf hier je code

            return 0;
        }

        /* Bereken het gemiddelde van de elementen van de array a (functieargument) en toon deze som. 
		 */
        public static double BerekenGem(int[] a)
        {
            // schrijf hier je code

            return 0;
        }

        /* Declareer een lege array b met evenveel elementen als er in array a (functieargument) zijn.
         * Kopieer array a (functieargument) omgekeerd in een tweede array. Geef deze array als functieresultaat. 
		 */
        public static int[] DraaiOm(int[] a)
        {
            int[] b = new int[5];

            // schrijf hier je code

            return b;
        }

        /* Ga na of functieargument getal in de array a voorkomt. Geeft als functieresultaat True indien het getal
         * in de array voorkomt, false indien het niet in de array zit. 
		 */
        public static bool ZoekGetal1(int[] a, int getal)
        {
            // schrijf hier je code

            return true;
        }

        /* Pas vorige oefening aan: geef het aantal keren dat het te zoeken getal in de array voorkomt als functieresultaat.
         * Indien het zoekGetal niet in de array zit, geef je 0 als functieresultaat.
		 */
        public static int ZoekGetal2(int[] a, int getal)
        {
            // schrijf hier je code

            return 0;
        }

        /* Zoek het grootste element in array a (functieargument). Geef dit grootste element als functieresultaat. 
		 */
        public static int ZoekGrootste(int[] a)
        {
            // schrijf hier je code

            return 0;
        }

        /* Tel hoeveel negatieve en hoeveel positieve elementen er in de array zitten.
         * Beschouw 0 als een positief getal.
         * Geef het resultaat onder de vorm van volgende string als functieresultaat:
         * Neg:3 Pos:7
         * */

        public static string TelNegPos(int[] a)
        {
            // schrijf hier je code

            return "";
        }

        static void Main(string[] args)
        {
            // Volgende array wordt als argument doorgegeven aan de functie:
            int[] nummers = new int[] { -5, 3, 38, 3, 15, -6, -17, 3, 19, 3 };
            int[] b = new int[10];
            int[] c = new int[] { 3, 2, 5, 4, 3, 7, 2, 1, 9, 1 };

            Console.WriteLine("Naam Oefening: ToonArray1");
            Console.WriteLine("Verwacht Resultaat:");
            Console.WriteLine("1 2 3 4 5 6 7 8 9 10");
            Console.WriteLine("Jouw resultaat");
            Program.ToonArray1();
            Console.WriteLine("\n");
            Console.WriteLine("Naam Oefening: ToonArray2");
            Console.WriteLine("Verwacht Resultaat:");
            Console.WriteLine("1,1 2,5 2,3 5,7 2,1");
            Console.WriteLine("Jouw resultaat");
            Program.ToonArray2();
            Console.WriteLine("\n");
            Console.WriteLine("Naam Oefening: ToonArray3");
            Console.WriteLine("Verwacht Resultaat:");
            Console.WriteLine("noord oost zuid west");
            Console.WriteLine("Jouw resultaat");
            Program.ToonArray3();
            Console.WriteLine("\n");
            Console.WriteLine("Naam Oefening: DraaiOm");
            Console.WriteLine("Verwacht Resultaat:");
            Console.WriteLine("3 19 3 -17 -6 15 3 38 3 -5");
            Console.WriteLine("Jouw resultaat");
            b = Program.DraaiOm(nummers);
            foreach (int num in b) { Console.Write("{0} ", num); }
            Console.WriteLine("\n");
            Console.WriteLine("Naam Oefening: TelSamen");
            Console.WriteLine("Verwacht Resultaat:");
            Console.WriteLine("-2 5 43 7 18 1 -15 4 28 4");
            Console.WriteLine("Jouw resultaat");
            b = Program.TelSamen(nummers, c);
            foreach (int num in b) { Console.Write("{0} ", num); }
            Console.WriteLine("\n");
            Console.WriteLine();
            Console.WriteLine("Naam Oefening  \t Verwacht Resultaat \tJouw Resultaat");
            Console.WriteLine("BerekenSom \t 56 \t\t\t" + Program.BerekenSom(nummers));
            Console.WriteLine("BerekenGem \t 5,6 \t\t\t" + Program.BerekenGem(nummers));
            Console.WriteLine("ZoekGetal1 \t True \t\t\t" + Program.ZoekGetal1(nummers, 19));
            Console.WriteLine("ZoekGetal1 \t False \t\t\t" + Program.ZoekGetal1(nummers, 20));
            Console.WriteLine("ZoekGetal2 \t 4 \t\t\t" + Program.ZoekGetal2(nummers, 3));
            Console.WriteLine("ZoekGetal2 \t 0 \t\t\t" + Program.ZoekGetal2(nummers, 70));
            Console.WriteLine("ZoekGrootste \t 38 \t\t\t" + Program.ZoekGrootste(nummers));
            Console.WriteLine("TelNegPos \t Neg:3 Pos:7 \t\t" + Program.TelNegPos(nummers));

            Console.ReadKey();
        }
    }
}
