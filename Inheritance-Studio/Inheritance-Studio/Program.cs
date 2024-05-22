namespace Inheritance;
using System;
using System.Collections.Generic;
using System.Transactions;

class Program
{
    static void Main()
    {
        // Create a quiz
        Quiz quiz = new();

        //Multiple Choice Question
        string q1Prompt = "What is the capital of France?";
        List<string> q1Answers = new List<string> { "0) Paris", "1) London", "2) Berlin", "3) Rome" }; //correct: Paris - 0

        MultipleChoiceQuestion q1 = new(q1Prompt, q1Answers);

        //Checkbox Question
        string q2Prompt = "Which programming languages are statically typed?";
        List<string> q2Answers = new List<string> { "0) Python", "1) Java", "2) C#", "3) JavaScript" }; //correct: Java, C# - 1, 2
        List<int> q2CorrectAnswers = new List<int> { 1, 2 };
        CheckboxQuestion q2 = new(q2Prompt, q2Answers, q2CorrectAnswers);

        //True False Question
        string q3Prompt = "C# is an object-oriented programming language.";
        List<string> q3Answers = new List<string> {"0) True", "1) False"}; //correct: True - 0
        TrueFalseQuestion q3 = new(q3Prompt, q3Answers);


        // Run the quiz
        Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Welcome to the Quiz " + name +"!");
        quiz.questions.AddRange([q1, q2, q3]);
        quiz.RunQuiz();
    }
}