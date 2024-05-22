
namespace Inheritance;

public abstract class Question
{
    //Field
    public string Prompt { get; set; }
    public List<string> Answers { get; set; }
    

    
    //Constructor
    public Question(string prompt, List<string> answers)
    {
        Prompt = prompt;
        Answers = answers;
    }

    //Override


    //Method
    public abstract bool CheckAnswer(List<int> selectedAnswers);
    public abstract override string ToString();
}



    