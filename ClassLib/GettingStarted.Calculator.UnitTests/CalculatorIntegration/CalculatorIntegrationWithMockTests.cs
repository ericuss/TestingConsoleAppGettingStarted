
namespace GettingStarted.Calculator.UnitTests.CalculatorIntegration
{
    using Xunit;
    using GettingStarted.Calculator;
    using GettingStarted.Calculator.UnitTests.Mocks;
    using Moq;
    using GettingStarted.Calculator.Services;

    public class CalculatorIntegrationWithMoqTests
    {
        [Theory]
        [InlineData("1", "2", 3)]
        [InlineData("26", "27", 53)]
        [InlineData("30", "31", 61)]
        public void Send_List_Correct_Parameters_And_Verify_Recived_Parameters_In_Service(string parameter1, string parameter2, int expected_result)
        {
            // Arrange 
            var mockedService = new Mock<ISumService>();
            mockedService.Setup(p => p.Sum(
                It.Is<int>(arg => arg.Equals(int.Parse(parameter1))),
                It.Is<int>(arg => arg.Equals(int.Parse(parameter2)))
            ))
            .Returns(expected_result)
            .Verifiable();

            var calculator = new CalculatorIntegration(mockedService.Object);

            // Act
            var result = calculator.Sum(parameter1, parameter2);

            // Assert
            Assert.Equal(expected_result, result);
            mockedService.Verify();
        }

        [Theory]
        [InlineData("1", "2", 3)]
        [InlineData("26", "27", 53)]
        [InlineData("30", "31", 61)]
        public void Send_List_Correct_Parameters_And_Verify_Recived_Parameters_In_Service_Other_Way(string parameter1, string parameter2, int expected_result)
        {
            // Arrange 
            var param1Parsed = int.Parse(parameter1);
            var param2Parsed = int.Parse(parameter2);
            var mockedService = new Mock<ISumService>();
            mockedService.Setup(p => p.Sum(
                It.IsAny<int>(),
                It.IsAny<int>()
            ))
            .Returns(expected_result)
            .Verifiable();

            var calculator = new CalculatorIntegration(mockedService.Object);

            // Act
            var result = calculator.Sum(parameter1, parameter2);

            // Assert
            Assert.Equal(expected_result, result);
            mockedService.Verify(x => x.Sum(param1Parsed, param2Parsed));
        }
        [Theory]
        [InlineData("1", "2", 3)]
        [InlineData("26", "27", 53)]
        [InlineData("30", "31", 61)]
        public void Send_List_Correct_Parameters_And_Verify_Called_Once(string parameter1, string parameter2, int expected_result)
        {
            // Arrange 
            var param1Parsed = int.Parse(parameter1);
            var param2Parsed = int.Parse(parameter2);
            var mockedService = new Mock<ISumService>();
            mockedService.Setup(p => p.Sum(
                It.IsAny<int>(),
                It.IsAny<int>()
            ))
            .Returns(expected_result)
            .Verifiable();

            var calculator = new CalculatorIntegration(mockedService.Object);

            // Act
            var result = calculator.Sum(parameter1, parameter2);

            // Assert
            Assert.Equal(expected_result, result);
            mockedService.Verify(x => x.Sum(param1Parsed, param2Parsed), Times.Once);
        }
    }
}
