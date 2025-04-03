using System;

// ZZZ

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Практическая работа №6");
            Console.WriteLine("Введите номер задания от 1 до 21:");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    SolveTask1();
                    break;
                case "2":
                    SolveTask2();
                    break;
                case "3":
                    SolveTask3();
                    break;
                case "4":
                    SolveTask4();
                    break;
                case "5":
                    SolveTask5();
                    break;
                case "6":
                    SolveTask6();
                    break;
                case "7":
                    SolveTask7();
                    break;
                case "8":
                    SolveTask8();
                    break;
                case "9":
                    SolveTask9();
                    break;
                case "10":
                    SolveTask10();
                    break;
                case "11":
                    SolveTask11();
                    break;
                case "12":
                    SolveTask12();
                    break;
                case "13":
                    SolveTask13();
                    break;
                case "14":
                    SolveTask14();
                    break;
                case "15":
                    SolveTask15();
                    break;
                case "16":
                    SolveTask16();
                    break;
                case "17":
                    SolveTask17();
                    break;
                case "18":
                    SolveTask18();
                    break;
                case "19":
                    SolveTask19();
                    break;
                case "20":
                    SolveTask20();
                    break;
                case "21":
                    SolveTask21();
                    break;
                case "0":
                    Console.WriteLine("Выход...");
                    return;
                default:
                    Console.WriteLine("Некорректный ввод. Попробуйте снова.");
                    break;
            }
        }
    }

    static void SolveTask1()
    {
        Console.WriteLine("Введите значения A и B:");
        if (!int.TryParse(Console.ReadLine(), out int A) || !int.TryParse(Console.ReadLine(), out int B))
        {
            Console.WriteLine("Неверный ввод. Пожалуйста, введите целые числа.");
            return;
        }

        LogicExpressionsTask1 task = new LogicExpressionsTask1(A, B);
        task.CheckEvenNumbers();
        Console.WriteLine("\nНажмите любую клавишу для возвращения в меню...");
        Console.ReadKey();
    }

    static void SolveTask2()
    {
        Console.WriteLine("Введите значения m, n, k:");
        if (!int.TryParse(Console.ReadLine(), out int m) || !int.TryParse(Console.ReadLine(), out int n) || !int.TryParse(Console.ReadLine(), out int k))
        {
            Console.WriteLine("Неверный ввод. Пожалуйста, введите целые числа.");
            return;
        }

        LogicExpressionsTask2 task = new LogicExpressionsTask2(m, n, k);
        task.CheckSumCondition();
        Console.WriteLine("\nНажмите любую клавишу для возвращения в меню...");
        Console.ReadKey();
    }

    static void SolveTask3()
    {
        Console.WriteLine("Введите значения m, n и k:");
        if (!int.TryParse(Console.ReadLine(), out int m) || !int.TryParse(Console.ReadLine(), out int n) || !int.TryParse(Console.ReadLine(), out int k))
        {
            Console.WriteLine("Неверный ввод. Пожалуйста, введите целые числа.");
            return;
        }

        LogicExpressionsTask3 task = new LogicExpressionsTask3(m, n, k);
        task.CheckConditions();
        Console.WriteLine("\nНажмите любую клавишу для возвращения в меню...");
        Console.ReadKey();
    }

    static void SolveTask4()
    {
        Console.WriteLine("Введите значение N:");
        if (!int.TryParse(Console.ReadLine(), out int N))
        {
            Console.WriteLine("Неверный ввод. Пожалуйста, введите целое число.");
            return;
        }

        LogicExpressionsTask4 task = new LogicExpressionsTask4(N);
        task.CheckDivisibility();
        Console.WriteLine("\nНажмите любую клавишу для возвращения в меню...");
        Console.ReadKey();
    }

    static void SolveTask5()
    {
        Console.WriteLine("Введите значения k, m и n:");
        if (!int.TryParse(Console.ReadLine(), out int k) || !int.TryParse(Console.ReadLine(), out int m) || !int.TryParse(Console.ReadLine(), out int n))
        {
            Console.WriteLine("Неверный ввод. Пожалуйста, введите целые числа.");
            return;
        }

        LogicExpressionsTask5 task = new LogicExpressionsTask5(k, m, n);
        task.CheckConditions();
        Console.WriteLine("\nНажмите любую клавишу для возвращения в меню...");
        Console.ReadKey();
    }

    static void SolveTask6()
    {
        Console.WriteLine("Введите сумму депозита:");
        if (!double.TryParse(Console.ReadLine(), out double amount))
        {
            Console.WriteLine("Неверный ввод. Пожалуйста, введите корректную сумму.");
            return;
        }

        LogicExpressionsTask6 task = new LogicExpressionsTask6(amount);
        double result = task.CalculateDeposit();

        Console.WriteLine($"Ваша выплата: {result}");
        Console.WriteLine("\nНажмите любую клавишу для возвращения в меню...");
        Console.ReadKey();
    }

    static void SolveTask7()
    {
        Console.WriteLine("Введите число N:");
        if (!int.TryParse(Console.ReadLine(), out int N))
        {
            Console.WriteLine("Неверный ввод. Пожалуйста, введите целое число.");
            return;
        }

        LogicExpressionsTask7 task = new LogicExpressionsTask7(N);
        task.CheckConditions();
        Console.WriteLine("\nНажмите любую клавишу для возвращения в меню...");
        Console.ReadKey();
    }

    static void SolveTask8()
    {
        Console.WriteLine("Введите число N:");
        if (!int.TryParse(Console.ReadLine(), out int N))
        {
            Console.WriteLine("Неверный ввод. Пожалуйста, введите целое число.");
            return;
        }

        LogicExpressionsTask8 task = new LogicExpressionsTask8(N);
        task.CheckDivisibility();
        Console.WriteLine("\nНажмите любую клавишу для возвращения в меню...");
        Console.ReadKey();
    }

    static void SolveTask9()
    {
        Console.WriteLine("Введите m, n и k:");
        if (!int.TryParse(Console.ReadLine(), out int m) || !int.TryParse(Console.ReadLine(), out int n) || !int.TryParse(Console.ReadLine(), out int k))
        {
            Console.WriteLine("Неверный ввод. Пожалуйста, введите целые числа.");
            return;
        }

        LogicExpressionsTask9 task = new LogicExpressionsTask9(m, n, k);
        task.CheckConditions();
        Console.WriteLine("\nНажмите любую клавишу для возвращения в меню...");
        Console.ReadKey();
    }

    static void SolveTask10()
    {
        Console.WriteLine("Введите число N:");
        if (!int.TryParse(Console.ReadLine(), out int N))
        {
            Console.WriteLine("Неверный ввод. Пожалуйста, введите целое число.");
            return;
        }

        LogicExpressionsTask10 task = new LogicExpressionsTask10(N);
        task.CheckConditions();
        Console.WriteLine("\nНажмите любую клавишу для возвращения в меню...");
        Console.ReadKey();
    }

    static void SolveTask11()
    {
        Console.WriteLine("Введите стоимость покупки:");
        if (!double.TryParse(Console.ReadLine(), out double purchaseCost))
        {
            Console.WriteLine("Неверный ввод. Пожалуйста, введите корректную сумму.");
            return;
        }

        LogicExpressionsTask11 task = new LogicExpressionsTask11(purchaseCost);
        double discountPrice = task.CalculateDiscount();
        Console.WriteLine($"Стоимость с учетом скидки: {discountPrice}");
        Console.WriteLine("\nНажмите любую клавишу для возвращения в меню...");
        Console.ReadKey();
    }

    static void SolveTask12()
    {
        Console.WriteLine("Введите k, m и n:");
        if (!int.TryParse(Console.ReadLine(), out int k) || !int.TryParse(Console.ReadLine(), out int m) || !int.TryParse(Console.ReadLine(), out int n))
        {
            Console.WriteLine("Неверный ввод. Пожалуйста, введите целые числа.");
            return;
        }

        LogicExpressionsTask12 task = new LogicExpressionsTask12(k, m, n);
        task.CheckConditions();
        Console.WriteLine("\nНажмите любую клавишу для возвращения в меню...");
        Console.ReadKey();
    }

    static void SolveTask13()
    {
        Console.WriteLine("Введите время разговора, продолжительность разговора, стоимость и день недели:");
        if (!double.TryParse(Console.ReadLine(), out double time) ||
            !double.TryParse(Console.ReadLine(), out double duration) ||
            !double.TryParse(Console.ReadLine(), out double baseCost) ||
            !int.TryParse(Console.ReadLine(), out int dayOfWeek))
        {
            Console.WriteLine("Неверный ввод. Пожалуйста, введите корректные значения.");
            return;
        }

        LogicExpressionsTask13 task = new LogicExpressionsTask13(time, duration, baseCost, dayOfWeek);
        double totalCost = task.CalculateCost();
        Console.WriteLine($"Общая стоимость разговора: {totalCost:F2}");
        Console.WriteLine("\nНажмите любую клавишу для возвращения в меню...");
        Console.ReadKey();
    }

    static void SolveTask14()
    {
        Console.WriteLine("Введите значения X, Y и Z:");
        if (!bool.TryParse(Console.ReadLine(), out bool X) ||
            !bool.TryParse(Console.ReadLine(), out bool Y) ||
            !bool.TryParse(Console.ReadLine(), out bool Z))
        {
            Console.WriteLine("Неверный ввод. Пожалуйста, введите значения true или false.");
            return;
        }

        LogicExpressionsTask14 task = new LogicExpressionsTask14(X, Y, Z);
        task.EvaluateExpression();
        Console.WriteLine("\nНажмите любую клавишу для возвращения в меню...");
        Console.ReadKey();
    }

    static void SolveTask15()
    {
        Console.WriteLine("Введите оценки по предметам:");
        int[] subjects = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        LogicExpressionsTask15 task = new LogicExpressionsTask15(subjects);
        task.CheckScholarshipEligibility();
        Console.WriteLine("\nНажмите любую клавишу для возвращения в меню...");
        Console.ReadKey();
    }

    static void SolveTask16()
    {
        Console.WriteLine("Введите числа A, B, C, D:");
        if (!int.TryParse(Console.ReadLine(), out int A) ||
            !int.TryParse(Console.ReadLine(), out int B) ||
            !int.TryParse(Console.ReadLine(), out int C) ||
            !int.TryParse(Console.ReadLine(), out int D))
        {
            Console.WriteLine("Неверный ввод. Пожалуйста, введите целые числа.");
            return;
        }

        LogicExpressionsTask16 task = new LogicExpressionsTask16(A, B, C, D);
        task.CheckNumbers();
        Console.WriteLine("\nНажмите любую клавишу для возвращения в меню...");
        Console.ReadKey();
    }

    static void SolveTask17()
    {
        Console.WriteLine("Введите A, B, C, D:");
        if (!int.TryParse(Console.ReadLine(), out int A) ||
            !int.TryParse(Console.ReadLine(), out int B) ||
            !int.TryParse(Console.ReadLine(), out int C) ||
            !int.TryParse(Console.ReadLine(), out int D))
        {
            Console.WriteLine("Неверный ввод. Пожалуйста, введите целые числа.");
            return;
        }

        LogicExpressionsTask17 task = new LogicExpressionsTask17(A, B, C, D);
        task.CheckNumbers();
        Console.WriteLine("\nНажмите любую клавишу для возвращения в меню...");
        Console.ReadKey();
    }

    static void SolveTask18()
    {
        Console.WriteLine("Введите стоимость покупки:");
        if (!double.TryParse(Console.ReadLine(), out double purchaseCost))
        {
            Console.WriteLine("Неверный ввод. Пожалуйста, введите корректную сумму.");
            return;
        }

        LogicExpressionsTask18 task = new LogicExpressionsTask18(purchaseCost);
        double discountCost = task.CalculateDiscount();
        Console.WriteLine($"Стоимость с учетом скидки: {discountCost}");
        Console.WriteLine("\nНажмите любую клавишу для возвращения в меню...");
        Console.ReadKey();
    }

    static void SolveTask19()
    {
        Console.WriteLine("Введите стаж:");
        if (!double.TryParse(Console.ReadLine(), out double experience))
        {
            Console.WriteLine("Неверный ввод. Пожалуйста, введите корректный стаж.");
            return;
        }

        LogicExpressionsTask19 task = new LogicExpressionsTask19(experience);
        double bonus = task.CalculateBonus();
        Console.WriteLine($"Надбавка: {bonus * 100}%");
        Console.WriteLine("\nНажмите любую клавишу для возвращения в меню...");
        Console.ReadKey();
    }

    static void SolveTask20()
    {
        Console.WriteLine("Введите X, Y, Z:");
        if (!bool.TryParse(Console.ReadLine(), out bool X) ||
            !bool.TryParse(Console.ReadLine(), out bool Y) ||
            !bool.TryParse(Console.ReadLine(), out bool Z))
        {
            Console.WriteLine("Неверный ввод. Пожалуйста, введите значения true или false.");
            return;
        }

        LogicExpressionsTask20 task = new LogicExpressionsTask20(X, Y, Z);
        task.EvaluateExpression();
        Console.WriteLine("\nНажмите любую клавишу для возвращения в меню...");
        Console.ReadKey();
    }

    static void SolveTask21()
    {
        Console.WriteLine("Введите стаж работы и уровень образования:");
        if (!int.TryParse(Console.ReadLine(), out int workExperience) ||
            !int.TryParse(Console.ReadLine(), out int educationLevel))
        {
            Console.WriteLine("Неверный ввод. Пожалуйста, введите целые числа.");
            return;
        }

        LogicExpressionsTask21 task = new LogicExpressionsTask21(workExperience, educationLevel);
        task.CalculateCoefficient();
        Console.WriteLine("\nНажмите любую клавишу для возвращения в меню...");
        Console.ReadKey();
    }
}

