namespace Roboka.Data
{
    public static class Messages
    {
        private const string WelcomeMessage = "Select Category!";
        private const string Button1 = "Text Inputs!";
        private const string Button2 = "File Inputs!";
        private const string Button3 = "Other Buttons!";

        public static string GetMessage(string buttonId)
        {
            switch (buttonId)
            {
                case null:
                    return WelcomeMessage;
                case "1":
                    return Button1;
                case "2":
                    return Button2;
                case "3":
                    return Button3;
                default:
                    return null;
            }
        }
    }
}
