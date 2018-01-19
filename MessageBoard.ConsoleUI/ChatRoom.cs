using System.Collections.Generic;
using System.Linq;

namespace MessageBoard.ConsoleUI
{
    public class ChatRoom
    {
        List<Chatter> _chatters = new List<Chatter> {
            new Chatter{Name="René", Age=51},
            new Chatter{Name="Silvia", Age=48}
        };
       
        public int getChatterCount() {
            return _chatters.Count();
        }

        public void addChatter(string name, int age) => _chatters.Add(new Chatter { Name = name, Age = age });

        public void removeChatter(string name) => _chatters.Remove(this.getChatter(name));

        public Chatter getChatter(string name) => _chatters.Where(n => n.Name == name).FirstOrDefault();



        public List<Chatter> currentChatters() => _chatters;
    }
}
