namespace Exam_02_ES_CSharp_OOP;

internal abstract class Question
{
    public abstract string QuestionHeader { get; }
    public string QuestionBody { get; set; } = default!;
    public int Mark { get; set; }
    public Answers[] Answers { get; set; } = default!;
    public Answers RightAnswer { get; set; } = default!;
    public Answers UserAnswer { get; set; } = default!;


    public Question()
    {
        RightAnswer = new Answers();
        UserAnswer = new Answers();
    }

    public abstract void AddQuestion();

    public override string ToString()
    {
        return $"{QuestionHeader} \t Mark{Mark} \n \n{QuestionBody}\n";
    }
}
