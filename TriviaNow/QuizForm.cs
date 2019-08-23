//Project, Bryan Wendlandt, CIS 345 12-115
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace TriviaNow
{
    public delegate void NewQuiz();

    public partial class QuizForm : Form
    {
        int currentQuestion;
        RadioButton selectedRadioButton;
        BindingList<Question> quizQuestions;
        int correctCount;
        SoundPlayer correctEffect;
        SoundPlayer wrongEffect;
        SoundPlayer backgroundMusic;

        public QuizForm()
        {
            InitializeComponent();
        }

        //Pass it a list of 3 questions to use from the main form
        public QuizForm(BindingList<Question> questions)
        {
            InitializeComponent();
            quizQuestions = questions;
            correctCount = 0;

            //Display the first question
            currentQuestion = 0;
            questionTrackerLabel.Text = $"{currentQuestion + 1} / 3";
            questionTextLabel.Text = quizQuestions[currentQuestion].QuestionText;
            feedbackDisplayLabel.Visible = false;
            finalTotalLabel.Visible = false;
            answerOneRadioButton.Text = quizQuestions[currentQuestion].AnswerOne;
            answerTwoRadioButton.Text = quizQuestions[currentQuestion].AnswerTwo;
            answerThreeRadioButton.Text = quizQuestions[currentQuestion].AnswerThree;
            answerFourRadioButton.Text = quizQuestions[currentQuestion].AnswerFour;
            

            //Wire menu items
            quitToolStripMenuItem.Click += new EventHandler(exitButton_Click);

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //If they click submit, validate answer
            if(submitButton.Text == "&Submit")
            {
                feedbackDisplayLabel.Visible = true;

                //Call method to find checked
                selectedRadioButton = CheckedButton(questionPanel);

                //If correct, show "Correct" + Feedback
                if (selectedRadioButton.Text == quizQuestions[currentQuestion].CorrectAnswer)
                {
                    feedbackDisplayLabel.Text = $"Correct! {quizQuestions[currentQuestion].Feedback}";
                    correctCount += 1;
                    //Play sound effect
                    //correctEffect.Play();
                }
                //Else show "Wrong" + Feedback
                else
                {
                    feedbackDisplayLabel.Text = $"Wrong! {quizQuestions[currentQuestion].Feedback}";
                    //Play sound effect
                    //wrongEffect.Play();
                }
                //Change it to Next
                submitButton.Text = "&Next";

                //When 3 questions have been shown, only let them exit, not continue
                if (currentQuestion == 2)
                {
                    submitButton.Visible = false;
                    finalTotalLabel.Visible = true;
                    finalTotalLabel.Text = $"You Got {correctCount} Correct! Can you do better?";
                }
            }
            else
            {
                //Display next question
                currentQuestion += 1;
                questionTrackerLabel.Text = $"{currentQuestion + 1} / 3";
                questionTextLabel.Text = quizQuestions[currentQuestion].QuestionText;
                feedbackDisplayLabel.Visible = false;
                answerOneRadioButton.Text = quizQuestions[currentQuestion].AnswerOne;
                answerTwoRadioButton.Text = quizQuestions[currentQuestion].AnswerTwo;
                answerThreeRadioButton.Text = quizQuestions[currentQuestion].AnswerThree;
                answerFourRadioButton.Text = quizQuestions[currentQuestion].AnswerFour;
                submitButton.Text = "&Submit";
                selectedRadioButton.Checked = false;
                //backgroundMusic.PlayLooping();

            }
        }

        //Method to see what button is check
        private RadioButton CheckedButton(Panel panel)
        {
            RadioButton rb;

            //Loops through controls within the panel
            foreach (Control c in panel.Controls)
            {
                if(c is RadioButton)
                {
                    //Downcast as a radioButton
                    rb = c as RadioButton;

                    //If it is the checked one, return it
                    if (rb != null && rb.Checked)
                    {
                        return rb;
                    }
                }
            }
            //Else null
            return null;
        }

        //Exit quiz
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Load soundbytes
        private void QuizForm_Load(object sender, EventArgs e)
        {
            correctEffect = new SoundPlayer("right.wav");
            correctEffect.Load();
            wrongEffect = new SoundPlayer("wrong.wav");
            wrongEffect.Load();
            backgroundMusic = new SoundPlayer("hpMusic2.wav");
            backgroundMusic.Load();
        }
    }
}
