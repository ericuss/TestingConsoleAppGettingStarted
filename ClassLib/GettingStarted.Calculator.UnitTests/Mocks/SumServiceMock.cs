namespace GettingStarted.Calculator.UnitTests.Mocks
{
    using GettingStarted.Calculator.Services;

    public class SumServiceMock : ISumService
    {
        public int Sum(int parameter1, int parameter2)
        {
            return parameter1 + parameter2;
        }
    }
}
