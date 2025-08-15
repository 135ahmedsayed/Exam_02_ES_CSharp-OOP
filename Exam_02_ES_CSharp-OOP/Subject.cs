namespace Exam_02_ES_CSharp_OOP;

internal class Subject
{
    public int SubjectId { get; set; }
    public string SubjectName { get; set; } = default!;
    public Exam SubjectExam { get; set; }
    public Subject(int subjectId, string subjectName)
    {
        this.SubjectId = subjectId;
        this.SubjectName = subjectName;
    }
    // create Exam
    public void CreateExam()
    {
        int x, time, questionNumber;
        do
        {
            Console.WriteLine("Please Enter the type of Exam (1 for Practical | 2 for Final)");
            Int32.TryParse(Console.ReadLine()!, out x);
        }
        while ((x != 1 && x != 2));
        do
        {
            Console.WriteLine("Please Enter the Time for Exam From (30 min to 180 min)");
            Int32.TryParse(Console.ReadLine()!, out time);
        }
        while (time < 30 || time > 180);
        do
        {
            Console.WriteLine("Please Enter the Number of questions");
            Int32.TryParse(Console.ReadLine()!, out questionNumber);
        }
        while (!(questionNumber > 0));
        Console.Clear();
        if (x == 1)
        {
            SubjectExam = new PracticalExam(time, questionNumber);
            SubjectExam.CreationQuestions();
        }
        else
        {
            SubjectExam = new FinalExam(time, questionNumber);
            SubjectExam.CreationQuestions();
        }
    }
}
