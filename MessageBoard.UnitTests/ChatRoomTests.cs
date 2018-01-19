using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MessageBoard.ConsoleUI.Tests
{
    [TestClass()]
    public class ChatRoomTests
    {
        [TestMethod()]
        public void MessageBoardChatRoom_CanAddChatters_4IsEqual()
        {
            var room = new ChatRoom(); // Standard 2 default user existing (René and Silvia)

            room.addChatter(name: "Marise", age: 13);
            room.addChatter(name: "Sofie", age: 11); // Now there are 4 chatters attached to the room

            var result = room.getChatterCount();

            Assert.AreEqual(expected: 4, actual: result);

        }

        [TestMethod()]
        public void MessageBoardChatRoom_CanRemoveChatters_3IsEqual()
        {
            var room = new ChatRoom(); // Standard 2 default user existing (René and Silvia)

            room.addChatter(name: "Marise", age: 13);
            room.addChatter(name: "Sofie", age: 11); // Now there are 4 chatters attached to the room
            room.removeChatter(name: "Silvia"); // Now we have 3 chatters. Silvia is removed

            var result = room.getChatterCount();

            Assert.AreNotEqual(notExpected: 4, actual: result);
        }

        [TestMethod()]
        public void MessageBoardChatRoom_GetChatterByName_SofiesNameAndAgeAreEqual()
        {
            var room = new ChatRoom(); // Standard 2 default user existing (René and Silvia)

            room.addChatter(name: "Marise", age: 13);
            room.addChatter(name: "Sofie", age: 11); // Now there are 4 chatters attached to the room

            var name = "Sofie";
            var result = room.getChatter(name);

            Assert.AreEqual(expected: 11, actual: result.Age);
            Assert.AreEqual(expected: "Sofie", actual: result.Name);
        }

        [TestMethod()]
        public void MessageBoardChatRoom_CurrentChatters_CheckNamesAndAgesInCurrentChatters()
        {
            var room = new ChatRoom(); // Standard 2 default user existing (René and Silvia)
            room.addChatter(name: "Marise", age: 13);
            room.addChatter(name: "Sofie", age: 11); // Now there are 4 chatters attached to the room

            var chatters = room.currentChatters();

            Assert.AreEqual("René", chatters[0].Name);
            Assert.AreEqual(51, chatters[0].Age);
            Assert.AreEqual("Silvia", chatters[1].Name);
            Assert.AreEqual(48, chatters[1].Age);
            Assert.AreEqual("Marise", chatters[2].Name);
            Assert.AreEqual(13, chatters[2].Age);
            Assert.AreEqual("Sofie", chatters[3].Name);
            Assert.AreEqual(11, chatters[3].Age);
        }

        [TestMethod]
        public void MessageBoardChatRoom_getChatterCount_CheckCountFromRoomAndgetCount()
        {
            var room = new ChatRoom(); // Standard 2 default user existing (René and Silvia)
            room.addChatter(name: "Marise", age: 13);
            room.addChatter(name: "Sofie", age: 11); // Now there are 4 chatters attached to the room

            var result1 = room.currentChatters().Count;
            var result2 = room.getChatterCount();
            Assert.AreEqual(expected: 4, actual: result1);
            Assert.AreEqual(expected: 4, actual: result2);
        }
    }
}