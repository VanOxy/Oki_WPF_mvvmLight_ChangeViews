using Final.Messages;
using Final.Pages;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using System.Windows.Controls;

namespace Final.ViewModel
{
    public class SelectorViewModel : ViewModelBase
    {
        private Page _activeView;
        private MainPage _mainPage;
        private SecondPage _secondPage;

        public SelectorViewModel()
        {
            _mainPage = new MainPage();
            ActiveView = _mainPage;
            Messenger.Default.Register<ChangePageMessage>(this, ChangePage);
        }

        public Page ActiveView
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

        private void ChangePage(ChangePageMessage message)
        {
            switch (message.PageName)
            {
                case "main":
                    ActiveView = _mainPage;
                    break;

                case "second":
                    if (_secondPage == null)
                        _secondPage = new SecondPage();
                    ActiveView = _secondPage;
                    break;

                default:
                    break;
            }
        }
    }
}