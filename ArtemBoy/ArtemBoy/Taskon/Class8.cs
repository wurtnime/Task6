public class LogicExpressionsTask8
{
    public int N { get; set; }

    public LogicExpressionsTask8(int n)
    {
        N = n;
    }

    public string CheckDivisibility()
    {
        return (N % 3 == 0 && N % 7 == 0) ? "Число N делится на 3 и 7." : "Число не делится на 3 и 7.";
    }
}
