public class LogicExpressionsTask3
{
    public int m { get; set; }
    public int n { get; set; }
    public int k { get; set; }

    public LogicExpressionsTask3(int m, int n, int k)
    {
        this.m = m;
        this.n = n;
        this.k = k;
    }

    public void CheckConditions()
    {
        if (m + n > k && n > 0)
        {
            Console.WriteLine("Условие выполнено.");
        }
        else
        {
            Console.WriteLine("Условие не выполнено.");
        }
    }
}
