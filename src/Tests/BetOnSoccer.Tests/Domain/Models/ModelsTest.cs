using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BetOnSoccer.Domain.Models;
using FluentAssertions;

namespace BetOnSoccer.Tests
{
    [TestClass]
    public class ModelsTest
    {
        [TestMethod]
        public void Verify_if_user_was_subscribed_in_tournaments()
        {
            User user = new User("joao");
            user.SubscribedTournaments.Add(CreateWorldCup2010());
            user.SubscribedTournaments.Add(CreateAmericaCup2011());

            user.SubscribedTournaments.Should().HaveCount(2);
            user.SubscribedTournaments.Should().Contain(t => t.Id > 0);
            
        }

        private Tournament CreateAmericaCup2011()
        {
            return new Tournament("Copa América 2011")
            {
                Id = 2,
                Year = 2011,
                StartDate = new DateTime(2011, 06, 01),
                EndDate = new DateTime(2011, 07, 01),
            };
        }

        public Tournament CreateWorldCup2010()
        {
            return new Tournament("Copa do Mundo 2010")
            {
                Id = 1,
                Year = 2010,
                StartDate = new DateTime(2010, 06, 01),
                EndDate = new DateTime(2010, 07, 01),
            };

        }
    }
}
