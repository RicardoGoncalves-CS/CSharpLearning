using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisKata
{
    public class ReceiverOnForty : IScoreState
    {
        public string State()
        {
            return "Receiver On Forty";
        }
    }
}
