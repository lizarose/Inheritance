namespace Inheritance;
class MultipleChoiceQuestion : Question
{
    //Field
    public char CorrectAnswer { get; set; }

    //Constructor
    public MultipleChoiceQuestion(string prompt, List<string> answers) : base(prompt, answers)  
    {  
    }

    //Override
    public override bool CheckAnswer(List<int> selectedAnswers)
    {
        //Checks to make sure only 1 option is selected && comparing index with corrent answer
        return selectedAnswers.Count == 1 && selectedAnswers[0] == CorrectAnswer;
    }

     public override string ToString()
    {
        string nl = Environment.NewLine;
        string formattedAnswers = string.Join(nl, Answers);
         return nl + "MULITPLE CHOICE" + nl + "Select the Number Associated with the Answer:" + nl + Prompt + nl + formattedAnswers;
    }
    //Method
}