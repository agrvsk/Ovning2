using System;
using System.Reflection.Metadata;
using Ovning2.Helpers;
namespace Ovning2;
public class Menu
{
    public const string EXIT = "0";
    public const string YOUTH_OR_RETIRED = "1";
    public const string ITERATE_TO_10 = "2";
    public const string THIRD_WORD = "3";

    static public void ShowMenu()
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
    static public void startLoop()
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
                    break;

                case ITERATE_TO_10:
                    break;

                case THIRD_WORD:
                    break;

                default:
                    Console.WriteLine("Felaktig inmatning!\n");
                    break;
            }

        } while (!exit);
    }

}
