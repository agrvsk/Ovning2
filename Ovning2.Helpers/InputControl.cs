namespace Ovning2.Helpers;

public class InputControl
{
    public static string AskForString(string prompt)
    {
        string retur;
        do
        {
            Console.Write($"Ange {prompt}:");
            retur = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(retur))
                return retur;

        } while (true);
        

    }
}
