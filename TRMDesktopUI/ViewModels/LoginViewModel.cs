using Caliburn.Micro;
using System;

namespace TRMDesktopUI.ViewModels
{
    public class LoginViewModel : Screen
    {
        public string _userName;

        public string _password;

        public string UserName
        {
            get { return _userName; }
            set 
            { 
                _userName = value;
                NotifyOfPropertyChange(() => UserName);
            }
        }

        public string Password
        {
            get { return _password; }
            set 
            { 
                _password = value;
                NotifyOfPropertyChange(() => Password);
            }
        }

        public bool CanLogIn(string userName, string password)
        {
            bool approvedToLogIn;

            approvedToLogIn = VerifyUserCredentialsLength(userName, password);

            return approvedToLogIn;
        }

        public bool VerifyUserCredentialsLength(string userName, string password)
        {
            if (userName.Length > 0 && password.Length > 0)
            {
                return true;
            }

            return false;
        }

        public void LogIn(string username, string password)
        {
            Console.WriteLine("Login Was called");
        }

    }
}
