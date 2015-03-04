using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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