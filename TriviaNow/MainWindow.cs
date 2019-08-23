//Project, Bryan Wendlandt, CIS 345 12-115
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace TriviaNow
{
    [Serializable]
    public partial class MainWindow : Form
    {
        //Main form buttons to create through code
        Button playButton;
        Button viewButton;
        Button mainSaveButton;
        Button mainOpenButton;
        Button mainExitButton;

        //Declare two forms, one for adding, one for viewing/editing
        AddQuestion addQuestionForm;
        AddQuestion editQuestionForm;

        //Declare quiz form
        QuizForm quizForm;

        //Delcare var for File/IO function
        SaveFileDialog saveFileDialog;
        OpenFileDialog openFileDialog;
        DialogResult dialogResult;

        BindingList<Question> questionList;
        BindingList<Question> searchedList;
        BindingList<Question> quizQuestionList;
        BindingList<int> repeatingQuestions;

        SoundPlayer backgroundMusic;

        int editedQuestionIndex;
        int deletedQuestionIndex;
        Random r;

        public MainWindow()
        {
            InitializeComponent();

        }

        private void mainWindow_Load(object sender, EventArgs e)
        {
            //Instantiate list and bind it to listbox
            questionList = new BindingList<Question>();
            repeatingQuestions = new BindingList<int>();
            LoadSampleData();
            questionListBox.DataSource = questionList;

            backgroundMusic = new SoundPlayer("hpMusic2.wav");
            backgroundMusic.Load();
            backgroundMusic.PlayLooping();

            //Create the four buttons and set their properties for the 
            //Main Menu: Play, View, Save, Load
            #region
            //Create Play Button
            playButton = new Button();
            playButton.Font = new Font("Microsoft Sans Serif", 40F, FontStyle.Regular);
            playButton.Location = new Point(150, 150);
            playButton.Size = new Size(400, 100);
            playButton.Text = "&Play Quiz";
            //Wire it
            Controls.Add(playButton);
            playButton.Click += new EventHandler(playButton_Click);

            //Create a View Question Button on form for Main Menu
            viewButton = new Button();
            viewButton.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular);
            viewButton.Location = new Point(200, 275);
            viewButton.Size = new Size(300, 75);
            viewButton.Text = "&View Questions";
            //Wire it to show a listbox with options to alter
            Controls.Add(viewButton);
            viewButton.Click += new EventHandler(viewButton_Click);

            //Create a Save Button on Main Menu
            mainSaveButton = new Button();
            mainSaveButton.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular);
            mainSaveButton.Location = new Point(200, 350);
            mainSaveButton.Size = new Size(150, 50);
            mainSaveButton.Text = "&Save";
            //Wire it
            Controls.Add(mainSaveButton);
            mainSaveButton.Click += new EventHandler(mainSaveButton_Click);

            //Create an Open Button on Main Menu
            mainOpenButton = new Button();
            mainOpenButton.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular);
            mainOpenButton.Location = new Point(350, 350);
            mainOpenButton.Size = new Size(150, 50);
            mainOpenButton.Text = "&Open";
            //Wire it
            Controls.Add(mainOpenButton);
            mainOpenButton.Click += new EventHandler(mainOpenButton_Click);

            //Button to quit program
            mainExitButton = new Button();
            mainExitButton.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular);
            mainExitButton.Location = new Point(275, 400);
            mainExitButton.Size = new Size(150, 50);
            mainExitButton.Text = "E&xit";
            //Wire it
            Controls.Add(mainExitButton);
            mainExitButton.Click += new EventHandler(mainExitButton_Click);
            #endregion

            //Hide the secondary, viewMenu, by default
            DefaultMainMenu();

            //Wire duplicate menu options for easy access options
            editToolStripMenuItem.Click += new EventHandler(viewButton_Click);
            exitToolStripMenuItem.Click += new EventHandler(mainExitButton_Click);
            saveToolStripMenuItem.Click += new EventHandler(mainSaveButton_Click);
            openToolStripMenuItem.Click += new EventHandler(mainOpenButton_Click);
            questionListBox.DoubleClick += new EventHandler(detailsButton_Click);
            editButton.Click += new EventHandler(detailsButton_Click);           
            playToolStripMenuItem.Click += new EventHandler(playButton_Click);

        }

        //Show buttons to view/make changes to questions
        private void viewButton_Click(Object sender, EventArgs e)
        {
            questionListBox.Visible = true;
            addButton.Visible = true;
            editButton.Visible = true;
            deleteButton.Visible = true;
            cancelButton.Visible = true;
            viewSaveButton.Visible = true;
            detailsButton.Visible = true;
            questionDLabel.Visible = true;
            searchTextBox.Visible = true;
            searchButton.Visible = true;
            searchTextBox.Text = "Enter Text You Would Like to Search for Here";

            playButton.Visible = false;
            viewButton.Visible = false;
            mainSaveButton.Visible = false;
            mainOpenButton.Visible = false;
            mainExitButton.Visible = false;

        }

        //Open up the add question form
        private void addButton_Click(object sender, EventArgs e)
        {
            //Make sure a form is not already open
            if(addQuestionForm == null || addQuestionForm.IsDisposed)
            {
                //Instantiate and wire a new add question form
                addQuestionForm = new AddQuestion();
                addQuestionForm.QuestionAdded +=
                    new AddNewQuestion(AddQuestion_QuestionAdded);
                addQuestionForm.Show();
            }
        }

        //Return to Main Default menu window
        private void cancelButton_Click(object sender, EventArgs e)
        {
            DefaultMainMenu();
        }

        //Exit all windows
        private void mainExitButton_Click(object sender, EventArgs e)
        {
            SaveOnQuit();
        }

        //Reset buttons
        private void DefaultMainMenu()
        {
            //Maybe create a secondary list for each set of form controls so I can 
            //loop through the lists instead of typing?
            questionListBox.Visible = false;
            addButton.Visible = false;
            editButton.Visible = false;
            deleteButton.Visible = false;
            cancelButton.Visible = false;
            viewSaveButton.Visible = false;
            detailsButton.Visible = false;
            questionDLabel.Visible = false;
            searchTextBox.Visible = false;
            searchButton.Visible = false;

            playButton.Visible = true;
            viewButton.Visible = true;
            mainSaveButton.Visible = true;
            mainOpenButton.Visible = true;
            mainExitButton.Visible = true;
        }

        //Add the question to the listbox and update the datasource with paramater from AddQuestion form
        private void AddQuestion_QuestionAdded(Question q)
        {
            questionList.Add(q);
            questionListBox.DataSource = questionList;
        }

        //If editing, replaced the question at the same index with the edited version
        private void AddQuestion_QuestionEdited(Question q)
        {
            questionList[editedQuestionIndex] = q;
        }

        //Create eventhandler to save questions
        private void mainSaveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "App Data Files (*.dat)|*.dat|All Files (*.*)|*.*";
            dialogResult = saveFileDialog.ShowDialog();

            if(dialogResult == DialogResult.OK)
            {
                //Open stream
                FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();

                //Serialize data to file
                bf.Serialize(fs, questionList);

                //Close stream
                fs.Close();
            }
        }

        //Create eventhandler to open questions
        private void mainOpenButton_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "App Data Files (*.dat)|*.dat|All Files (*.*)|*.*";
            dialogResult = openFileDialog.ShowDialog();

            if(dialogResult == DialogResult.OK)
            {
                //Make sure the file type is correct and won't crash the program
                try
                {
                    //Open Stream
                    FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read);
                    BinaryFormatter bf = new BinaryFormatter();

                    //Deserialize and downcast
                    questionList = (BindingList<Question>)bf.Deserialize(fs);
                    //Update datasource
                    questionListBox.DataSource = questionList;

                    //Close stream
                    fs.Close();

                    errorLabel.Visible = false;
                }
                //Catch any exception to prevent crashing and give and error msg
                catch (Exception)
                {
                    errorLabel.Visible = true;
                    errorLabel.Text = "Please select a file of the correct type in order to open";
                }
            }

        }

        //Handler to open a view question data form
        private void detailsButton_Click(object sender, EventArgs e)
        {
            Question tmpQuestion;

            //Make sure an object is selected and there is no form already open
            if(questionListBox.SelectedItem != null)
            {
                if(editQuestionForm == null || editQuestionForm.IsDisposed)
                {
                    //Downcast to a Question type
                    tmpQuestion = questionListBox.SelectedItem as Question;
                    editedQuestionIndex = questionList.IndexOf(tmpQuestion);
                    
                    //Pass a question to AddQuestion form constructor
                    editQuestionForm = new AddQuestion(tmpQuestion);
                    editQuestionForm.QuestionEdited +=
                        new AddNewQuestion(AddQuestion_QuestionEdited);
                    editQuestionForm.Show();
                }


            }
        }

        //Create temp test data
        private void LoadSampleData()
        {
            questionList.Add(new Question("Who is the ghost of Gryffindor Tower?", "Sir Nicholas de Mimsy-Porpington, also known as Nearly Headless Nick, is the ghost of Gryffindor Tower!", "Fat Friar", "Bloody Baron", "Grey lady", "Sir Nicholas", "Sir Nicholas"));
            questionList.Add(new Question("What is the name of the dog guarding the Sorcerer’s Stone?", "Hagrid's three-headed dog Fluffy guards the stone. Who's a good boy? He is!", "Fang", "Fluffy", "Padfoot", "The Grim","Fluffy"));
            questionList.Add(new Question("What kind of monster awaited Harry and Ron in the Forbidden Forest?", "Why spiders? Why couldn't it be 'follow the butterflies?'", "Troll", "Giant Spider", "Basilisk", "Giant Snake", "Giant Spider"));
            questionList.Add(new Question("Which item freed Dobby the House Elf from Lucius Malfoy?", "At least somebody would be happy with socks for Christmas!", "Underwear", "Cool Hat with Holes for His Ears", "Napkin", "Sock", "Sock"));
            questionList.Add(new Question("Who was the Half-Blood Prince?", "Severus Snape?? What a plot twist, eh?", "Harry Potter", "Ron Weasley", "Severus Snape", "Lord Voldemort", "Severus Snape"));
            questionList.Add(new Question("Which team was playing in the Quidditch World Cup before disaster soon followed?", "One of the few times Ireland is in a World Cup of any kind!", "Ireland", "England", "Germany", "France","Ireland"));
            questionList.Add(new Question("How many kids do the Weasleys' have?", "I think it's 4...no 5...wait, 7 of course!", "4", "2", "9", "7", "7"));
            questionList.Add(new Question("How did Harry and Ron get to Hogwarts their second year?", "HEY! I think that guy just cut me off! Wait, are there even lanes in the sky?", "Uber", "Ron's mom dropped them off", "Flying Car", "Broomsticks","Flying Car"));
            questionList.Add(new Question("What newspaper did the wizarding world read?", "EXTRA, EXTRA, READ ALL ABOUT IT IN THE DAILY PROPHET!!!", "Daily Prophet", "New York Times", "The Telegraph", "Wall Street Journal", "Daily Prophet"));
            questionList.Add(new Question("What is Severus Snape's patronus?", "I sure hope this doesn't end like Bambi", "Snake", "Doe", "Bear", "Dragon","Doe"));
        }



        //Eventhandlers for Final Project
        private void deleteButton_Click(object sender, EventArgs e)
        {
            Question tmpQuestion;

            //Make sure an item is selected
            if(questionListBox.SelectedItem != null)
            {
                //Downcast listbox item
                tmpQuestion = questionListBox.SelectedItem as Question;
                //Find the of the selected item in the list
                deletedQuestionIndex = questionList.IndexOf(tmpQuestion);
                //Remove the question at that position
                questionList.RemoveAt(deletedQuestionIndex);
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if(questionList.Count > 0)
            {
                quizQuestionList = new BindingList<Question>();

                quizQuestionList = GenerateRandomQuestions(questionList);

                //Create new quiz form
                quizForm = new QuizForm(quizQuestionList);
                quizForm.Show();
            }
        }


        //Clear the text in the search box so the user can type in it
        private void searchTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if(searchTextBox.Text == "Enter Text You Would Like to Search for Here")
                searchTextBox.Text = "";
        }

        //Search functionality
        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchedTerm;
            searchedList = new BindingList<Question>();
            searchedTerm = searchTextBox.Text;

            //If the searchTerm is null, then reset the listbox to show all questions
            if(searchedTerm == null)
            {
                questionListBox.DataSource = questionList;
            }
            else
            {
                //Search the list and see if any questionText matches
                foreach (Question q in questionList)
                {
                    //If it matches, add to a temporary list
                    if (q.QuestionText.ToLower().Contains(searchedTerm.ToLower()))
                        searchedList.Add(q);
                }
                //Set the temporary list as the new datasource
                questionListBox.DataSource = searchedList;
            }
        }

        //Allow you to press enter key to search
        private void searchTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                searchButton.PerformClick();
            }
        }

        //Method to pick 3 random questions
        private BindingList<Question> GenerateRandomQuestions(BindingList<Question> questions)
        {
            int index;
            int questionLimit = 3;
            BindingList<Question> quizQuestionList = new BindingList<Question>();
            r = new Random();

            //Make sure to reset list counter so 3 questions are always able to be asked
            if ((questionList.Count - repeatingQuestions.Count) < 3)
            {
                repeatingQuestions.Clear();
            }

            //Make sure it is only 3
            while (quizQuestionList.Count != questionLimit)
            {
                //Find a random position
                index = r.Next(0, questions.Count);
                //Make sure it is not already on the list
                if (quizQuestionList.Contains(questions[index]) == false && repeatingQuestions.Contains(index) == false)
                {
                    //Add it
                    quizQuestionList.Add(questions[index]);
                    //Add question index to a list to make sure there are no repeats for different quizzes until questions run out
                    repeatingQuestions.Add(index);
                }
                else
                {

                }
            }

            return quizQuestionList;
        }

        //Ask to save before exiting
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveOnQuit();
        }

        //Messagebox display
        private void SaveOnQuit()
        {
            //Prompt user before quitting
            DialogResult dg = MessageBox.Show("Would you like to save before quitting?", "Exiting", MessageBoxButtons.YesNo);

            //If yes, call a save event           
            if (dg == DialogResult.Yes)
            {
                mainSaveButton.PerformClick();
                Environment.Exit(0);
            }
            //Else quit
            else if (dg == DialogResult.No)
            {
                System.Environment.Exit(0);
            }
        }
    }
}
