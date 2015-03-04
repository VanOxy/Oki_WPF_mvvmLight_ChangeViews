using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Messaging;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Threading;
using TestSwipeUserControls.View;
using via_CommandBinding_of_ContentControl.Message;

namespace via_CommandBinding_of_ContentControl.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private UserControl _activeView;
        public Control1 _c1;
        public Control2 _c2;
        public Control3 _c3;

        public UserControl ActiveView
        {
            get
            {
                return _activeView;
            }
            set
            {
                if (_activeView == value)
                    return;
                _activeView = value;
                RaisePropertyChanged("ActiveView");
            }
        }

        public RelayCommand GoToControl1Command { get; set; }

        public RelayCommand GoToControl2Command { get; set; }

        public RelayCommand GoToControl3Command { get; set; }

        public MainViewModel()
        {
            InitCommands();

            Messenger.Default.Register<MainWindowUidMessage>(this, LoadControls);
        }

        private void LoadControls(MainWindowUidMessage obj)
        {
            Dispatcher.FromThread(obj.ThreadUid).Invoke(() =>
            {
                _c1 = new Control1();
                _c2 = new Control2();
                _c3 = new Control3();
            });

            ActiveView = _c1;
        }

        #region Commands management

        private void InitCommands()
        {
            GoToControl1Command = new RelayCommand(GoToControl1);
            GoToControl2Command = new RelayCommand(GoToControl2);
            GoToControl3Command = new RelayCommand(GoToControl3);
        }

        private void GoToControl1()
        {
            ActiveView = _c1;
        }

        private void GoToControl2()
        {
            ActiveView = _c2;
        }

        private void GoToControl3()
        {
            ActiveView = _c3;
        }

        #endregion Commands management
    }
}