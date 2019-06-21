using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using xf.practices.notes.Views;

namespace xf.practices.notes.ViewModels
{
    public class LoginViewModel : NotificationEnabledObject
    {
        INavigation navigation;
        public LoginViewModel(INavigation _navigation)
        {
            navigation = _navigation;
            Title = "Login";
        }

        private string _Title;

        public string Title
        {
            get { return _Title; }
            set
            {
                _Title = value;
                OnPropertyChanged();
            }
        }

        private string _User;

        public string User
        {
            get { return _User; }
            set
            {
                _User = value;
                OnPropertyChanged();
            }
        }

        private string _Password;

        public string Password
        {
            get { return _Password; }
            set
            {
                _Password = value;
                OnPropertyChanged();
            }
        }

        private ActionCommand<string> _AccessCommand;

        public ActionCommand<string> AccessCommand
        {
            get
            {
                if (_AccessCommand == null)
                {
                    _AccessCommand = new ActionCommand<string>(Access);
                }
                return _AccessCommand;
            }
            set
            {
                _AccessCommand = value;
                OnPropertyChanged();
            }
        }

        private void Access(string obj)
        {
            if (User == "isra" && Password == "1234")
            {
                navigation.PushAsync(new ListOfNotesPage());
            }
            else
            {
                App.Current.MainPage.DisplayAlert("Mensaje", "No te vayas irs", "Ok");
            }
        }
    }
}
