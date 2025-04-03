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

            Console.WriteLine("Felaktig input...");
            Console.WriteLine();

        } while (true);
    }
    public static uint AskForUInt(string prompt)
    {
        do
        {
            //string s = AskForString(prompt);
            if (uint.TryParse(AskForString(prompt) , out uint retur))
                return retur;

            Console.WriteLine("Felaktig input...");
            Console.WriteLine();

        } while (true);

        


    }
}
