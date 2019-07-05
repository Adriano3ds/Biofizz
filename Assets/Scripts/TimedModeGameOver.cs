using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Biofizz
{
    namespace TimedMode
    {
        public class GameOver : Action
        {
            public IEnumerator ShowMessageAndGetNextTurn()
            {
                int i = 4;
                while (i >= 0)
                {
                    if (i > 0)
                    {
                        GameModeManager.gameOverCanvas.GetComponentInChildren<Text>().text =
                            "Fim de jogo! Próximo jogador, prepare-se! (Se houver)\n" + (i - 1);
                    }
                    else
                    {
                        StartUp.time = 16;
                        GameModeManager.gameOverCanvas.SetActive(false);
                        Quiz.GetNextTurn();
                        if (Quiz.ended)
                        {
                            GameModeManager.canvas.SetActive(false);
                            Leaderboard.SortByPoints();
                            GameModeManager.GameMode.ShowScoreAction.ExecuteAction();
                            Leaderboard.audio.clip = Resources.Load<AudioClip>("Sounds/win_sound");
                            Leaderboard.audio.Play();
                            Leaderboard.panel.SetActive(true);
                        }
                        else
                        {
                            QuestionsManager.LoadQuestions();
                            QuestionsManager.GetQuestion();
                            GameModeManager.paused = false;
                        }
                    }
                    i--;
                    yield return new WaitForSeconds(1f);
                }
            }

            public void ExecuteAction()
            {
                Quiz.sAudioSource.clip = Resources.Load<AudioClip>("Sounds/wrong_answer");
                Quiz.sAudioSource.Play();
                GameModeManager.paused = true;
                PlayerManager.CurrentPlayer.Finish();
                Leaderboard.AddToBoard(PlayerManager.CurrentPlayer);
                GameModeManager.gameOverCanvas.SetActive(true);
                GameModeManager.toExecute = ShowMessageAndGetNextTurn();
                PlayerManager.CurrentPlayer.Trigger();
            }

            public void ExecuteAction(Player player)
            {
                throw new System.NotImplementedException();
            }

            public void ExecuteAction(GameObject gameObject)
            {
                throw new System.NotImplementedException();
            }
        }
    }
}