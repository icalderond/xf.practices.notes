﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace xf.practices.notes.ViewModels
{
    public class ActionCommand<T> : ICommand
    {
        Action<T> action;
        public ActionCommand(Action<T> action)
        {
            this.action = action;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            action((T)parameter);
        }
    }
}
