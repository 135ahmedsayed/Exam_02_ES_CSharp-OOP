namespace Exam_02_ES_CSharp_OOP;

internal class TrueOrFalse : Question
{
    public TrueOrFalse()
    {
        Answers = new Answers[2];
        Answers[0] = new Answers(1, "True");
        Answers[1] = new Answers(2, "False");
    }
    public override string QuestionHeader => "True | False Question";
    public override void AddQuestion()
    {
        Console.WriteLine(QuestionHeader);
        do
        {
            Console.WriteLine("Please Enter Question Body ");
            QuestionBody = Console.ReadLine()!;
        }
        while (string.IsNullOrWhiteSpace(QuestionBody));
        int M; // iqnore Exception
        do
        {
            Console.WriteLine("Enter the Question Mark ");
            Int32.TryParse(Console.ReadLine()!, out M);
        }
        while (!(M > 0));
        Mark = M;
        int Right;
        do
        {
            Console.WriteLine("Enter the Right Answer ");
            Int32.TryParse(Console.ReadLine()!, out Right);
        }
        while (Right is not (1 or 2));

        RightAnswer.AnswerID = Right;
        RightAnswer.AnswerText = Answers[Right - 1].AnswerText;
        Console.Clear();
    }
}
