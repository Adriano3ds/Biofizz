using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biofizz_Editor_de_Perguntas
{
    public partial class Form1 : Form
    {
        bool changed = false;
        int currentQuestion = 0;
        string filename = "Sem Título";
        List<Question> questions = new List<Question>() { new Question("", new List<string>(){"", "", "", ""}, 1) };
        TextBox[] answersBoxes;
        RadioButton[] dificulties, answersRadios;

        public Form1()
        {
            InitializeComponent();
            answersBoxes = new TextBox[] { answerATextBox, answerBTextBox, answerCTextBox, answerDTextBox };
            dificulties = new RadioButton[] { easyRadioButton, mediumRadioButton, hardRadioButton };
            answersRadios = new RadioButton[] { radioCorrectAnswerA, radioCorrectAnswerB, radioCorrectAnswerC, radioCorrectAnswerD };
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (questionTextBox.Text != "" || answerATextBox.Text != "" || answerBTextBox.Text != "" || answerCTextBox.Text != "" || answerDTextBox.Text != "" || questionTextBox.Text != questions[currentQuestion].GetQuestion || answerATextBox.Text != questions[currentQuestion].GetAnswers[0] || answerBTextBox.Text != questions[currentQuestion].GetAnswers[1] || answerCTextBox.Text != questions[currentQuestion].GetAnswers[2] || answerDTextBox.Text != questions[currentQuestion].GetAnswers[3])
            {
                nextButton.Enabled = true;
                changed = true;
            }
            else
            {
                nextButton.Enabled = false;
                changed = false;
            }
            Text = "Editor de Perguntas Biofizz - " + (changed?"*":"") + filename;
            ((TextBox)sender).Text = ((TextBox)sender).Text.Replace("\n", "");
            ((TextBox)sender).Text = ((TextBox)sender).Text.Replace("\r", "");
            ((TextBox)sender).Text = ((TextBox)sender).Text.Replace("\t", "");
        }

        private void AbrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string line;
            StreamReader reader = new StreamReader(openFileDialog1.FileName);
            filename = openFileDialog1.SafeFileName;
            questions = new List<Question>();
            while ((line = reader.ReadLine()) != null)
            {
                List<string> ls = new List<string>(line.Split('\t'));
                string question = ls[0];
                ls.RemoveAt(0);
                int dif = int.Parse(ls[4]);
                ls.RemoveAt(4);
                Question q = new Question(question, ls, dif);
                questions.Add(q);
            }
            currentQuestion = 0;
            for (int i = 0; i < 4; i++)
            {
                answersBoxes[i].Text = questions[currentQuestion].GetAnswers[i];
            }
            answersRadios[questions[currentQuestion].GetCorrectAnswerID].Select();
            dificulties[questions[currentQuestion].GetDifficulty() - 1].Select();
            questionTextBox.Text = questions[currentQuestion].GetQuestion;
            questionsCounterToolStripStatusLabel.Text = questions.Count.ToString();
            changed = false;
            Text = "Editor de Perguntas Biofizz - " + filename.Substring(0, filename.Length - 4);
        }

        private void updateQuestionFields()
        {
            for (int i = 0; i < 4; i++)
            {
                answersBoxes[i].Text = questions[currentQuestion].GetAnswers[i];
            }
            answersRadios[questions[currentQuestion].GetCorrectAnswerID].Select();
            dificulties[questions[currentQuestion].GetDifficulty() - 1].Select();
            questionTextBox.Text = questions[currentQuestion].GetQuestion;
            changed = false;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if(currentQuestion < questions.Count - 1)
            {
                prevButton.Enabled = true;
                currentQuestion++;
                updateQuestionFields();
            }
            else
            {
                nextButton.Enabled = false;
            }
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            if (currentQuestion > 0)
            {
                nextButton.Enabled = true;
                currentQuestion--;
                updateQuestionFields();
            }
            else
            {
                prevButton.Enabled = false;
            }
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (changed)
            {

            }
        }

        private void salvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (changed)
            {
                saveFileDialog1.ShowDialog();
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void DifficultyRadioClicked(object sender, EventArgs e)
        {
            int.Parse(((RadioButton)sender).Tag.ToString());
        }
    }
}
