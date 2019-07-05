
using System;
using System.Collections.Generic;

namespace Biofizz
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
            answers = Shuffle(answers);
            _correctAnswerId = answers.IndexOf(_correctAnswer);
            _answers = answers;
            _difficulty = difficulty;
        }

        public string GetQuestion()
        {
            return _question;
        }

        public List<string> GetAnswers()
        {
            return _answers;
        }

        public int GetCorrectAnswerID()
        {
            return _correctAnswerId;
        }

        public int GetDifficulty()
        {
            return _difficulty;
        }

        private static Random rng = new Random();

        private List<string> Shuffle(List<string> q)
        {
            List<string> l = new List<string>();
            int i = q.Count;
            while (i > 0)
            {
                int k = rng.Next(--i);
                l.Add(q[k]);
                q.Remove(q[k]);
            }
            return l;
        }

        private void Shuffle<T>(IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
