public class LogicExpressionsTask7
{
    public int N { get; set; }

    public LogicExpressionsTask7(int n)
    {
        N = n;
    }

    public void CheckConditions()
    {
        if (N % 2 == 0 && N % 3 != 0)
        {
            Console.WriteLine("Число N четное и не делится на 3.");
        }
        else
        {
            Console.WriteLine("Условие не выполнено.");
        }
    }
}
