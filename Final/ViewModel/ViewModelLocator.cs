using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace Final.ViewModel
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            // Register VM's
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<SecondViewModel>();
            SimpleIoc.Default.Register<SelectorViewModel>();
        }

        #region Declaring VM's

        public SelectorViewModel Selector
        {
            get { return ServiceLocator.Current.GetInstance<SelectorViewModel>(); }
        }

        public MainViewModel Main
        {
            get { return ServiceLocator.Current.GetInstance<MainViewModel>(); }
        }

        public SecondViewModel Second
        {
            get { return ServiceLocator.Current.GetInstance<SecondViewModel>(); }
        }

        #endregion Declaring VM's

        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}