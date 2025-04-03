public class LogicExpressionsTask6
{
    public double Amount { get; set; }

    public LogicExpressionsTask6(double amount)
    {
        Amount = amount;
    }

    public double CalculateDeposit()
    {
        return (Amount <= 50000) ? Amount * 0.16 : Amount * 0.18;
    }
}
