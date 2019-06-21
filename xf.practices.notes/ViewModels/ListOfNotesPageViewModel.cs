using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using xf.practices.notes.Views;

namespace xf.practices.notes.ViewModels
{
    public class ListOfNotesPageViewModel:NotificationEnabledObject
    {
        INavigation navigation;
        public ListOfNotesPageViewModel(INavigation _navigation)
        {
            navigation = _navigation;
        }

        private string _Title;

        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }

        private ActionCommand<string> _AddCommand;

        public ActionCommand<string> AddCommand
        {
            get {
                if (_AddCommand==null)
                {
                    _AddCommand = new ActionCommand<string>(Add);
                }
                return _AddCommand; }
            set { _AddCommand = value;
                OnPropertyChanged();
            }
        }

        private void Add(string obj)
        {
            navigation.PushModalAsync(new NewItemPage());
        }
    }
}
