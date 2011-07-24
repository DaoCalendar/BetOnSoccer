using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BolaoFutebolClube.Domain.Models
{
	public class MatchScore
	{
        private Match _match = null;

		public int HomeGoals { get; set; }
		public int AwayGoals { get; set; }
        public MatchResult Result { get; set; }

        public MatchScore(Match match, int homeGoals, int awayGoals)
        {
            this._match = match;
            this.HomeGoals = homeGoals;
            this.AwayGoals = awayGoals;
        }


        public override string ToString()
        {
            return string.Format("{0} {1} x {2} {3}", _match.HomeTeam, HomeGoals, AwayGoals, _match.AwayTeam); 
        }
	}
}
