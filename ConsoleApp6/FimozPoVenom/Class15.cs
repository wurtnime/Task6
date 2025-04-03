public class LogicExpressionsTask15
{
    public int[] Subjects { get; set; }

    public LogicExpressionsTask15(int[] subjects)
    {
        Subjects = subjects;
    }

    public void CheckScholarshipEligibility()
    {
        if ((Subjects.Contains(4) || Subjects.Contains(5)) && Subjects.Length >= 4)
            Console.WriteLine("Студент получает стипендию.");
        else
            Console.WriteLine("Студент не получает стипендию.");
    }
}
