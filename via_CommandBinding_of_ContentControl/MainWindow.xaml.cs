using GalaSoft.MvvmLight.Messaging;
using System.Threading;
using System.Windows;
using via_CommandBinding_of_ContentControl.Message;

namespace via_CommandBinding_of_ContentControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new MainWindowUidMessage(
                Thread.CurrentThread));
        }
    }
}