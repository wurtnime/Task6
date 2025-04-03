public class LogicExpressionsTask19
{
    public double Experience { get; set; }

    public LogicExpressionsTask19(double experience)
    {
        Experience = experience;
    }

    public double CalculateBonus()
    {
        if (Experience >= 5 && Experience <= 10)
            return 0.02;
        else if (Experience > 10 && Experience <= 20)
            return 0.1;
        else
            return 0;
    }
}
