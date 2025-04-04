using Ovning2.Helpers;

namespace Ovning2;

internal class Program
{
    static void Main(string[] args)
    {
        Menu menu = new();
        menu.showMenu();
        menu.startLoop();
    }
}
