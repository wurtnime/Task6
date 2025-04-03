public class LogicExpressionsTask18
{
    public double PurchaseCost { get; set; }

    public LogicExpressionsTask18(double purchaseCost)
    {
        PurchaseCost = purchaseCost;
    }

    public double CalculateDiscount()
    {
        if (PurchaseCost >= 10000 && PurchaseCost < 20000)
            return PurchaseCost * 0.95;
        else if (PurchaseCost >= 20000 && PurchaseCost < 50000)
            return PurchaseCost * 0.9;
        else
            return PurchaseCost;
    }
}
