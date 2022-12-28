using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.PLL.Views
{
    public class RegistrationView
    {
        UserService userService;

        public RegistrationView(UserService userService)
        {
            this.userService = userService;
        }

        public void Show()
        {
            var regData = new UserRegistrationData();

            Console.WriteLine("Enter your firstname:");
            regData.FirstName = Console.ReadLine();

            Console.WriteLine("Enter your lasrname:");
            regData.LastName = Console.ReadLine();

            Console.WriteLine("Enter your email:");
            regData.Email = Console.ReadLine();

            Console.WriteLine("Enter your password:");
            regData.Password = Console.ReadLine();

            try
            {
                
                this.userService.Register(regData);

                SuccessMessage.Show("Profile was created successfully!");
            }
            catch (ArgumentNullException)
            {
                ErrorMessage.Show("Enter correct data.");
            }
            catch (Exception)
            {
                ErrorMessage.Show("Error when try register user.");
            }
        }
    }
}
