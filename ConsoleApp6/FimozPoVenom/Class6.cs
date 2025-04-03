public class LogicExpressionsTask6
{
    public double amount { get; set; }

    public LogicExpressionsTask6(double amount)
    {
        this.amount = amount;
    }

    public double CalculateDeposit()
    {
        if (amount <= 50000)
        {
            return amount * 0.16;
        }
        else
        {
            return amount * 0.18;
        }
    }
}
