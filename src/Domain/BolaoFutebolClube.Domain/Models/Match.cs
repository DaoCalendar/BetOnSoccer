using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BolaoFutebolClube.Domain.Models
{
    public class Match
    {
        public int Id { get; set; }
        public Stage Stage { get; set; }
        public Team HomeTeam { get; set; }
        public Team AwayTeam { get; set; }
        public MatchScore Score { get; set; }
        public DateTime DateAndTime { get; set; }
        public Location Location { get; set; }
        public MatchStatus Status { get; set; }

        public void SetScore(int homeGoals, int awayGoals)
        {
            Score = new MatchScore(this, homeGoals, awayGoals);
        }

        public override string ToString()
        {
            if (Score != null)
                return Score.ToString();
            else
                return string.Format("{0} x {1}", HomeTeam, AwayTeam);
        }
    }
}
