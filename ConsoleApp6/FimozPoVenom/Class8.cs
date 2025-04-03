public class LogicExpressionsTask8
{
    public int N { get; set; }

    public LogicExpressionsTask8(int n)
    {
        N = n;
    }

    public void CheckDivisibility()
    {
        if (N % 3 == 0 && N % 7 == 0)
        {
            Console.WriteLine("Число N делится на 3 и 7.");
        }
        else
        {
            Console.WriteLine("Число не делится на 3 и 7.");
        }
    }
}
