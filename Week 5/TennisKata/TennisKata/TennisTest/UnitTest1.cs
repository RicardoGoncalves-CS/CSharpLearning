using System.Numerics;
using TennisKata;
namespace TennisTest
{


    public class Tests
    {
        


        [SetUp]
        public void Setup()
        {
        }


        [TestCase(Player.Receiver, 2, 2, "Thirty Forty")]
        [TestCase(Player.Server, 1, 0, "Thirty Love")]
        [TestCase(Player.Receiver, 0, 0, "Love Fifteen")]
        [TestCase(Player.Server, 2, 0, "Forty Love")]
        [TestCase(Player.Server, 3, 0, "Server Wins")]
        [TestCase(Player.Server, 3, 3, "Advantage Server")]
        [TestCase(Player.Receiver, 3, 3, "Advantage Receiver")]
        [TestCase(Player.Server, 4, 3, "Server Wins")]
        [TestCase(Player.Receiver, 3, 4, "Receiver Wins")]

        public void GivenPlayerScore_ReturnExpectedString(Player player, int ServerScore, int ReceiverScore, string expectedOutput)
        {
            MyPlayer.server = ServerScore;
            MyPlayer.receiver = ReceiverScore;

            MyPlayer.IncrementScore(player);
            MyPlayer.SettingState();

            var result = MyPlayer.printOutState();

            Assert.AreEqual(result, expectedOutput);
        }
    }
}