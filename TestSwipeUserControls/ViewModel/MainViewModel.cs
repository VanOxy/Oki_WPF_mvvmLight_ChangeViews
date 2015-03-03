using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;

namespace TestSwipeUserControls.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private ViewModelBase _currentViewModel;

        private static readonly FirstViewModel _firstViewModel = new FirstViewModel();
        private static readonly SecondViewModel _secondViewModel = new SecondViewModel();
        private static readonly ThirdViewModel _thirdViewModel = new ThirdViewModel();

        public RelayCommand GoToControl1Command { get; private set; }

        public RelayCommand GoToControl2Command { get; private set; }

        public RelayCommand GoToControl3Command { get; private set; }

        public MainViewModel()
        {
            CurrentViewModel = _firstViewModel;
            GoToControl1Command = new RelayCommand(ShowControl1);
            GoToControl2Command = new RelayCommand(ShowControl2);
            GoToControl3Command = new RelayCommand(ShowControl3);
        }

        public ViewModelBase CurrentViewModel
        {
            get
            {
                return _currentViewModel;
            }
            set
            {
                if (_currentViewModel == value)
                    return;
                _currentViewModel = value;
                RaisePropertyChanged("CurrentViewModel");
            }
        }

        private void ShowControl1()
        {
            CurrentViewModel = _firstViewModel;
        }

        private void ShowControl2()
        {
            CurrentViewModel = _secondViewModel;
        }

        private void ShowControl3()
        {
            CurrentViewModel = _thirdViewModel;
        }
    }
}