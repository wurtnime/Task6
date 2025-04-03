public class LogicExpressionsTask3
{
    public int M { get; set; }
    public int N { get; set; }
    public int K { get; set; }

    public LogicExpressionsTask3(int m, int n, int k)
    {
        M = m;
        N = n;
        K = k;
    }

    public string CheckConditions()
    {
        return (M + N > K && N > 0) ? "Условие выполнено." : "Условие не выполнено.";
    }
}

