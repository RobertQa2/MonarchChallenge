using MonarchsChallenge;

namespace TestMonarch
{
    public class MonarchRullingLenght
    {
        [Test]
        [Description(@"Test to check if the rulingLength property calculated for living monarch.")]
        public void LivingMonarch()
        {
            // Arrange
            var monarch = new MonarchsChallenge.Monarch { Years = "2023-" };

            // Act
            var rulingLength = monarch.RulingLength;

            // Assert
            Assert.AreEqual(2, rulingLength, "Ruling length should be correctly calculated for valid years.");
        }


        [Test]
        [Description(@"Test to check if the rulingLength property calculated foer dead monarch.")]
        public void PastMonarch()
        {
            // Arrange
            var monarch = new MonarchsChallenge.Monarch { Years = "1509-1547" };

            // Act
            var rulingLength = monarch.RulingLength;

            // Assert
            Assert.AreEqual(38, rulingLength, "Ruling length should be correctly calculated for valid years.");
        }

        [Test]
        [Description(@"Test to check if the rulingLength property calculated for a monarch living at the turn of the century.")]
        public void SecondPastMonarch()
        {
            // Arrange
            var monarch = new MonarchsChallenge.Monarch { Years = "998-1002" };

            // Act
            var rulingLength = monarch.RulingLength;

            // Assert
            Assert.AreEqual(4, rulingLength, "Ruling length should be correctly calculated for valid years.");
        }

        [Test]
        [Description(@"Test to check if the rulingLength property calculated without dash.")]
        public void ThirdPastMonarch()
        {
            // Arrange
            var monarch = new MonarchsChallenge.Monarch { Years = "1509 1547" };

            // Act
            var rulingLength = monarch.RulingLength;

            // Assert
            Assert.AreEqual(38, rulingLength, "Ruling length should be correctly calculated for valid years.");
        }

        [Test]
        [Description(@"Test to check if the rulingLength property calculated for a monarch living at the turn of an era.")]
        public void MonarchFromPreviousAndCurrentEra()
        {
            // Arrange
            var monarch = new MonarchsChallenge.Monarch { Years = "-2-6" };

            // Act
            var rulingLength = monarch.RulingLength;

            // Assert
            Assert.AreEqual(8, rulingLength, "Ruling length should be correctly calculated for valid years.");
        }

        [Test]
        [Description(@"Test to check if the rulingLength property calculated for a monarch living at the past era.")]
        public void MonarchFromBC()
        {
            // Arrange
            var monarch = new MonarchsChallenge.Monarch { Years = "26BC-19BC" };

            // Act
            var rulingLength = monarch.RulingLength;

            // Assert
            Assert.AreEqual(7, rulingLength, "Ruling length should be correctly calculated for valid years.");
        }

        [Test]
        [Description(@"Test to check if the rulingLength property calculated for one year reigning monarch.")]
        public void MonarchLivingOneYear()
        {
            // Arrange
            var monarch = new MonarchsChallenge.Monarch { Years = "2014-2014" };

            // Act
            var rulingLength = monarch.RulingLength;

            // Assert
            Assert.AreEqual(1, rulingLength, "Ruling length should be correctly calculated for valid years.");
        }
    }
}