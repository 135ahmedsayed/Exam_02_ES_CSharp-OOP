using System.Diagnostics;

namespace Exam_02_ES_CSharp_OOP;

internal class PracticalExam(int timeExam, int questionNumber) : Exam(timeExam, questionNumber)
{
    public override void CreationQuestions()
    {
        Questions = new Question[QuestionNumber];
        for (int num = 0; num < Questions.Length; num++)
        {

            Questions[num] = new MCQ();
            Questions[num].AddQuestion();

        }

    }

    public override void ShowExam()
    {
        Stopwatch timeSpan = new Stopwatch();
        timeSpan.Start(); // Start TimeExam
        foreach (var question in Questions)
        {
            int UserAnswerId;
            // Check if time is up before showing the question
            if (timeSpan.Elapsed.TotalMinutes >= TimeExam)
            {
                Console.WriteLine("Time is up!");
                break;
            }
            Console.WriteLine(question);
            for (int i = 0; i < question?.Answers.Length; i++)
                Console.WriteLine(question.Answers[i]);
            // Check if time is up before showing the question
            if (timeSpan.Elapsed.TotalMinutes >= TimeExam)
            {
                Console.WriteLine("Time is up!");
                break;
            }
            do
            {
                Console.WriteLine("Please Enter Answer Id");
                Int32.TryParse(Console.ReadLine()!, out UserAnswerId);
            }
            while (UserAnswerId is not (1 or 2 or 3));

            question!.UserAnswer.AnswerID = UserAnswerId;
            question!.UserAnswer.AnswerText = question?.Answers[UserAnswerId - 1].AnswerText!;

        }
        Console.Clear();
        //Create Result
        for (int result = 0; result < Questions?.Length; result++)
        {
            Console.WriteLine($"Question {result + 1} : {Questions[result]?.QuestionBody}");
            Console.WriteLine($"Your Answer => {Questions[result]?.UserAnswer?.AnswerText}");
            Console.WriteLine($"Right Answer => {Questions[result]?.RightAnswer?.AnswerText}");
        }
        Console.WriteLine($"Time = {timeSpan.Elapsed}");
        timeSpan.Stop(); //End TimeExam
    }
}
