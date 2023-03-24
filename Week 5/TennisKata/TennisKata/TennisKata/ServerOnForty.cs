using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisKata
{
    public class ServerOnForty : IScoreState
    {
        public string State()
        {
            return "Server On Forty";
        }
    }
}
