

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
        //Checks for all correct answers && number of correct answers are selected (not any extra or missing any correct answers)
        foreach (int correctOption in CorrectAnswers)
        {
            //if missing at least one correct answer -return false
            if(!selectedAnswers.Contains(correctOption))
                return false;
        }
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
