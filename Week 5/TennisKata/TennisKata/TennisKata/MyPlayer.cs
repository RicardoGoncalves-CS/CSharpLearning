
using TennisKata;

   public enum Player
    {
        Server,
        Receiver
    }


public class MyPlayer
{
    private static IScoreState state = new Normal(server, receiver);

        public static int server { get; set; }
        public static int receiver { get; set; }


        public static void IncrementScore(Enum player)
        {
            if (player.Equals(Player.Server))
            {
                server++;
            } else
            {
                receiver++;
            }
        }

        public static void SettingState()
        {

            if (server == 3 && receiver == 4)
            {
                state = new AdvantageReceiver();
            }
            else if (server == 4 && receiver == 3)
            {
                state = new AdvantageServer();
            }
            else if (server == 4)
            {
                state = new ServerWins();
            }
            else if (server == 5 && receiver <= 3)
            {
                state = new ServerWins();

            }
            else if (server == 3 && receiver == 5)
            {

                state = new ReceiverWins();
            }
            else 
            {
                state = new Normal(server, receiver);
            };
        }

        public static string printOutState() {

        return state.State();
    }
}