using BusinessLogic;
using Internet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;

namespace Курсовая
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        public MainWindowViewModel()
        {
            Logi = new Logic();
        }
        private NavigationService _navigationService;
        private Visibility _Top;
        public Visibility Top
        {
            get { return _Top; }
            set
            {
                _Top = value;
                DoPropertyChanged("Top");
            }
        }

        Logic Logi;
        
        private void GoLenta()
        {
            _navigationService?.Navigate(new Uri("List.xaml", UriKind.Relative));
        }
        private void GoPodpiska()
        {
            _navigationService?.Navigate(new Uri("Submit.xaml", UriKind.Relative));
        }
        private void GoPrint()
        {
            Logi.Print();
        }

        private ICommand _lenta;
        public ICommand Lenta
        {
            get
            {
                if (_lenta == null)
                {
                    {
                        _lenta = new CommandHandler(
                            p => true,
                            p => GoLenta());
                    }
                }
                return _lenta;
            }
        }

        private ICommand _podpiska;
        public ICommand Podpiska
        {
            get
            {
                if(_podpiska == null)
                {
                    {
                        _podpiska = new CommandHandler(
                            p => true,
                            p => GoPodpiska());
                    }
                }
                return _podpiska;
            }
        }
        private ICommand _print;
        public ICommand Print
        {
            get
            {
                if (_print == null)
                {
                    {
                        _print = new CommandHandler(
                            p => true,
                            p => GoPrint());
                    }
                }
                return _print;
            }
        }
        private ICommand _doOnLoading;

        public ICommand DoOnLoading
        {
            get
            {
                if (_doOnLoading == null)
                {
                    _doOnLoading = new CommandHandler(
                        p => true,
                        p => OnLoading(p));
                }
                return _doOnLoading;
            }
        }
        private ICommand _doOnList;

        public ICommand DoOnList
        {
            get
            {
                if (_doOnList == null)
                {
                    _doOnList = new CommandHandler(
                        p => true,
                        p => OnList(p));
                }
                return _doOnList;
            }
        }
        
        private void OnLoading(object page)
        {
            _navigationService = NavigationService.GetNavigationService(page as Loading);
            if (Connection.ConnectionAvailable())
            {
                _navigationService?.Navigate(new Uri("List.xaml", UriKind.Relative));
            }
            else
            {
                Nonono();
            }
        }
        private void OnList(object page)
        {
            _navigationService = NavigationService.GetNavigationService(page as List);
            if (Logi.CreateLenta())
            {
            }
            else
            {
                Nonono();
            }

        }
        public void Nonono()
        {
            Top = Visibility.Collapsed;

            _navigationService?.Navigate(new Uri("NoInternet.xaml", UriKind.Relative));
        }
        public void DoPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        public event PropertyChangedEventHandler PropertyChanged;

    }
}
