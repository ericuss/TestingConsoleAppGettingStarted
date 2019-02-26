namespace GettingStarted.Calculator.UnitTests.First
{
    using Xunit;
    using GettingStarted.Calculator;

    public class FirstTests
    {
        [Fact]
        public void Send_True_And_Return_True()
        {
            // Arrange 
            var dummy_parameter = true;
            var expected_parameter = true;

            var first = new First();

            // Act
            var result = first.ReturnBool(dummy_parameter);

            // Assert
            Assert.Equal(expected_parameter, result);
        }

        [Fact]
        public void Send_False_And_Return_False()
        {
            // Arrange 
            var dummy_parameter = false;
            var expected_parameter = false;

            var first = new First();

            // Act
            var result = first.ReturnBool(dummy_parameter);

            // Assert
            Assert.Equal(expected_parameter, result);
        }
    }
}
