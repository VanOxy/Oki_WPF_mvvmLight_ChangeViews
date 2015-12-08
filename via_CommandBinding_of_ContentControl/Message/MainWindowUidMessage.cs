using System.Threading;

namespace via_CommandBinding_of_ContentControl.Message
{
    internal class MainWindowUidMessage
    {
        public Thread ThreadUid { get; set; }

        public MainWindowUidMessage(Thread p)
        {
            ThreadUid = p;
        }
    }
}