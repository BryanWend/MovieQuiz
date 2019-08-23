//Project, Bryan Wendlandt, CIS 345 12-115
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaNow
{
    [Serializable]
    public class Question
    {
        private string questionText;
        private string feedback;
        private string answerOne;
        private string answerTwo;
        private string answerThree;
        private string answerFour;
        private string correctAnswer;

        public string QuestionText { get; set; }
        public string Feedback { get; set; }
        public string AnswerOne { get; set; }
        public string AnswerTwo { get; set; }
        public string AnswerThree { get; set; }
        public string AnswerFour { get; set; }
        public string CorrectAnswer { get; set; }

        public Question(string questionText, string feedback,
                        string answerOne, string answerTwo,
                        string answerThree, string answerFour,
                        string correctAnswer)
        {
            QuestionText = questionText;
            Feedback = feedback;
            AnswerOne = answerOne;
            AnswerTwo = answerTwo;
            AnswerThree = answerThree;
            AnswerFour = answerFour;
            CorrectAnswer = correctAnswer;
        }

        public override string ToString()
        {
            return QuestionText;
        }
    }
}
