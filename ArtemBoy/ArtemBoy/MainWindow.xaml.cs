using System;
using System.Linq;
using System.Windows;

// При поддержки ООО <<С Узловой за двоих>>

namespace LogicExpressionsWPFApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SolveButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(TaskNumberTextBox.Text, out int taskNumber) && taskNumber >= 1 && taskNumber <= 21)
            {
                OutputTextBlock.Text = string.Empty;

                string input = InputValuesTextBox.Text;
                string[] values = input.Split(',');

                switch (taskNumber)
                {
                    case 1:
                        SolveTask1(values);
                        break;
                    case 2:
                        SolveTask2(values);
                        break;
                    case 3:
                        SolveTask3(values);
                        break;
                    case 4:
                        SolveTask4(values);
                        break;
                    case 5:
                        SolveTask5(values);
                        break;
                    case 6:
                        SolveTask6(values);
                        break;
                    case 7:
                        SolveTask7(values);
                        break;
                    case 8:
                        SolveTask8(values);
                        break;
                    case 9:
                        SolveTask9(values);
                        break;
                    case 10:
                        SolveTask10(values);
                        break;
                    case 11:
                        SolveTask11(values);
                        break;
                    case 12:
                        SolveTask12(values);
                        break;
                    case 13:
                        SolveTask13(values);
                        break;
                    case 14:
                        SolveTask14(values);
                        break;
                    case 15:
                        SolveTask15(values);
                        break;
                    case 16:
                        SolveTask16(values);
                        break;
                    case 17:
                        SolveTask17(values);
                        break;
                    case 18:
                        SolveTask18(values);
                        break;
                    case 19:
                        SolveTask19(values);
                        break;
                    case 20:
                        SolveTask20(values);
                        break;
                    case 21:
                        SolveTask21(values);
                        break;
                    default:
                        OutputTextBlock.Text = "Некорректный номер задания.";
                        break;
                }
            }
            else
            {
                OutputTextBlock.Text = "Пожалуйста, введите корректный номер задания (от 1 до 21).";
            }
        }

        private void SolveTask1(string[] values)
        {
            int A = int.Parse(values[0]);
            int B = int.Parse(values[1]);
            LogicExpressionsTask1 task = new LogicExpressionsTask1(A, B);
            string result = task.CheckEvenNumbers();
            OutputTextBlock.Text = result;
        }

        private void SolveTask2(string[] values)
        {
            int m = int.Parse(values[0]);
            int n = int.Parse(values[1]);
            int k = int.Parse(values[2]);
            LogicExpressionsTask2 task = new LogicExpressionsTask2(m, n, k);
            string result = task.CheckSumCondition();
            OutputTextBlock.Text = result;
        }

        private void SolveTask3(string[] values)
        {
            int m = int.Parse(values[0]);
            int n = int.Parse(values[1]);
            int k = int.Parse(values[2]);
            LogicExpressionsTask3 task = new LogicExpressionsTask3(m, n, k);
            string result = task.CheckConditions();
            OutputTextBlock.Text = result;
        }

        private void SolveTask4(string[] values)
        {
            int N = int.Parse(values[0]);
            LogicExpressionsTask4 task = new LogicExpressionsTask4(N);
            string result = task.CheckDivisibility();
            OutputTextBlock.Text = result;
        }

        private void SolveTask5(string[] values)
        {
            int k = int.Parse(values[0]);
            int m = int.Parse(values[1]);
            int n = int.Parse(values[2]);
            LogicExpressionsTask5 task = new LogicExpressionsTask5(k, m, n);
            string result = task.CheckConditions();
            OutputTextBlock.Text = result;
        }

        private void SolveTask6(string[] values)
        {
            double amount = double.Parse(values[0]);
            LogicExpressionsTask6 task = new LogicExpressionsTask6(amount);
            double result = task.CalculateDeposit();
            OutputTextBlock.Text = $"Ваша выплата: {result}";
        }

        private void SolveTask7(string[] values)
        {
            int N = int.Parse(values[0]);
            LogicExpressionsTask7 task = new LogicExpressionsTask7(N);
            string result = task.CheckConditions();
            OutputTextBlock.Text = result;
        }

        private void SolveTask8(string[] values)
        {
            int N = int.Parse(values[0]);
            LogicExpressionsTask8 task = new LogicExpressionsTask8(N);
            string result = task.CheckDivisibility();
            OutputTextBlock.Text = result;
        }

        private void SolveTask9(string[] values)
        {
            int m = int.Parse(values[0]);
            int n = int.Parse(values[1]);
            int k = int.Parse(values[2]);
            LogicExpressionsTask9 task = new LogicExpressionsTask9(m, n, k);
            string result = task.CheckConditions();
            OutputTextBlock.Text = result;
        }

        private void SolveTask10(string[] values)
        {
            int N = int.Parse(values[0]);
            LogicExpressionsTask10 task = new LogicExpressionsTask10(N);
            string result = task.CheckConditions();
            OutputTextBlock.Text = result;
        }

        private void SolveTask11(string[] values)
        {
            double purchaseCost = double.Parse(values[0]);
            LogicExpressionsTask11 task = new LogicExpressionsTask11(purchaseCost);
            double result = task.CalculateDiscount();
            OutputTextBlock.Text = $"Стоимость с учетом скидки: {result}";
        }

        private void SolveTask12(string[] values)
        {
            int k = int.Parse(values[0]);
            int m = int.Parse(values[1]);
            int n = int.Parse(values[2]);
            LogicExpressionsTask12 task = new LogicExpressionsTask12(k, m, n);
            string result = task.CheckConditions();
            OutputTextBlock.Text = result;
        }

        private void SolveTask13(string[] values)
        {
            double time = double.Parse(values[0]);
            double duration = double.Parse(values[1]);
            double baseCost = double.Parse(values[2]);
            int dayOfWeek = int.Parse(values[3]);
            LogicExpressionsTask13 task = new LogicExpressionsTask13(time, duration, baseCost, dayOfWeek);
            double result = task.CalculateCost();
            OutputTextBlock.Text = $"Общая стоимость разговора: {result:F2}";
        }

        private void SolveTask14(string[] values)
        {
            bool X = bool.Parse(values[0]);
            bool Y = bool.Parse(values[1]);
            bool Z = bool.Parse(values[2]);
            LogicExpressionsTask14 task = new LogicExpressionsTask14(X, Y, Z);
            bool result = task.EvaluateExpression();
            OutputTextBlock.Text = $"Результат логического выражения: {result}";
        }

        private void SolveTask15(string[] values)
        {
            int[] subjects = values.Select(v => int.Parse(v)).ToArray();
            LogicExpressionsTask15 task = new LogicExpressionsTask15(subjects);
            string result = task.CheckScholarshipEligibility();
            OutputTextBlock.Text = result;
        }

        private void SolveTask16(string[] values)
        {
            int A = int.Parse(values[0]);
            int B = int.Parse(values[1]);
            int C = int.Parse(values[2]);
            int D = int.Parse(values[3]);
            LogicExpressionsTask16 task = new LogicExpressionsTask16(A, B, C, D);
            string result = task.CheckNumbers();
            OutputTextBlock.Text = result;
        }

        private void SolveTask17(string[] values)
        {
            int A = int.Parse(values[0]);
            int B = int.Parse(values[1]);
            int C = int.Parse(values[2]);
            int D = int.Parse(values[3]);
            LogicExpressionsTask17 task = new LogicExpressionsTask17(A, B, C, D);
            string result = task.CheckNumbers();
            OutputTextBlock.Text = result;
        }

        private void SolveTask18(string[] values)
        {
            double purchaseCost = double.Parse(values[0]);
            LogicExpressionsTask18 task = new LogicExpressionsTask18(purchaseCost);
            double result = task.CalculateDiscount();
            OutputTextBlock.Text = $"Стоимость с учетом скидки: {result}";
        }

        private void SolveTask19(string[] values)
        {
            double experience = double.Parse(values[0]);
            LogicExpressionsTask19 task = new LogicExpressionsTask19(experience);
            double result = task.CalculateBonus();
            OutputTextBlock.Text = $"Надбавка: {result * 100}%";
        }

        private void SolveTask20(string[] values)
        {
            bool X = bool.Parse(values[0]);
            bool Y = bool.Parse(values[1]);
            bool Z = bool.Parse(values[2]);
            LogicExpressionsTask20 task = new LogicExpressionsTask20(X, Y, Z);
            bool result = task.EvaluateExpression();
            OutputTextBlock.Text = $"Результат логического выражения: {result}";
        }

        private void SolveTask21(string[] values)
        {
            int workExperience = int.Parse(values[0]);
            int educationLevel = int.Parse(values[1]);
            LogicExpressionsTask21 task = new LogicExpressionsTask21(workExperience, educationLevel);
            string result = task.CalculateCoefficient();
            OutputTextBlock.Text = result;
        }
    }
}
