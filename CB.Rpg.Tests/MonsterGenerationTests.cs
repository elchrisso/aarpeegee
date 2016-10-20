using System;
using System.Collections.Generic;
using Xunit;

namespace CB.Rpg.Tests
{
    public class MonsterGenerationTests
    {
        [Fact]
        public void GenerateAMonster()
        {
            Monster newMonster = new Monster("bob", 7, 6, 2, 12);

            Assert.Equal(newMonster.Name, "bob");
        }
    }
}
