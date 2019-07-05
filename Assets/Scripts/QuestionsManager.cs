using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Biofizz;
using System.IO;

public static class QuestionsManager
{
    public static int previewIndex = 0;
    public static List<Question> questions = new List<Question>();
    public static Question currentQuestion = null;
    public static Text questionField;
    public static int questionStatus = 0;
    public static Button[] answerFields;
    public static string[] letters = new string[] { "A", "B", "C", "D" };
    public static Action gameOverAction;

    public static void LoadPreview()
    {
        LoadQuestions();
    }

    public static void PreviewNext()
    {
        previewIndex++;
        if (previewIndex > questions.Count - 1)
            previewIndex = 0;
        GetPreviewQuestion();
    }

    public static void PreviewPrevious()
    {
        previewIndex--;
        if (previewIndex < 0)
            previewIndex = questions.Count - 1;
        GetPreviewQuestion();
    }

    public static void GetPreviewQuestion()
    {
        Debug.Log("Questão: " + (previewIndex+1) );
        currentQuestion = questions[previewIndex];
        questionField.text = currentQuestion.GetQuestion();
        for (int i = 0; i < 4; i++)
        {
            ((Text)answerFields[i].GetComponentInChildren(typeof(Text))).text = currentQuestion.GetAnswers()[i];
            answerFields[i].GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Quiz/Resposta " + letters[i]);
            answerFields[i].GetComponentInChildren<Text>().color = Color.black;
        }
        answerFields[currentQuestion.GetCorrectAnswerID()].GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Quiz/Resposta " + letters[currentQuestion.GetCorrectAnswerID()] + "_C");
        answerFields[currentQuestion.GetCorrectAnswerID()].GetComponentInChildren<Text>().color = Color.white;
    }

    public static void LoadQuestions()
    {
        questions = new List<Question>();
        string path = "Assets/Resources/perguntas.tsv", line;
        StreamReader reader = new StreamReader(path);
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
    }

    public static void GetQuestion()
    {
        if (!Quiz.ended)
        {
            if (IsQuestionRead())
            {
                questions.Remove(currentQuestion);
                currentQuestion = null;
                questionStatus = 0;
            }
            if (questions.Count > 0)
            {
                currentQuestion = questions[Random.Range(0, questions.Count)];
                questionField.text = currentQuestion.GetQuestion();
                for (int i = 0; i < 4; i++)
                {
                    ((Text)answerFields[i].GetComponentInChildren(typeof(Text))).text = currentQuestion.GetAnswers()[i];
                    answerFields[i].GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Quiz/Resposta " + letters[i]);
                    answerFields[i].GetComponentInChildren<Text>().color = Color.black;
                }
               // GameModeManager.paused = false;
            }
            else
            {
                gameOverAction.ExecuteAction();
            }
        }
    }

    public static bool IsQuestionRead()
    {
        return currentQuestion != null;
    }
}
