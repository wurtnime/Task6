public class LogicExpressionsTask5
{
    public int k { get; set; }
    public int m { get; set; }
    public int n { get; set; }

    public LogicExpressionsTask5(int k, int m, int n)
    {
        this.k = k;
        this.m = m;
        this.n = n;
    }

    public void CheckConditions()
    {
        if (m == k && n > 2)
        {
            Console.WriteLine("Условие выполнено.");
        }
        else
        {
            Console.WriteLine("Условие не выполнено.");
        }
    }
}
