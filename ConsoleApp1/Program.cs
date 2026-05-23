using System;
using System.ComponentModel;

class Taschenrechner
{
    static void Main(String[]args)
    {
        do
        {
            Console.WriteLine("***Taschenrechner***");

            double zahl1 = 0;
            double zahl2 = 0;
            double ergebnis = 0;
            String rechenzeichen;

            //Die Zahlen werden übernommen
            Console.WriteLine("Gib die erste Zahl ein: ");
            zahl1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Gib die erste Zahl ein: ");
            zahl2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Gib ein Rechenzeichen ein: ");

            //Rechnung
            switch (rechenzeichen = Convert.ToString(Console.ReadLine()))
            {
                case "+":
                    ergebnis = zahl1 + zahl2;
                    Console.WriteLine(Convert.ToDouble(ergebnis));
                    break;
                case "*":
                    ergebnis = zahl1 * zahl2;
                    Console.WriteLine(Convert.ToDouble(ergebnis));
                    break;
                case "-":
                    ergebnis = zahl1 - zahl2;
                    Console.WriteLine(Convert.ToDouble(ergebnis));
                    break;
                case "/":
                    if (zahl2 == 0)
                    {
                        Console.WriteLine("Man darf nicht durch 0 teilen.");
                    }
                    else
                    {
                        ergebnis = zahl1 / zahl2;
                        Console.WriteLine(Convert.ToDouble(ergebnis));
                    }
                    break;
                default:
                    Console.WriteLine("Das ist kein Rechenzeichen!");
                    break;
            }
            Console.WriteLine("Willst du fortsetzen? J - Ja oder N - Nein");
        } while (Console.ReadLine().ToUpper() == "J");
        Console.WriteLine("Tschüss");
      
        Console.ReadKey();
    }
}