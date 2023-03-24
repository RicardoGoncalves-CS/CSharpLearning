using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisKata
{
    public class ReceiverWins : IScoreState

    {
        public  string State()
        {
            return "Receiver Wins";
        }
    }
}
