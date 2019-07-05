using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Biofizz;
using System.IO;

public class Quiz : MonoBehaviour
{
    //Adicionar créditos das músicas: by Mativve from freesound.org 
    // by rhodesmas from freesound.org
    // by FunWithSound from freesound.org
    public GameObject quizCanvas, leaderboard, gameOver;
    public Camera camera;
    public Text questionField, turnField, timeField;
    public static Coroutine currentCoroutine, currentCoroutine2;
    public Button answerA, answerB, answerC, answerD;
    private Action gameOverAction, correctAnswerAction, wrongAnswerAction, showScoreAction, startUpAction;
    static int turn = 0;
    private Button[] answerFields;
    AudioSource audiosource;
    public static AudioSource sAudioSource;
    bool waitingClickToNextQuestion = false;
    public static bool ended = false;

    // Start is called before the first frame update
    void Start()
    {
        GameModeManager.canvas = quizCanvas;
        Leaderboard.panel = leaderboard;
        GameModeManager.gameOverCanvas = gameOver;
        GameModeManager.camera = camera;
        answerFields = new Button[]{ answerA, answerB, answerC, answerD };
        QuestionsManager.answerFields = answerFields;
        QuestionsManager.questionField = questionField;
        correctAnswerAction = GameModeManager.GameMode.CorrectAnswerAction;
        showScoreAction = GameModeManager.GameMode.ShowScoreAction;
        wrongAnswerAction = GameModeManager.GameMode.WrongAnswerAction;
        startUpAction = GameModeManager.GameMode.StartUpAction;
        gameOverAction = GameModeManager.GameMode.GameOverAction;
        QuestionsManager.gameOverAction = gameOverAction;
        QuestionsManager.LoadQuestions();
        QuestionsManager.GetQuestion();
        audiosource = camera.GetComponent<AudioSource>();
        sAudioSource = audiosource;
        Leaderboard.audio = audiosource;
        PlayerManager.SetCurrentPlayer(PlayerManager.GetPlayers[0]);
        PlayerManager.AddGameObjects();
        PlayerManager.CurrentPlayer.Focus();
        turnField.text = "Turno: " + PlayerManager.CurrentPlayer.Name;
        startUpAction.ExecuteAction(quizCanvas);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }

    public void SendAnswer(int option)
    {
        if (QuestionsManager.IsQuestionRead())
        {
            if (!ended)
            {
                if (!waitingClickToNextQuestion)
                {
                    if (option == QuestionsManager.currentQuestion.GetCorrectAnswerID())
                    {
                        answerFields[option].GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Quiz/Resposta " + QuestionsManager.letters[option] + "_C");
                        answerFields[option].GetComponentInChildren<Text>().color = Color.white;
                        audiosource.clip = Resources.Load<AudioClip>("Sounds/correct_answer");
                        audiosource.Play();
                        QuestionsManager.questionStatus = 1;
                    }
                    else
                    {
                        answerFields[option].GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Quiz/Resposta " + QuestionsManager.letters[option] + "_E");
                        answerFields[option].GetComponentInChildren<Text>().color = Color.white;
                        answerFields[QuestionsManager.currentQuestion.GetCorrectAnswerID()].GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Quiz/Resposta " + QuestionsManager.letters[QuestionsManager.currentQuestion.GetCorrectAnswerID()] + "_C");
                        answerFields[QuestionsManager.currentQuestion.GetCorrectAnswerID()].GetComponentInChildren<Text>().color = Color.white;
                        audiosource.clip = Resources.Load<AudioClip>("Sounds/wrong_answer");
                        audiosource.Play();
                        QuestionsManager.questionStatus = 2;
                    }
                    if (GameModeManager.GameMode.GMType == GameModeType.TIMEDMODE)
                    {
                        GameModeManager.paused = true;
                    }
                    waitingClickToNextQuestion = true;
                }
                else
                {
                    if (GameModeManager.GameMode.GMType == GameModeType.TIMEDMODE)
                    {
                        StopCoroutine(currentCoroutine);
                        if (currentCoroutine2 != null)
                        {
                            StopCoroutine(currentCoroutine2);
                            currentCoroutine2 = null;
                        }
                    }
                    if (QuestionsManager.questionStatus == 1)
                    {
                        correctAnswerAction.ExecuteAction(PlayerManager.CurrentPlayer);
                    }
                    else if (QuestionsManager.questionStatus == 2)
                    {
                        wrongAnswerAction.ExecuteAction(PlayerManager.CurrentPlayer);
                    }
                    turnField.text = "Turno: " + PlayerManager.CurrentPlayer.Name;
                    //QuestionsManager.GetQuestion();
                    waitingClickToNextQuestion = false;
                }
            }
        }
    }

    public static void GetNextTurn()
    {
        turn++;
        if (turn >= PlayerManager.GetPlayers.Length)
            turn = 0;
        int counter = 0;
        while (GameModeManager.GameMode.HasMaxPoints(PlayerManager.GetPlayers[turn]) || PlayerManager.GetPlayers[turn].Done)
        {
            counter++;
            turn++;
            if (turn >= PlayerManager.GetPlayers.Length)
                turn = 0;
            if(counter>= PlayerManager.GetPlayers.Length) {
                ended = true;
                break;
            }
        }
        PlayerManager.SetCurrentPlayer(PlayerManager.GetPlayers[turn]);
        GameModeManager.canvas.GetComponentsInChildren<Text>()[1].text = "Turno: " + PlayerManager.CurrentPlayer.Name;
    }

}
