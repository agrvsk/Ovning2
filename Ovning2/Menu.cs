using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata;
using Ovning2.Helpers;
namespace Ovning2;
public class Menu
{
    public const string EXIT = "0";
    public const string YOUTH_OR_RETIRED = "1";
    public const string ITERATE_TO_10 = "2";
    public const string THIRD_WORD = "3";

    public void ShowMenu()
    {
        Console.WriteLine("****************");
        Console.WriteLine("***   MENU   ***");
        Console.WriteLine("****************");
        Console.WriteLine($"{EXIT}. Exit");
        Console.WriteLine($"{YOUTH_OR_RETIRED}. Ungdom eller pensionär.");
        Console.WriteLine($"{ITERATE_TO_10}. Iterera till 10.");
        Console.WriteLine($"{THIRD_WORD}. Hitta tredje ordet.");
        Console.WriteLine("****************");
    }
    public void startLoop()
    {
        bool exit = false;
        do
        {
            string val = InputControl.AskForString("Val");
            switch (val)
            {
                case EXIT:
                    exit=true;
                    break;

                case YOUTH_OR_RETIRED:
                    TicketPrice();
                    break;

                case ITERATE_TO_10:
                    iterera();
                    break;

                case THIRD_WORD:
                    third_word();
                    break;

                default:
                    Console.WriteLine("Felaktig inmatning!\n");
                    Console.WriteLine();
                    break;
            }

        } while (!exit);
    }

    public void TicketPrice()
    {
        uint age = InputControl.AskForUInt("Ålder");
        if (age < 20)
            Console.WriteLine("Ungdomspris: 80kr");
        else if (age > 64)
            Console.WriteLine("Pensionärspris: 90kr");
        else
            Console.WriteLine("Standardpris: 120kr");

        Console.WriteLine();
    }

    public void iterera()
    {
        string myText = InputControl.AskForString("sträng att repetera");
        for(int i=0; i<10; i++) { 
            Console.Write($"{i+1}. {myText}");

            if(i < 9)
                Console.Write(", ");
        }
        Console.WriteLine("\r\n");
    }

    public void third_word()
    {

        Console.WriteLine();
    }

}
