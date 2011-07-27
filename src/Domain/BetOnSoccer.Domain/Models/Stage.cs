using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BetOnSoccer.Domain.Models
{
	public class Stage
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }

		public Tournament Tournament { get; set; }
		public List<Team> Teams { get; set; }
		public List<Match> Matches { get; set; }
	}
}
