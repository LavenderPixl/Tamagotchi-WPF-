using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi_WPF.Objects;

namespace Tamagotchi_WPF.ViewModels
{
    public class ShellWindowViewModel : INotifyPropertyChanged
    {
        private ViewModelBase _currentView;

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ViewModelBase CurrentView
        {
            get => _currentView;
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public ShellWindowViewModel()
        {
            CurrentView = new MenuWindowViewModel();
            EventAggregator.OnTransmittedData += OnTransmittedData;
        }

        private void OnTransmittedData(Type type)
        {
            var view = (ViewModelBase)Activator.CreateInstance(type);
            CurrentView = view;
        }
    }
}
