public class LogicExpressionsTask15
{
    public int[] Subjects { get; set; }

    public LogicExpressionsTask15(int[] subjects)
    {
        Subjects = subjects;
    }

    public string CheckScholarshipEligibility()
    {
        return (Subjects.Contains(4) || Subjects.Contains(5)) && Subjects.Length >= 4 ? "Студент получает стипендию." : "Студент не получает стипендию.";
    }
}
