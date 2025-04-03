public class LogicExpressionsTask21
{
    public int WorkExperience { get; set; }
    public int EducationLevel { get; set; }

    public LogicExpressionsTask21(int workExperience, int educationLevel)
    {
        WorkExperience = workExperience;
        EducationLevel = educationLevel;
    }

    public void CalculateCoefficient()
    {
        if (WorkExperience > 5 && EducationLevel >= 3)
            Console.WriteLine("Коэффициент для работы: 13");
        else
            Console.WriteLine("Коэффициент для работы: 12");
    }
}
