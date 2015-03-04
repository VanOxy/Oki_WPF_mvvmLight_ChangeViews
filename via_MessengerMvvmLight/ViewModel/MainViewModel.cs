using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Messaging;
using System.Windows.Controls;
using via_MessengerMvvmLight.Message;

namespace via_MessengerMvvmLight.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public RelayCommand GoToControl1Command { get; set; }

        public RelayCommand GoToControl2Command { get; set; }

        public RelayCommand GoToControl3Command { get; set; }

        public MainViewModel()
        {
            GoToControl1Command = new RelayCommand(GoToControl1);
            GoToControl2Command = new RelayCommand(GoToControl2);
            GoToControl3Command = new RelayCommand(GoToControl3);
        }

        private void GoToControl1()
        {
            Messenger.Default.Send(new ChangeViewMessage("1"));
        }

        private void GoToControl2()
        {
            Messenger.Default.Send(new ChangeViewMessage("2"));
        }

        private void GoToControl3()
        {
            Messenger.Default.Send(new ChangeViewMessage("3"));
        }
    }
}