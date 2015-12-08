using Final.Messages;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System.Windows.Input;

namespace Final.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public ICommand ChangeToSecondPageCommand { get; private set; }

        public MainViewModel()
        {
            ChangeToSecondPageCommand = new RelayCommand(ChangeToSecondPage);
        }

        private void ChangeToSecondPage()
        {
            Messenger.Default.Send(new ChangePageMessage("second"));
        }
    }
}