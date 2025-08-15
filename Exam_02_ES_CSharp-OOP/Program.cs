namespace Exam_02_ES_CSharp_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Create Exam
            Subject subject = new Subject(1, "C# OOP");
            subject.CreateExam();

            // I ask you to start the exam or not
            char start;
            do
            {
                Console.WriteLine("Do you want To start Exam (y | n)");
                Char.TryParse(Console.ReadLine()!, out start);
            }
            while (start is not ('y' or 'Y' or 'n' or 'N'));
            Console.Clear();
            if (start is 'y' or 'Y')
                subject.SubjectExam.ShowExam();
            Console.WriteLine("Thank You");
            Console.ReadLine();
        }
    }
}
