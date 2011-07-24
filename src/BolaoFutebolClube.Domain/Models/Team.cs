using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BolaoFutebolClube.Domain.Models
{
	public class Team
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Alias { get; set; }
		public string NickName { get; set; }
		public string Flag { get; set; }
		public DateTime FoundedIn { get; set; }
		public Location Location { get; set; }
		public string Website { get; set; }

        public Team(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return this.Name;
        }
	}
}
