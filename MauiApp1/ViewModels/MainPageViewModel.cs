using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.ViewModels
{
    public class MainPageViewModel: INotifyPropertyChanged
    {
        private string _exampleString = "DEAFAULT";
        public string ExampleString {
            get => _exampleString;
            set
            {
                _exampleString = value;
                OnPropertyChanged(nameof(ExampleString));
            } 
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = "") =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
