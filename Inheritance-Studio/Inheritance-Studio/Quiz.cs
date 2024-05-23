using System.Xml;
namespace Inheritance;
public class Quiz
{
    //Field
    public readonly List<Question> questions = [];

    //Constructor

    //Override

    //Method
    public void RunQuiz()
    {
        //*Score Tracker
        int totalQuestions = questions.Count;
        int totalCorrectAnswers = 0;

        foreach (Question question in questions)
        {
            //Print Question
            Console.WriteLine(question);
            //Prompt User for their answers
            Console.Write("Enter your answer(s): ");
            //Read user's answers
            string userAnswers = Console.ReadLine();
            int results = 0;

            //Taking user's answers and converting to int so can add to List to be compared
            string[] strArr = userAnswers.Split(",");
            List<int> intList = new();
            foreach (string s in strArr)
            {
                int myInt;
                if (int.TryParse(s, out myInt))
                {
                    intList.Add(myInt);
                }
            }
            //Comparing selected answers with the correct answers
            bool isCorrect = question.CheckAnswer(intList);
           
            //Giving feedback to the user based on if they got the answer right
            if(isCorrect)
            {
                totalCorrectAnswers++;
            }
            Console.WriteLine(isCorrect ? "Correct!" : "Incorrect.");
        }
        //*Grade Quiz
        double percentage = (double)totalCorrectAnswers / totalQuestions * 100;
        string stars = "************************************";

        if(percentage == 100)
        {
            Console.WriteLine(Environment.NewLine + stars);
            Console.WriteLine("************Great Job!**************");
        }
        else
        {
            Console.WriteLine(Environment.NewLine + stars);
            Console.WriteLine("Ouch! Looks like you could do some more studying.");
        }

        Console.WriteLine(Environment.NewLine + $"Your score: {totalCorrectAnswers} out of {totalQuestions} which is {percentage}%");
        Console.WriteLine(stars);

    }
}