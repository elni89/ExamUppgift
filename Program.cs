using System;

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







//using System;

//public class PersonnummerValidator
//{
//    public static bool Validate(string personnummer)
//    {
//        //Här är koden för att ta bort , mellanslag och - tejcnet.
//        personnummer = personnummer.Replace(" ", "").Replace("-", "");

//        //Vi kontrolelraer så att personummret är en längd av 10siforr
//        if (personnummer.Length != 10)
//        {
//            return false;
//        }

//        //Här kotrnollerar vi att personummret bara innehåller sifforor
//        foreach (char c in personnummer)
//        {
//            if (!char.IsDigit(c))
//            {
//                return false;

//            }
//        }

//        //Här använder vi formlen för att beräkna 4sista
//        int[] factors = { 2, 1, 2, 1, 2, 1, 2, 1, 2, 1 };
//        int sum = 0;

//        for (int i = 0; i < personnummer.Length - 1; i++)
//        {
//            int digit = int.Parse(personnummer[i].ToString());
//            int product = digit * factors[i];

//            sum += product >= 10 ? product - 9 : product;
//        }

//        //Formlene föra tt kontrolerla kontrolsliffran
//        int calculatedChecksum = 10 - (sum % 10);
//        int givenChecksum = int.Parse(personnummer[personnummer.Length - 1].ToString());

//        return calculatedChecksum == givenChecksum;

//    }
//}



//public class Program
//{
//    public static void Main(string[] args)
//    {
//        Console.WriteLine("Skriv in ditt personnummer (ååmmdd-xxxx):");
//        string personnummer = Console.ReadLine();

//        if (PersonnummerValidator.Validate(personnummer))
//        {
//            Console.WriteLine("Personnumret är giltigt.");
//        }
//        else
//        {
//            Console.WriteLine("Personnumret är ogiltigt.");
//        }
//    }
//}