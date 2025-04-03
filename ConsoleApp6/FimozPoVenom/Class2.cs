public class LogicExpressionsTask2
{
    public int m { get; set; }
    public int n { get; set; }
    public int k { get; set; }

    public LogicExpressionsTask2(int m, int n, int k)
    {
        this.m = m;
        this.n = n;
        this.k = k;
    }

    public void CheckSumCondition()
    {
        if (m + n > k)
        {
            Console.WriteLine("Условие m + n > k выполнено.");
        }
        else
        {
            Console.WriteLine("Условие m + n > k не выполнено.");
        }
    }
}
