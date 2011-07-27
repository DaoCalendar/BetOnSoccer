using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BetOnSoccer.Domain.Models
{
	public class User
	{
		#region Properties

		public string Username { get; set; }
		public string Password { get; set; }

		public IList<Tournament> SubscribedTournaments { get; set; }
		public IList<Bet> Bets { get; set; }

		#endregion

		#region Constructors

		public User()
		{
			SubscribedTournaments = new List<Tournament>();
			Bets = new List<Bet>();
		}

		public User(string username)
			: this()
		{
			this.Username = username;
		}

		#endregion

		#region Methods

		public void MakeBet(Match match, int homeTeamGoals, int awayTeamGoals)
		{
			if (match == null)
				throw new ArgumentNullException("match");

			Bets.Add(new Bet(this, match, homeTeamGoals, awayTeamGoals));
		}

		public override string ToString()
		{
			return Username;
		}

		#endregion

	}
}
