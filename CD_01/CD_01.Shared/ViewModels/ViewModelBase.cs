using System;
using System.Collections.Generic;
using System.Collections.objectModel;
using System.Text;
using Mvvm;

namespace CD_01.ViewModels
{
    internal class ViewModelBase : BindableBase
    {
        private static readonly ObservableCollection<MenuItem> AppMenu = new ObservableCollection<MenuItem>();
        private static readonly ObservableCollection<MenuItem> AppSecondMenu = new ObservableCollection<MenuItem>();

        public ObservableCollection<MenuItem> Menu => AppMenu;

        public ObservableCollection<MenuItem> SecondMenu => AppSecondMenu;
    }
}
