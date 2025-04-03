public class LogicExpressionsTask11
{
    public double PurchaseCost { get; set; }

    public LogicExpressionsTask11(double purchaseCost)
    {
        PurchaseCost = purchaseCost;
    }

    public double CalculateDiscount()
    {
        if (PurchaseCost > 4000 && PurchaseCost < 6000)
            return PurchaseCost * 0.95;
        else if (PurchaseCost >= 6000 && PurchaseCost < 10000)
            return PurchaseCost * 0.9;
        else
            return PurchaseCost;
    }
}
