public class LogicExpressionsTask1
{
    public int A { get; set; }
    public int B { get; set; }

    public LogicExpressionsTask1(int a, int b)
    {
        A = a;
        B = b;
    }

    public void CheckEvenNumbers()
    {
        bool isOnlyOneEven = (A % 2 == 0 && B % 2 != 0) || (A % 2 != 0 && B % 2 == 0);
        if (isOnlyOneEven)
        {
            Console.WriteLine("Только одно из чисел A и B четное.");
        }
        else
        {
            Console.WriteLine("Либо оба числа четные, либо оба нечетные.");
        }

        bool areAllMultiplesOfThree = (A % 3 == 0) && (B % 3 == 0);
        if (areAllMultiplesOfThree)
        {
            Console.WriteLine("Каждое из чисел A и B кратно трем.");
        }
        else
        {
            Console.WriteLine("Хотя бы одно из чисел A и B не кратно трем.");
        }
    }
}
