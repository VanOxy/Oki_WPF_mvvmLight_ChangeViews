using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TestSwipeUserControls.View;
using via_MessengerMvvmLight.Message;

namespace via_MessengerMvvmLight
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Control1 _c1 = new Control1();
        private Control2 _c2 = new Control2();
        private Control3 _c3 = new Control3();

        public MainWindow()
        {
            InitializeComponent();

            Frame.Content = _c1;

            Messenger.Default.Register<ChangeViewMessage>(this, ChangeView);
        }

        private void ChangeView(ChangeViewMessage obj)
        {
            switch (obj.ControlName)
            {
                case "1":
                    Frame.Content = _c1;
                    break;

                case "2":
                    Frame.Content = _c2;
                    //Messenger.Default.Send(new LaunchSearchMessage());
                    break;

                case "3":
                    Frame.Content = _c3;
                    break;

                default:
                    break;
            }
        }
    }
}