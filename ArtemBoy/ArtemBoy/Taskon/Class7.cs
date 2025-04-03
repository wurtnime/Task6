public class LogicExpressionsTask7
{
    public int N { get; set; }

    public LogicExpressionsTask7(int n)
    {
        N = n;
    }

    public string CheckConditions()
    {
        return (N % 2 == 0 && N % 3 != 0) ? "Число N четное и не делится на 3." : "Условие не выполнено.";
    }
}
