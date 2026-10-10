using BlaisePascal.EnemyOrPlayer.Domain;

namespace BlaisePascal.EnemyOrPlayer.UnitTest
{
    public class PlayerTest
    {

        [Fact]
        public void PlayerShouldStartAtLevelOne()
        {
            Player player = new Player("TestPlayer");
            Assert.Equal(1, player.Level);
        }
        [Fact]
        public void PlayerShouldStartWithZeroExperience()
        {
            Player player = new Player("TestPlayer");
            Assert.Equal(0, player.Experience);
        }
        [Fact]
        public void PlayerShouldStartWithFullHealth()
        {
            Player player = new Player("TestPlayer");
            Assert.Equal(player.MaxHealth, player.Health);
        }
        [Fact]
        public void PlayerShouldStartAlive()
        {
            Player player = new Player("TestPlayer");
            Assert.Equal(true,player.IsAlive);
        }
        [Fact]
        public void PlayerShouldStartWithName()
        {
            Player player = new Player("TestPlayer");
            Assert.Equal("TestPlayer", player.Name);
        }

        [Fact]
        public void PlayerShouldStartWith0Gold()
        {
            Player player = new Player("TestPlayer");
            Assert.Equal(0, player.Gold);
        }

        [Fact]
        public void PlayerShouldGainExperience()
        {
            Player player = new Player("TestPlayer");
            player.GainExperience(50);
            Assert.Equal(50, player.Experience);
        }
        [Fact]
        public void PlayerShouldLevelUpAfterGaining100Experience()
        {
            Player player = new Player("TestPlayer");
            player.GainExperience(100);
            Assert.Equal(2, player.Level);
            Assert.Equal(0, player.Experience);
        }

        [Fact]
        public void PlayerShouldNotGainNegativeExperience()
        {
            Player player = new Player("TestPlayer");
            player.GainExperience(-50);
            Assert.Equal(0, player.Experience);
        }

        [Fact]
        public void playerShouldbeAbleToResetExperience()
        {
            Player player = new Player("TestPlayer");
            player.GainExperience(50);
            player.ResetExperience();
            Assert.Equal(0, player.Experience);
        }

        [Fact]
        public void PlayerShouldTakeDamage()
        {
            Player player = new Player("TestPlayer");
            player.TakeDamage(50);
            Assert.Equal(50, player.Health);
        }

        [Fact]
        public void PlayerShouldDieWhenHealthReachesZero()
        {
            Player player = new Player("TestPlayer");
            player.TakeDamage(100);
            Assert.Equal(false, player.IsAlive);
        }

        [Fact]
        public void PlayerShouldNotTakeNegativeDamage()
        {
            Player player = new Player("TestPlayer");
            player.TakeDamage(-50);
            Assert.Equal(100, player.Health);
        }

        [Fact]
        public void PlayerShouldBeAbleToHeal()
        {
            Player player = new Player("TestPlayer");
            player.TakeDamage(50);
            player.Heal(30);
            Assert.Equal(80, player.Health);
        }

        [Fact]
        public void PlayerShouldNotHealBeyondMaxHealth()
        {
            Player player = new Player("TestPlayer");
            player.Heal(50);
            Assert.Equal(100, player.Health);
        }

        [Fact]
        public void PlayerShouldNotHealNegativeAmount()
        {
            Player player = new Player("TestPlayer");
            player.Heal(-50);
            Assert.Equal(100, player.Health);
        }

        [Fact]
        public void PlayerShouldBeAbleToAddGold()
        {
            Player player = new Player("TestPlayer");
            player.AddGold(50);
            Assert.Equal(50, player.Gold);
        }
        [Fact]
        public void PlayerShouldNotAddNegativeGold()
        {
            Player player = new Player("TestPlayer");
            player.AddGold(-50);
            Assert.Equal(0, player.Gold);
        }
        [Fact]
        public void PlayerShouldBeAbleToResetHealth()
        {
            Player player = new Player("TestPlayer");
            player.TakeDamage(50);
            player.ResetHealth();
            Assert.Equal(100, player.Health);
            Assert.Equal(true, player.IsAlive);
        }

    }
}
