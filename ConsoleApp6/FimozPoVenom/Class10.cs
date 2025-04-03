public class LogicExpressionsTask10
{
    public int N { get; set; }

    public LogicExpressionsTask10(int n)
    {
        N = n;
    }

    public void CheckConditions()
    {
        if (N % 3 != 0 && (N % 7 == 0 || N % 8 == 0 || N % 11 == 0))
        {
            Console.WriteLine("Условие выполнено.");
        }
        else
        {
            Console.WriteLine("Условие не выполнено.");
        }
    }
}
