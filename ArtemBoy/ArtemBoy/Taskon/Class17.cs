public class LogicExpressionsTask17
{
    public int A { get; set; }
    public int B { get; set; }
    public int C { get; set; }
    public int D { get; set; }

    public LogicExpressionsTask17(int a, int b, int c, int d)
    {
        A = a;
        B = b;
        C = c;
        D = d;
    }

    public string CheckNumbers()
    {
        return (A + B + C) % 3 == 0 && D % 5 == 0 ? "Условие выполнено." : "Условие не выполнено.";
    }
}
