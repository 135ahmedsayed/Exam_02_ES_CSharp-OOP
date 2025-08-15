namespace Exam_02_ES_CSharp_OOP;

internal class Answers
{
    public int AnswerID { get; set; }
    public string AnswerText { get; set; } = default!;
    public Answers()
    {

    }
    // Answers for TF
    public Answers(int Id, string Text)
    {
        AnswerID = Id;
        AnswerText = Text;
    }
    public override string ToString()
    {
        return $"{AnswerID} - {AnswerText}";
    }

}
