using Caliburn.Micro;

namespace TRMDesktopUI.ViewModels
{
    public class LoginViewModel : Screen
    {
        public string _userName;

        public string _password;

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        public string PassWord
        {
            get { return _password; }
            set { _password = value; }
        }

    }
}
