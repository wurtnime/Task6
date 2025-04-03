public class LogicExpressionsTask13
{
    public double Time { get; set; }
    public double Duration { get; set; }
    public double BaseCost { get; set; }
    public int DayOfWeek { get; set; }

    public LogicExpressionsTask13(double time, double duration, double baseCost, int dayOfWeek)
    {
        Time = time;
        Duration = duration;
        BaseCost = baseCost;
        DayOfWeek = dayOfWeek;
    }

    public double CalculateCost()
    {
        double cost = BaseCost;

        if (Time >= 22 || Time < 8)
            cost *= 0.8;

        if (DayOfWeek == 6 || DayOfWeek == 7)
            cost *= 0.9;

        return cost * (Duration / 60);
    }
}
