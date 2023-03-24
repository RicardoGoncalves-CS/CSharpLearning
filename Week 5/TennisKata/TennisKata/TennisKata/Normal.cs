using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisKata
{
    public class Normal : IScoreState { 
        public int server { get; set; }
        public int receiver { get; set; }

    
        public Normal(int server, int receiver)
        {

            this.server = server;
            this.receiver = receiver;

        }
        public static Dictionary<int, string> result = new Dictionary<int, string>() {
            {0,"Love" },
            {1,"Fifteen" },
            {2,"Thirty" },
            {3,"Forty"}
        };

        public string State()
        {
            return $"{result[server]} {result[receiver]}";
        }
    }

}

