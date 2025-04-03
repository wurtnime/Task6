public class LogicExpressionsTask9
{
    public int M { get; set; }
    public int N { get; set; }
    public int K { get; set; }

    public LogicExpressionsTask9(int m, int n, int k)
    {
        M = m;
        N = n;
        K = k;
    }

    public string CheckConditions()
    {
        return (M > N && N < K) ? "Условие выполнено." : "Условие не выполнено.";
    }
}
