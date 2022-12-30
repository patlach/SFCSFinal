using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Views;
using System;

namespace SocialNetwork
{
    class Program
    {
        static UserService userService;
        static MessageService messageService;
        static FriendService friendService;

        public static MainMenu mainMenu;
        public static UserMenuView userMenuView;
        public static UserInfoView userInfoView;
        public static UserEditView userEditView;
        public static SendMessageView sendMessageView;
        public static AuthenticationViews authenticationViews;
        public static UserIncomingMessageView userIncomingMessageView;
        public static UserOutgoingMessageView userOutgoingMessageView;
        public static RegistrationView registrationViews;
        public static FriendMenuView friendMenuViews;
        public static FriendAddView friendAddView;

        static void Main()
        {
            userService = new UserService();
            messageService = new MessageService();
            friendService = new FriendService();

            mainMenu = new MainMenu();
            userMenuView = new UserMenuView(userService);
            userInfoView = new UserInfoView();
            userEditView = new UserEditView(userService);
            authenticationViews = new AuthenticationViews(userService);
            sendMessageView = new SendMessageView(userService, messageService);
            userIncomingMessageView = new UserIncomingMessageView();
            userOutgoingMessageView = new UserOutgoingMessageView();
            registrationViews = new RegistrationView(userService);
            friendMenuViews = new FriendMenuView();
            friendAddView = new FriendAddView(friendService);

            while (true)
            {
                mainMenu.Show();
            }

        }

    }
}
