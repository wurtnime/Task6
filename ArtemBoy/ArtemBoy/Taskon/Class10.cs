public class LogicExpressionsTask10
{
    public int N { get; set; }

    public LogicExpressionsTask10(int n)
    {
        N = n;
    }

    public string CheckConditions()
    {
        return (N % 3 != 0 && (N % 7 == 0 || N % 8 == 0 || N % 11 == 0)) ? "Условие выполнено." : "Условие не выполнено.";
    }
}
