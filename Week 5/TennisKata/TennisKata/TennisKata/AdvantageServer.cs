﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisKata
{
    public class AdvantageServer : IScoreState

    {
        public string State()
        {
            return $"Advantage Server";
        }
    }
}
