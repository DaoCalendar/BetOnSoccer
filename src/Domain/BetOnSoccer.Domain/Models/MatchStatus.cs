using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BetOnSoccer.Domain.Models
{
	public enum MatchStatus
	{
		NotPublished,
		Published,
		OpenForBets,
		ClosedForBets,
		Canceled,
		Finished,
	}
}
