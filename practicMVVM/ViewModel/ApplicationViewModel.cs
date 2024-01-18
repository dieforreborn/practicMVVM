using System.ComponentModel;
using System.Windows.Input;
using System.Runtime.CompilerServices;
using practicMVVM.Servise;
using practicMVVM;

namespace ApplicationViewModel
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private AuthService authService;

        private string username;
        private string password;

        public string Username
        {
            get { return username; }
            set
            {
                if (username != value)
                {
                    username = value;
                    OnPropertyChanged(nameof(Username));
                }
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                if (password != value)
                {
                    password = value;
                    OnPropertyChanged(nameof(Password));
                }
            }
        }

        public ICommand LoginCommand { get; private set; }

        public LoginViewModel()
        {
            authService = new AuthService();
            LoginCommand = new RelayCommand(Login, CanLogin);
        }

        private string statusMessage;
        public string StatusMessage
        {
            get { return statusMessage; }
            set
            {
                if (statusMessage != value)
                {
                    statusMessage = value;
                    OnPropertyChanged(nameof(StatusMessage));
                }
            }
        }

        private void Login(object parameter)
        {
            if (authService.Authenticate(Username, Password))
            {
                StatusMessage = "круто";
            }
            else
            {
                StatusMessage = "говно";
            }
        }

        private bool CanLogin(object parameter)
        {
            return !string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
