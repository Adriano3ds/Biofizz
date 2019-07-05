using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PreviewManager : MonoBehaviour
{
    public Text questionField;
    public Button A, B, C, D;
    void Start()
    {
        QuestionsManager.questionField = questionField;
        QuestionsManager.answerFields = new Button[] { A, B, C, D };
        QuestionsManager.LoadPreview();
        QuestionsManager.GetPreviewQuestion();
    }

    void Update()
    {
        
    }

    public void Next()
    {
        QuestionsManager.PreviewNext();
    }

    public void Previous()
    {
        QuestionsManager.PreviewPrevious();
    }
}
