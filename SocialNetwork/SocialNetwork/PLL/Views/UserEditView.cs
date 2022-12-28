using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.PLL.Views
{
    public class UserEditView
    {
        UserService userService;

        public UserEditView(UserService userService)
        {
            this.userService = userService;
        }

        public void Show(User user)
        {
            Console.Write("My name:");
            user.FirstName = Console.ReadLine();

            Console.Write("My lastname:");
            user.LastName = Console.ReadLine();

            Console.Write("My photo link:");
            user.Photo = Console.ReadLine();

            Console.Write("Favorite movie:");
            user.FavoriteMovie = Console.ReadLine();

            Console.Write("Favorite books:");
            user.FavoriteBook = Console.ReadLine();

            this.userService.Update(user);

            SuccessMessage.Show("Your profile update successfully.");
        }
    }
}
