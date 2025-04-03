public class LogicExpressionsTask2
{
    public int M { get; set; }
    public int N { get; set; }
    public int K { get; set; }

    public LogicExpressionsTask2(int m, int n, int k)
    {
        M = m;
        N = n;
        K = k;
    }

    public string CheckSumCondition()
    {
        return (M + N > K) ? "Условие m + n > k выполнено." : "Условие m + n > k не выполнено.";
    }
}
