using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CB.Rpg.Tests
{
    public class PlayerGenerationTests
    {
        public void GenerateAPlayer()
        {
            PlayerCharacter newPlayerCharacter = new PlayerCharacter("newPlayer", 5, 5, 5);
            Assert.Equal("playerName", newPlayerCharacter.Name);
        }
    }
}
