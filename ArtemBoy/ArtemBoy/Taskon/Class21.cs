public class LogicExpressionsTask21
{
    public int WorkExperience { get; set; }
    public int EducationLevel { get; set; }

    public LogicExpressionsTask21(int workExperience, int educationLevel)
    {
        WorkExperience = workExperience;
        EducationLevel = educationLevel;
    }

    public string CalculateCoefficient()
    {
        return (WorkExperience > 5 && EducationLevel >= 3) ? "Коэффициент для работы: 13" : "Коэффициент для работы: 12";
    }
}
