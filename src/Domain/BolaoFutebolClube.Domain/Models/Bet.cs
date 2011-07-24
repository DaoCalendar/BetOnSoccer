using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BolaoFutebolClube.Domain.Models
{
	public class Bet
	{
		public User User { get; private set; }
		public Match Match { get; private set; }
		public int? HomeTeamGoals { get; set; }
		public int? AwayTeamGoals { get; set; }
		public int BetScore { get; private set; }
		public bool IsValid { get; private set; }

		public Bet(User user, Match match, int homeTeamGoals, int awayTeamGoals)
		{
			this.User = user;
			this.Match = match;
			this.HomeTeamGoals = homeTeamGoals;
			this.AwayTeamGoals = awayTeamGoals;

			this.IsValid = true;

		}

		public override string ToString()
		{
			string betTemplate = "{0} {1} x {2} {3}";

			if (Match != null)
				return string.Format(betTemplate, Match.HomeTeam, HomeTeamGoals, AwayTeamGoals, Match.AwayTeam);
			else
				return string.Empty;

		}
	}
}
