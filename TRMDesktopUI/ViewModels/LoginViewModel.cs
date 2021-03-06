using Caliburn.Micro;
using System;
using System.Threading.Tasks;
using TRMDesktopUI.EventModels;
using TRMDesktopUI.Helpers;
using TRMDesktopUI.Library.Api;

namespace TRMDesktopUI.ViewModels
{
    public class LoginViewModel : Screen
    {
        public string _userName = "erikholm97@gmail.com";

        public string _password = "Pwd12345.";

        private IAPIHelper _apiHelper;

        private IEventAggregator _event;

        public LoginViewModel(IAPIHelper apiHelper, IEventAggregator events)
        {
            _apiHelper = apiHelper;
            _event = events;
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

        public bool IsErrorVisible
        {
            get 
            {
                bool output = false;

                if(ErrorMessage?.Length > 0)
                {
                    output = true;
                }

                return output;
            }
            
        }

        private string _errorMessage;

        public string ErrorMessage
        {
            get { return _errorMessage; }
            set
            {
                _errorMessage = value;
                NotifyOfPropertyChange(() => IsErrorVisible);
                NotifyOfPropertyChange(() => ErrorMessage);
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
            try
            {
                ErrorMessage = string.Empty;
                var result = await _apiHelper.Authenticate(UserName, Password);

                //Capture more information about the user. 
                await _apiHelper.GetLoggedInUserInfo(result.Access_Token);

                _event.PublishOnUIThread(new LogOnEvent());
            }
            catch(Exception ex)
            {
                ErrorMessage = ex.Message;
            }
            
        }        
    }
}
