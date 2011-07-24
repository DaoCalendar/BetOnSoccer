using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BolaoFutebolClube.Domain.Models
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
