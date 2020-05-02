using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// The set of teams taht were involved in this match.
        /// </summary>
        public List<MatchupModel> Entries { get; set; } = new List<MatchupModel>();
        /// <summary>
        ///Winner of the match.
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// \which round this match 
        /// </summary>
        public string MatchupRound{ get; set; }
    }
}
