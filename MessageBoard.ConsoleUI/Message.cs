using System;

namespace MessageBoard.ConsoleUI
{
    public class Message
    {
        public Message(string messageBody, Chatter chatter, DateTime send)
        {
            MessageBody = messageBody;
            Sender = chatter;
            Send = send;
        }

        public string MessageBody { get; set; }
        public Chatter Sender { get; set; }
        public DateTime Send { get; set; }
    }
}
