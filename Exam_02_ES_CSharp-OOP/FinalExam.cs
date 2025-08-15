using System.Diagnostics;

namespace Exam_02_ES_CSharp_OOP;

internal class FinalExam(int timeExam, int questionNumber) : Exam(timeExam, questionNumber)
{
    public override void CreationQuestions()
    {
        Questions = new Question[QuestionNumber];
        for (int num = 0; num < Questions.Length; num++)
        {
            int questionType;
            do
            {
                Console.WriteLine("Enter the Type of Questions (1 for Mcq | 2 for True | False) ");
                Int32.TryParse(Console.ReadLine()!, out questionType);
            }
            while (questionType != 1 && questionType != 2);
            if (questionType == 1)
            {
                Questions[num] = new MCQ();
                Questions[num].AddQuestion();
            }
            else
            {
                Questions[num] = new TrueOrFalse();
                Questions[num].AddQuestion();
            }
        }

    }
    public override void ShowExam()
    {
        Stopwatch timeSpan = new Stopwatch();
        timeSpan.Start(); // Start TimeExam
        int grade = 0;
        int totalMarks = 0;
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
            if (question?.GetType() == typeof(MCQ))
                do
                {
                    Console.WriteLine("Please Enter Answer Id");
                    Int32.TryParse(Console.ReadLine()!, out UserAnswerId);
                }
                while (UserAnswerId is not (1 or 2 or 3));
            else
                do
                {
                    Console.WriteLine("Please Enter Answer Id");
                    Int32.TryParse(Console.ReadLine()!, out UserAnswerId);
                }
                while (UserAnswerId is not (1 or 2));

            question!.UserAnswer.AnswerID = UserAnswerId;
            question!.UserAnswer.AnswerText = question?.Answers[UserAnswerId - 1].AnswerText!;

        }
        for (int result = 0; result < Questions?.Length; result++)
        {
            totalMarks += Questions[result].Mark;
            if (Questions[result].UserAnswer.AnswerID == Questions[result].RightAnswer.AnswerID)
            {
                grade += Questions[result].Mark;
            }

        }
        Console.Clear();
        //Create Result
        for (int result = 0; result < Questions?.Length; result++)
        {
            Console.WriteLine($"Question {result + 1} : {Questions[result]?.QuestionBody}");
            Console.WriteLine($"Your Answer => {Questions[result]?.UserAnswer?.AnswerText}");
            Console.WriteLine($"Right Answer => {Questions[result]?.RightAnswer?.AnswerText}");
        }
        Console.WriteLine($"Your Grade is {grade} from {totalMarks}");
        Console.WriteLine($"Time = {timeSpan.Elapsed}");
        timeSpan.Stop();
    }
}
