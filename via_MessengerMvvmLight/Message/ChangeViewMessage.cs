using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace via_MessengerMvvmLight.Message
{
    public class ChangeViewMessage
    {
        public string ControlName { get; private set; }

        public ChangeViewMessage(string str)
        {
            ControlName = str;
        }
    }
}