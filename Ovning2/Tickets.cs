using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning2;
/*
 intern helperklass som hanterar allt som har med biljetter att göra.
 */
internal class Tickets
{
    const int CHILDREN = 0;
    const int YOUTH = 80;
    const int RETIRED = 90;
    const int STANDARD = 120;
    const int OLDIES = 0;

    public static void getTicketForAge(int age, ref int price, out string type)
    {
        type = string.Empty;
        if (age < 5)
        {
            price += CHILDREN;
            type = "Barnpris";
        }
        else if (age < 20)
        {
            price += YOUTH;
            type = "Ungdomspris";
        }
        else if (age > 100)
        {
            price += OLDIES;
            type = "Åldringspris";
        }
        else if (age > 64)
        {
            price += RETIRED;
            type = "Pensionärspris";
        }
        else
        {
            price += STANDARD;
            type = "Standardpris";
        }

    }
}
