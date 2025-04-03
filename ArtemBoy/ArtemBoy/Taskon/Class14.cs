public class LogicExpressionsTask14
{
    public bool X { get; set; }
    public bool Y { get; set; }
    public bool Z { get; set; }

    public LogicExpressionsTask14(bool x, bool y, bool z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public bool EvaluateExpression()
    {
        return !(X && Y) || (X && Z);
    }
}
