﻿public class LogicExpressionsTask20
{
    public bool X { get; set; }
    public bool Y { get; set; }
    public bool Z { get; set; }

    public LogicExpressionsTask20(bool x, bool y, bool z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public bool EvaluateExpression()
    {
        return X && !(Y || Z);
    }
}
