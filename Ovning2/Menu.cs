using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata;
using Ovning2.Helpers;
namespace Ovning2;
public class Menu
{
    //Menyalternativen
    public const string EXIT = "0";
    public const string YOUTH_OR_RETIRED = "1";
    public const string GROUP = "2";    
    public const string ITERATE_TO_10 = "3";
    public const string THIRD_WORD = "4";

    /* Visar menyn en gång */
    public void showMenu()
    {
        Console.WriteLine("****************************");
        Console.WriteLine("*********   MENY   *********");
        Console.WriteLine("****************************");
        Console.WriteLine($"{EXIT}. Avsluta.");
        Console.WriteLine($"{YOUTH_OR_RETIRED}. Ungdom eller pensionär.");
        Console.WriteLine($"{GROUP}. Gruppris.");
        Console.WriteLine($"{ITERATE_TO_10}. Iterera till 10.");
        Console.WriteLine($"{THIRD_WORD}. Hitta tredje ordet.");
        Console.WriteLine("****************************");
    }

    /* Loopar och utför menyalternativen 
     * tills användaren väljer 0 
     * för att avsluta.*/
    public void startLoop()
    {
        bool exit = false;
        do
        {
            string val = InputControl.AskForString("menyalternativ [0-4]");
            switch (val)
            {
                case EXIT:
                    exit=true;
                    break;

                case YOUTH_OR_RETIRED:
                    showTicketPrice();
                    break;

                case GROUP:
                    showGroupPrice();
                    break;

                case ITERATE_TO_10:
                    doIiteration();
                    break;

                case THIRD_WORD:
                    findThirdWord();
                    break;

                default:
                    Console.WriteLine("Menyalternativet saknas!");
                    Console.WriteLine();
                    break;
            }

        } while (!exit);
    }

    /*Biljettpris och biljettyp returneras från Tickets.getTicketForAge.*/
    public void showTicketPrice()
    {
        int age = InputControl.AskForInt("Ålder");
        int price = 0;
        Tickets.getTicketForAge(age, ref price, out string type );
        Console.WriteLine($"{type}: {price}");
        Console.WriteLine();
    }
    /*Biljettpris summeras eftersom ref används i metodens variabler.*/
    public void showGroupPrice() 
    {
        uint antPersoner = InputControl.AskForUInt("antal besökare");
        int price=0;
        for (uint i=0; i< antPersoner; i++) 
        {
            uint age = InputControl.AskForUInt($"ålder för person {i+1}" );
            Tickets.getTicketForAge((int)age, ref price, out string type);
        }
        Console.WriteLine();
        Console.WriteLine($"Antal besökare: {antPersoner} ");
        Console.WriteLine($"Totalbelopp: {price}");
        Console.WriteLine();
    }
    //Skriver användarens inmatade ord 10 ggr. på samma rad.
    public void doIiteration()
    {
        string myText = InputControl.AskForString("sträng att repetera");
        for(int i=0; i<10; i++) { 
            Console.Write($"{i+1}. {myText}");

            //Skriver ett komma emellan alla (men inte efter den sista).
            if(i < 9)
                Console.Write(", ");
        }
        Console.WriteLine("\r\n");
    }
    //Hitta tredje ordet i användarens inmatade sträng.
    public void findThirdWord()
    {
        string[] retur = InputControl.AskForStringArray("en mening med minst tre ord",3);
        if (retur.Length >= 3)
            Console.WriteLine("Tredje ordet är: " + retur[2]);
        Console.WriteLine();
    }

}
