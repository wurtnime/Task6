public class LogicExpressionsTask16
{
    public int A { get; set; }
    public int B { get; set; }
    public int C { get; set; }
    public int D { get; set; }

    public LogicExpressionsTask16(int a, int b, int c, int d)
    {
        A = a;
        B = b;
        C = c;
        D = d;
    }

    public string CheckNumbers()
    {
        return (A % 2 == 0 && B % 2 == 0 && C % 2 == 0 && D % 2 == 0) ? "Все числа четные." : "Не все числа четные.";
    }
}
