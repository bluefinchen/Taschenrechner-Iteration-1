using System;

namespace Taschenrechner_Iteration_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Anrede
            Console.WriteLine("Hallo, ich bin Rechni, dein Taschenrechner. Bitte drücke Enter um weiter zu machen. :-)");
            Console.ReadKey();

            // User Story "Addieren": Als Benutzer möchte ich zwei Zahlen eingeben, um deren Summe berechnen zu lassen.
            Console.Write("Geben Sie die erste Zahl zwischen 0 und 10 ein: ");
            string zahl1 = Console.ReadLine();
            Console.Write("Geben Sie die zweite Zahl zwischen 0 und 10 ein: ");
            string zahl2 = Console.ReadLine();

            // Umwandlung Text in Ganzzahlen
            int ganzzahl1 = Convert.ToInt32(zahl1);
            int ganzzahl2 = Convert.ToInt32(zahl2);


            // Überprüfung der Umwandlung beider Zahlen
            //Console.WriteLine("Umgewandelte erste Zahl in Ganzzahl: {0}", zahl1);
            //Console.WriteLine("Umgewandelte zweite Zahl in Ganzzahl: {0}", zahl2);
            //Console.ReadKey();

            // Berechnung Addition erste Zahl und zweite Zahl
            int summe = ganzzahl1 + ganzzahl2;

            // Ausgabe der Summe
            Console.WriteLine("Summe aus erster Zahl und zweiter Zahl: {0}", summe);
            Console.ReadLine();
        }
    }
}
