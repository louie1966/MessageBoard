namespace MessageBoard.ConsoleUI
{
    class Message
    {
        string _messageBody = "";

        public Message(string messageBody)
        {
            _messageBody = messageBody;
        }

        public void setBody(string messageBody)
        {
            _messageBody = messageBody;
        }

        public string getBody()
        {
            return _messageBody;
        }
    }
}
