public class LogicExpressionsTask4
{
    public int N { get; set; }

    public LogicExpressionsTask4(int n)
    {
        N = n;
    }

    public string CheckDivisibility()
    {
        return (N % 9 == 0 && N % 4 == 0 && N % 5 != 0) ? "Число делится на 9 и 4, но не делится на 5." : "Условие не выполнено.";
    }
}
