/*
 Helperklass för användarinmatning
 */
namespace Ovning2.Helpers;
public class InputControl
{
    /**
     * @input Prompt
     * @retur en validerad ifylld sträng. 
    **/
    public static string AskForString(string prompt)
    {
        do
        {
            Console.Write($"Ange {prompt}: ");
            string? retur = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(retur))
                return retur;

            Console.WriteLine("Felaktig input...");

        } while (true);
    }
    /******
     * @input Prompt
     * @input minimiOrd 
     * @retur En validerad sträng som innehåller minst angivet antal ord.
     * ******/
    public static string[] AskForStringArray(string prompt, int minimiOrd)
    {
        string[] retur;
        do
        {
            string myString = AskForString(prompt);

            retur = myString.Split(' ', minimiOrd + 1, StringSplitOptions.RemoveEmptyEntries);
            if (retur.Length >= minimiOrd)
                return retur;

            
            Console.WriteLine("Meningen var för kort!");

        } while (true);
    }
    /*
     @input Prompt
     @retur En validerad uint
     */
    public static uint AskForUInt(string prompt)
    {
        do
        {
            if (uint.TryParse(AskForString(prompt), out uint retur))
                return retur;

            Console.WriteLine("Felaktig input...");

        } while (true);
    }
    /*
     @input Prompt
     @retur En validerad int
     */
    public static int AskForInt(string prompt)
    {
        do
        {
            if (int.TryParse(AskForString(prompt), out int retur))
                return retur;

            Console.WriteLine("Felaktig input...");

        } while (true);
    }


}
