using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.PLL.Views
{
    public class MainMenu
    {
        public void Show()
        {
            Console.WriteLine("Log in (press 1)");
            Console.WriteLine("Sign up (press 2)");

            switch (Console.ReadLine())
            {
                case "1":
                    Program.authenticationViews.Show();
                    break;
                case "2":
                    Program.registrationViews.Show();
                    break;
            }
        }
    }
}
