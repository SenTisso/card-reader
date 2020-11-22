using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
// using test.Models;
// using test.Services;
using Xamarin.Forms;

namespace card_reader.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {

        // toto je zrejme zpusob, jak udelat nejaky globalni parametr, kterej muzou pouzivat ty tridy, ktery dedi BaseViewModel
        string title = string.Empty;
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }

        // jinak custom properties se nastavuji takto
        // public string Roman { get; }
        // a pak primo v constructoru se nastavi

        /* nejaky veci co se vytvorili v FlyOut appce, treba se to bude hodit idk */
        // public IDataStore<Item> DataStore => DependencyService.Get<IDataStore<Item>>();

        // bool isBusy = false;
        // public bool IsBusy
        // {
        //     get { return isBusy; }
        //     set { SetProperty(ref isBusy, value); }
        // }


        /**
         * Pomoci tohoto se nastavuji ty properties veci ve ViewModelech, ze kterych se potom mohou vypisovat veci ve Views napr. {Binding Title}
         */
        protected bool SetProperty<T>(ref T backingStore, T value,
            [CallerMemberName] string propertyName = "",
            Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}