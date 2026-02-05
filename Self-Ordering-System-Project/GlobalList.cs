using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Ordering_System_Project
{
    internal static class GlobalList
    {
        public static List<Item> items = new List<Item>();
        public static bool closeApp = true;
        public static string orderState;
    }
}
