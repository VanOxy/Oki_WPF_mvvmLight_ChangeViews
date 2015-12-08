using Final.Messages;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System.Windows.Input;

namespace Final.ViewModel
{
    public class SecondViewModel : ViewModelBase
    {
        public ICommand ChangeToMainPageCommand { get; set; }

        public SecondViewModel()
        {
            ChangeToMainPageCommand = new RelayCommand(ChangeToMainPage);
        }

        private void ChangeToMainPage()
        {
            Messenger.Default.Send(new ChangePageMessage("main"));
        }
    }
}