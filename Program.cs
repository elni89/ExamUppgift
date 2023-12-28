using System;
using System.Collections.Generic;
using System.Threading;

namespace ExaminerandeUppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            // Välkomnande meddelande
            Console.WriteLine("Hej och välkommen till min miniräknare");
            Thread.Sleep(1000);

            for (int i = 0; i < 45; i++)
            {
                Console.Write("=");
                Thread.Sleep(10);
            }
            Console.WriteLine();

            // En lista för att spara historik för räkningar
            List<string> historik = new List<string>();

            while (true)
            {
            felaktigt:
                // Användaren matar in tal och matematisk operation
                // OBS! Användaren måste mata in ett tal för att kunna ta sig vidare i programmet!
                double tal1 = 0;
                double tal2 = 0;
                double resultat = 0;
                string tecken = "";

                Console.WriteLine("Skriv in tal 1: ");
                string input1 = Console.ReadLine();

                if (!double.TryParse(input1, out tal1))
                {
                    Console.WriteLine("Felaktigt format för tal 1. Försök igen.");
                    Console.WriteLine("Tryck för att börja om");
                    Console.ReadKey();
                    Console.Clear();
                    goto felaktigt;
                }

                Console.WriteLine("Skriv in en matematisk operation (+, -, /, *): ");
                tecken = Console.ReadLine();

                if (tecken != "+" && tecken != "-" && tecken != "/" && tecken != "*")
                {
                    Console.WriteLine("Felaktigt format för operation. Försök igen.");
                    Console.WriteLine("Tryck för att börja om");
                    Console.ReadKey();
                    Console.Clear();
                    goto felaktigt;
                }

                Console.WriteLine("Skriv in tal 2: ");
                string input2 = Console.ReadLine();

                if (!double.TryParse(input2, out tal2))
                {
                    Console.WriteLine("Felaktigt format för tal 2. Försök igen.");
                    Console.WriteLine("Tryck för att börja om");
                    Console.ReadKey();
                    Console.Clear();
                    goto felaktigt;
                }

                // Ifall användaren skulle dela med 0, visa Ogiltig inmatning!
                if (tecken == "/" && tal2 == 0 || tal1 == 0)
                {
                    Console.WriteLine("Du kan inte dela med 0. Försök igen.");
                    Console.WriteLine("Tryck för att börja om");
                    Console.ReadKey();
                    Console.Clear();
                    goto felaktigt;
                }

                //beräkna och skriv ut resultat, samt spara resultat i listan
                // Lägga resultat till listan
                switch (tecken)
                {
                    case "+":
                        resultat = tal1 + tal2;
                        historik.Add($"{tal1} {tecken} {tal2} = {resultat}");
                        break;

                    case "-":
                        resultat = tal1 - tal2;
                        historik.Add($"{tal1} {tecken} {tal2} = {resultat}");
                        break;

                    case "*":
                        resultat = tal1 * tal2;
                        historik.Add($"{tal1} {tecken} {tal2} = {resultat}");
                        break;

                    case "/":
                        resultat = tal1 / tal2;
                        historik.Add($"{tal1} {tecken} {tal2} = {resultat}");
                        break;
                }

                // Visa resultat
                // Fråga användaren om den vill visa tidigare resultat.
                // Visa tidigare resultat
                // Fråga användaren om den vill avsluta eller fortsätta.

            }
        }
}
