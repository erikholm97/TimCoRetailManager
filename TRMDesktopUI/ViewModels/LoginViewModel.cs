using Caliburn.Micro;
using System;
using System.Threading.Tasks;
using TRMDesktopUI.Helpers;

namespace TRMDesktopUI.ViewModels
{
    public class LoginViewModel : Screen
    {
        public string _userName;

        public string _password;

        private IAPIHelper _apiHelper;

        public LoginViewModel(IAPIHelper apiHelper)
        {
            _apiHelper = apiHelper;
        }

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

        public async Task LogIn()
        {
            var result = await _apiHelper.Authenticate(UserName, Password);
        }        
    }
}
