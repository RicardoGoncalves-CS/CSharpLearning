using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace TennisKata
{
    public class AdvantageReceiver : IScoreState
    {
        public string State()
        {
            return $"Advantage Receiver";
        }
    }
}
