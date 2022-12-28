using SocialNetwork.BLL.Services;
using SocialNetwork.BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using SocialNetwork.BLL.Exceptions;
using SocialNetwork.PLL.Helpers;

namespace SocialNetwork.PLL.Views
{
    public class AuthenticationViews
    {
        UserService userService;

        public AuthenticationViews(UserService userService)
        {
            this.userService = userService;
        }

        public void Show()
        {
            var authenticationData = new UserAuthenticationData();

            Console.WriteLine("Enter email: ");
            authenticationData.Email = Console.ReadLine();

            Console.WriteLine("Enter password: ");
            authenticationData.Password = Console.ReadLine();

            try
            {
                var authUser = userService.Authenticate(authenticationData);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You are logged in successfully. Welcome {0}", authUser.FirstName);
                Console.ForegroundColor = ConsoleColor.White;

                Program.userMenuView.Show(authUser);
            }
            catch (WrongPasswordException)
            {
                ErrorMessage.Show("Wrong password.");
            }
            catch (UserNotFoundException)
            {
                ErrorMessage.Show("User not found.");
            }
           
        }
    }
}
