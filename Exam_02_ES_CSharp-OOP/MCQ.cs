namespace Exam_02_ES_CSharp_OOP;

internal class MCQ : Question
{
    public override string QuestionHeader => "MCQ Question";
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
        Console.WriteLine("Choices of Question");
        Answers = new Answers[3];
        for (int i = 0; i < Answers.Length; i++)
        {
            Console.WriteLine($"Enter Choice {i + 1} ");
            Answers[i] = new Answers() { AnswerID = i + 1 };
            do
            {
                Answers[i].AnswerText = Console.ReadLine()!;
            }
            while (string.IsNullOrWhiteSpace(Answers[i].AnswerText));
        }
        int Right;
        do
        {
            Console.WriteLine("Enter the Right Answer ");
            Int32.TryParse(Console.ReadLine()!, out Right);
        }
        while (Right is not (1 or 2 or 3));

        RightAnswer.AnswerID = Right;
        RightAnswer.AnswerText = Answers[Right - 1].AnswerText;
        Console.Clear();
    }
}
