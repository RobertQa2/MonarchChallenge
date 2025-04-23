using MonarchsChallenge;

namespace TestMonarch
{
    public class CorrectNameReturn
    {

        [Test]
        [Description(@"Test to check if the Name property returns the correct first name.")]
        public void ShouldReturnCorrectFirstName()
        {
            // Arrange
            var monarch = new MonarchsChallenge.Monarch { Name = "Henry VIII" };

            // Act
            var firstName = monarch.FirstName;

            // Assert
            Assert.AreEqual("Henry", firstName, "FirstName should return the first part of the name.");
        }


        [Test]
        [Description(@"Test to check if the Name property returns the correct first name with a dash instead of spaces.")]
        public void ShouldReturnCorrectFirstNameWithoutDash()
        {
            // Arrange
            var monarch = new MonarchsChallenge.Monarch { Name = "Henry-VIII" };

            // Act
            var firstName = monarch.FirstName;

            // Assert
            Assert.AreEqual("Henry", firstName, "FirstName should return the first part of the name.");
        }
    }
}