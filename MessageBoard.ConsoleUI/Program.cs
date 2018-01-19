using System;
using System.Collections.Generic;

namespace MessageBoard.ConsoleUI
{

    class Program
    {
        static void Main(string[] args)
        {
            ChatRoom room = new ChatRoom();
            room.addChatter("Marise", 13);
            room.addChatter("Sofie", 11);

            room.removeChatter(name: "René");
            room.removeChatter(name: "Sofie");

            var sil = room.getChatter("Silvia");

            Console.WriteLine("Dit is chatter gekozen met de naam {0} en ze is {1}", sil.Name,sil.Age);

            List<Chatter> chatters = room.currentChatters();

            foreach (var chatter in chatters)
            {
                Console.WriteLine("Dit is {0} en is {1}", chatter.Name, chatter.Age);
            }

       



        }
    }

}
