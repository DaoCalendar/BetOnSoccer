using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BetOnSoccer.Domain.Models;

namespace BetOnSoccer.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("wrparra");
            Tournament tournament = new Tournament("Copa América 2011");
            tournament.SubscribeUser(user);

            Console.WriteLine(tournament);



            foreach (var userSubscribed in tournament.SubscribedUsers)
            {
                Console.WriteLine(user);
            }

            

            Match match = new Match()
            {
                HomeTeam = new Team("Brasil"),
                AwayTeam = new Team("Argentina")
            };

            Console.WriteLine(match);


            match.SetScore(2, 1);

            Console.WriteLine(match);


            Console.Read();

        }
    }
}
