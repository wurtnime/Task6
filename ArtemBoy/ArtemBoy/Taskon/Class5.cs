public class LogicExpressionsTask5
{
    public int K { get; set; }
    public int M { get; set; }
    public int N { get; set; }

    public LogicExpressionsTask5(int k, int m, int n)
    {
        K = k;
        M = m;
        N = n;
    }

    public string CheckConditions()
    {
        return (M == K && N > 2) ? "Условие выполнено." : "Условие не выполнено.";
    }
}
