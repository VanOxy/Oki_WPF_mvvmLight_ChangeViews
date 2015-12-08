namespace Final.Messages
{
    public class ChangePageMessage
    {
        public string PageName { get; private set; }

        public ChangePageMessage(string pageName)
        {
            PageName = pageName;
        }
    }
}