using Ovning2.Helpers;

namespace Ovning2;

internal class Program
{
    static void Main(string[] args)
    {
        Program p = new();
        p.start();
    }

    public void start()
    {
        Menu menu = new();
        menu.ShowMenu();
        menu.startLoop();

    }
}
