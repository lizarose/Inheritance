namespace Inheritance;
class CheckboxQuestion : Question
{
    //Field
    public List<int> CorrectAnswers { get; set; }

    //Constructor
    public CheckboxQuestion(string prompt, List<string> answers, List<int> correctAnswers) : base(prompt, answers)  
    {  
        CorrectAnswers = correctAnswers;
    }

    //Override
    public override bool CheckAnswer(List<int> selectedAnswers)
    {
        
        //comparing the correct amount of answers needed to be selected with what the user selected
        return CorrectAnswers.Count == selectedAnswers.Count;
    }

    public override string ToString()
    {
        string nl = Environment.NewLine;
        string formattedAnswers = string.Join(nl, Answers);
        return nl + "CHECKBOX: CHOOSE ONE OR MORE" + nl + "Select the Number(s) Associated with the Answer Separated with Commas (x, x): " + nl + Prompt + nl + formattedAnswers;
    }
    //Method
}