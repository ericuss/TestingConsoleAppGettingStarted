namespace GettingStarted.Calculator.Services
{
    public class SumService : ISumService
    {
        public int Sum(int parameter1, int parameter2)
        {
            return parameter1 + parameter2;
        }
    }
}
