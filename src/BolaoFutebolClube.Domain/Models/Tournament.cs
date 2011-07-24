using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BolaoFutebolClube.Domain.Models
{
	public class Tournament
	{
        public List<User> _subscribedUsers = null;

		public int Id { get; set; }
		public string Name { get; set; }
        public int Year { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }

        public List<User> SubscribedUsers { get { return this._subscribedUsers; } }
		public List<Team> Teams { get; set; }
		public List<Stage> Stages { get; set; }

        public Tournament(string name)
        {            
            this.Name = name;

            this._subscribedUsers = new List<User>();
        }

        public void SubscribeUser(User user)
        {
            this._subscribedUsers.Add(user);
        }

        public override string ToString()
        {
            return Name;
        }
	}
}
