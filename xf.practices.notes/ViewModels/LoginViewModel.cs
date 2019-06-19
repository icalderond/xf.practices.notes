using System;
using System.Collections.Generic;
using System.Text;

namespace xf.practices.notes.ViewModels
{
    public class LoginViewModel : NotificationEnabledObject
    {
        public LoginViewModel()
        {
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
    }
}
