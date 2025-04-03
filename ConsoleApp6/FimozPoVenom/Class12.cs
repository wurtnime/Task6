public class LogicExpressionsTask12
{
    public int k { get; set; }
    public int m { get; set; }
    public int n { get; set; }

    public LogicExpressionsTask12(int k, int m, int n)
    {
        this.k = k;
        this.m = m;
        this.n = n;
    }

    public void CheckConditions()
    {
        if (k + m + n > 10 && m > 0)
            Console.WriteLine("Условие выполнено.");
        else
            Console.WriteLine("Условие не выполнено.");
    }
}
