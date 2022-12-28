using SocialNetwork.BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.PLL.Views
{
    public class UserInfoView
    {
        public void Show(User user)
        {
            Console.WriteLine("My profile data");
            Console.WriteLine("Id: {0}", user.Id);
            Console.WriteLine("Name: {0}", user.FirstName);
            Console.WriteLine("Lastname: {0}", user.LastName);
            Console.WriteLine("Password: {0}", user.Password);
            Console.WriteLine("Email: {0}", user.Email);
            Console.WriteLine("My photo: {0}", user.Photo);
            Console.WriteLine("Favorite movie: {0}", user.FavoriteMovie);
            Console.WriteLine("Favorite book: {0}", user.FavoriteBook);
        } 
    }
}
