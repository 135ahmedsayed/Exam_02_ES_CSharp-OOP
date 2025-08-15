namespace Exam_02_ES_CSharp_OOP;

internal abstract class Exam
{
    public int TimeExam { get; set; }
    public int QuestionNumber { get; set; }
    public Question[] Questions { get; set; }
    protected Exam(int timeExam, int questionNumber)
    {
        TimeExam = timeExam;
        QuestionNumber = questionNumber;
    }


    //Create abstract CreationQuestions (Final , Practical)
    public abstract void CreationQuestions();
    //Create abstract ShowExam() (Final , Practical)
    public abstract void ShowExam();
}
