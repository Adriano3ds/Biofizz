using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biofizz_Editor_de_Perguntas
{
    public class Question
    {
        private string _question;
        private List<string> _answers;
        private int _correctAnswerId;
        private string _correctAnswer;
        private int _difficulty;
        public Question(string question, List<string> answers, int difficulty)
        {
            _question = question;
            _correctAnswer = answers[0];
            _correctAnswerId = answers.IndexOf(_correctAnswer);
            _answers = answers;
            _difficulty = difficulty;
        }

        public string GetQuestion
        {
            get => _question;
            set => _question = value;
        }

        public List<string> GetAnswers
        {
            get => _answers;
            set => _answers = value;
        }

        public int GetCorrectAnswerID
        {
            get => _correctAnswerId;
            set => _correctAnswerId = value;
        }

        public int GetDifficulty()
        {
            return _difficulty;
        }
    }
}
