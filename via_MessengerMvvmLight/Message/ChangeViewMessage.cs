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