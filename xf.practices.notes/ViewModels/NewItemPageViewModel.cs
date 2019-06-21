using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using xf.practices.notes.Models;

namespace xf.practices.notes.ViewModels
{
    public class NewItemPageViewModel : NotificationEnabledObject
    {
        INavigation navigation;
        public NewItemPageViewModel(INavigation _navigation)
        {
            navigation = _navigation;
        }

        private Note _CurrentNote;

        public Note CurrentNote
        {
            get { return _CurrentNote; }
            set
            {
                _CurrentNote = value;
                OnPropertyChanged();
            }
        }

        private ActionCommand<string> _SaveCommand;

        public ActionCommand<string> SaveCommand
        {
            get
            {
                if (_SaveCommand == null)
                {
                    _SaveCommand = new ActionCommand<string>(Save);
                }
                return _SaveCommand;
            }
            set
            {
                _SaveCommand = value;
                OnPropertyChanged();
            }
        }

        private void Save(string obj)
        {
            //Save note
            navigation.PopModalAsync();
        }
    }
}
