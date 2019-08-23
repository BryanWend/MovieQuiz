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

namespace TriviaNow
{
    public delegate void AddNewQuestion(Question q);

    public partial class AddQuestion : Form
    {
        public event AddNewQuestion QuestionAdded;
        public event AddNewQuestion QuestionEdited;
        Question changeQuestion;
        string correctAnswer;

        public AddQuestion()
        {
            InitializeComponent();
            correctAnswerTextBox.Visible = false;
            correctAnswerTextBox.Text = "Placeholder";
            correctChoiceComboBox.Visible = true;

        }

        //Create overloaded constructor to take a question from the main form to view/edit it
        public AddQuestion(Question q)
        {
            InitializeComponent();

            //Take the paramater data and display it in the textboxes
            changeQuestion = q;
            addQuestionButton.Text = "&Edit";
            this.Text = "View Question";
            questionTextBox.Text = changeQuestion.QuestionText;
            answerOneTextBox.Text = changeQuestion.AnswerOne;
            answerTwoTextBox.Text = changeQuestion.AnswerTwo;
            answerThreeTextBox.Text = changeQuestion.AnswerThree;
            answerFourTextBox.Text = changeQuestion.AnswerFour;
            feedbackTextBox.Text = changeQuestion.Feedback;
            correctAnswerTextBox.Visible = true;
            correctChoiceComboBox.Visible = false;
            correctAnswerTextBox.Text = changeQuestion.CorrectAnswer;

            //Prevent user from making any changes while in view mode
            foreach(Control c in Controls)
            {
                if(c is TextBox)
                {
                    TextBox tmp = c as TextBox;

                    tmp.ReadOnly = true;
                    tmp.BackColor = Color.White;
                }
            }
        }

        //Load form, put values into comboBox
        private void AddQuestion_Load(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
            correctChoiceComboBox.Items.Add("Choice 1");
            correctChoiceComboBox.Items.Add("Choice 2");
            correctChoiceComboBox.Items.Add("Choice 3");
            correctChoiceComboBox.Items.Add("Choice 4");
        }

        private void addQuestionButton_Click(object sender, EventArgs e)
        {
            Question tmpQuestion;

            //Check if they are adding or viewing/editing
            if(addQuestionButton.Text == "&Add")
            {
                //Call method to verify fields are filled in
                if(areFieldsFilled() == false)
                {
                    errorLabel.Text = "Please fill in all the fields";
                    errorLabel.Visible = true;
                    return;
                }
                errorLabel.Visible = false;
                
                correctAnswer = CheckCorrectAnswer(correctChoiceComboBox.Text);

                //Create the question
                tmpQuestion = new Question(questionTextBox.Text, feedbackTextBox.Text,
                                            answerOneTextBox.Text, answerTwoTextBox.Text,
                                            answerThreeTextBox.Text, answerFourTextBox.Text,
                                            correctAnswer);

                //Call the event to pass the question to MainWindow
                QuestionAdded(tmpQuestion);

                //Loop through textboxes to clear them of text once question is added
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        TextBox tmpTextBox;
                        tmpTextBox = c as TextBox;

                        tmpTextBox.Clear();
                    }
                }
                //Finish resetting
                correctChoiceComboBox.Text = "";
                correctAnswerTextBox.Text = "Placeholder";

                questionTextBox.Focus();
            }            
            else if(addQuestionButton.Text == "&Edit")
            {
                addQuestionButton.Text = "&Save";
                correctChoiceComboBox.Visible = true;
                correctAnswerTextBox.Visible = false;

                //Loop through all controls
                foreach (Control c in Controls)
                {
                    //Make sure it is textbox
                    if (c is TextBox)
                    {
                        TextBox tmp = c as TextBox;

                        //Set them to read only
                        tmp.ReadOnly = false;
                        tmp.BackColor = Color.White;
                    }
                }

                questionTextBox.Focus();
            }
            else if(addQuestionButton.Text == "&Save")
            {
                //Verify all fields are filled in
                if (areFieldsFilled() == false)
                {
                    errorLabel.Text = "Please fill in all the fields";
                    errorLabel.Visible = true;
                    return;
                }
                errorLabel.Visible = false;

                //Find correct answer string text
                correctAnswer = CheckCorrectAnswer(correctChoiceComboBox.Text);

                //Construct the edited question
                tmpQuestion = new Question(questionTextBox.Text, feedbackTextBox.Text,
                            answerOneTextBox.Text, answerTwoTextBox.Text,
                            answerThreeTextBox.Text, answerFourTextBox.Text,
                            correctAnswer);

                //Pass to main form
                QuestionEdited(tmpQuestion);

                this.Close();
            }
        }

        //Check which answer is correct based on combobox choice
        private string CheckCorrectAnswer(string selected)
        {
            string answer = "";

            if (selected == "Choice 1")
                answer = answerOneTextBox.Text;
            else if (selected == "Choice 2")
                answer = answerTwoTextBox.Text;
            else if (selected == "Choice 3")
                answer = answerThreeTextBox.Text;
            else if (selected == "Choice 4")
                answer = answerFourTextBox.Text;

            return answer;
        }

        private bool areFieldsFilled()
        {
            bool isFilled;

            //Loop all controls and make sure they are not empty
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tmpTextBox;
                    tmpTextBox = c as TextBox;

                    //If empty, give error feedback through a label
                    if (tmpTextBox.Text == string.Empty)
                    {
                        isFilled = false;
                        return isFilled;
                    }
                }
                if (c is ComboBox)
                {
                    ComboBox tmpComboBox;
                    tmpComboBox = c as ComboBox;

                    if (tmpComboBox.SelectedItem == null)
                    {
                        isFilled = false;
                        return isFilled;
                    }
                }
            }
            isFilled = true;
            return isFilled;
        }

        //Exit form
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
