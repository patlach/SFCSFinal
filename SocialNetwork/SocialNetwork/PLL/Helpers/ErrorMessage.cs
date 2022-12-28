using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.PLL.Helpers
{
    public class ErrorMessage
    {
        public static void Show(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
