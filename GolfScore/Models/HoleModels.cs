using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GolfScore.Models
{
    public class HoleModels
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int YellowLength { get; set; } // yards
        public int YellowPar { get; set; }
        public int YellowScoreIndex { get; set; }
        public int WhiteLength { get; set; } // yards
        public int WhitePar { get; set; }
        public int WhiteScoreIndex { get; set; }
        public int RedLength { get; set; } // yards
        public int RedPar { get; set; }
        public int RedScoreIndex { get; set; }
    }
}