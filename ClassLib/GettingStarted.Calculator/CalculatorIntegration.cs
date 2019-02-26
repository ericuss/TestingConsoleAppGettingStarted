namespace GettingStarted.Calculator
{
    using GettingStarted.Calculator.Services;

    public class CalculatorIntegration
    {
        private readonly ISumService _sumService;

        public CalculatorIntegration(ISumService sumService)
        {
            this._sumService = sumService;
        }

        public int Sum(string parameter1, string parameter2)
        {
            return this._sumService.Sum(int.Parse(parameter1), int.Parse(parameter2));
        }
    }
}
