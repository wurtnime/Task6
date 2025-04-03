public class LogicExpressionsTask12
{
    public int K { get; set; }
    public int M { get; set; }
    public int N { get; set; }

    public LogicExpressionsTask12(int k, int m, int n)
    {
        K = k;
        M = m;
        N = n;
    }

    public string CheckConditions()
    {
        return (K + M + N > 10 && M > 0) ? "Условие выполнено." : "Условие не выполнено.";
    }
}
