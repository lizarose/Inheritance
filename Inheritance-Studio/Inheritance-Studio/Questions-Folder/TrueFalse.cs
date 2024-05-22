namespace Inheritance;
public class TrueFalseQuestion : Question
{

    //Field
    public bool CorrectAnswer = true;

    //Constructor
     public TrueFalseQuestion(string prompt, List<string> answers) : base(prompt, answers)  
    {  
    
    }

    //Override
    public override bool CheckAnswer(List<int> selectedAnswers)
    {
 
        return (selectedAnswers[0] == 0) == CorrectAnswer;
    }

    public override string ToString()
    {
        string nl = Environment.NewLine;
        string formattedAnswers = string.Join(nl, Answers);
        return nl + "TRUE OR FALSE" + nl + "Select the Number Associated with the Answer:" + nl + Prompt + nl + formattedAnswers;
    }
    //Method
}
