using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisKata
{
    internal class ServerWins : IScoreState
    {
        public string State()
        {
           return "Server Wins";
        }
    }
}
