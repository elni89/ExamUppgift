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

            // Användaren matar in tal och matematiska operation
            // OBS! Användaren måsta mata in ett tal för att kunna ta sig vidare i programmet!
            // Ifall användaren skulle dela med 0 visa Ogiltig inmatning!
            // Lägga resultat till listan
            // Visa resultat
            // Fråga användaren om den vill visa tidigare resultat.
            // Visa tidigare resultat
            // Fråga användaren om den vill avsluta eller fortsätta.

        }
    }
}
