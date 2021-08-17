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
                NotifyOfPropertyChange(() => CanLogIn);
            }
        }

        public string Password
        {
            get { return _password; }
            set 
            { 
                _password = value;
                NotifyOfPropertyChange(() => Password);
                NotifyOfPropertyChange(() => CanLogIn);

            }
        }

        public bool CanLogIn
        {
            get
            {
                bool approvedToLogIn = false;

                approvedToLogIn = VerifyUserCredentialsLength(UserName, Password);

                return approvedToLogIn;
            }

        }

        public bool VerifyUserCredentialsLength(string userName, string password)
        {
            if (userName?.Length > 0 && password?.Length > 0)
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
