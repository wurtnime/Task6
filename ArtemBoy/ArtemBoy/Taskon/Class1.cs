public class LogicExpressionsTask1
{
    public int A { get; set; }
    public int B { get; set; }

    public LogicExpressionsTask1(int a, int b)
    {
        A = a;
        B = b;
    }

    public string CheckEvenNumbers()
    {
        bool isOnlyOneEven = (A % 2 == 0 && B % 2 != 0) || (A % 2 != 0 && B % 2 == 0);
        return isOnlyOneEven ? "Только одно из чисел A и B четное." : "Либо оба числа четные, либо оба нечетные.";
    }
}
