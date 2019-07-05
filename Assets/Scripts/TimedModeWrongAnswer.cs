using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Biofizz
{
    namespace TimedMode
    {
        public class WrongAnswer : Action
        {
            IEnumerator old;
            Coroutine coroutine;

            public IEnumerator ShowMessageAndGetNextTurn()
            {
                GameModeManager.toExecute2 = null;
                int i = 4;
                while (i >= 0)
                {
                    if (i > 0)
                    {
                        GameModeManager.canvas.SetActive(false);
                        GameModeManager.gameOverCanvas.GetComponentInChildren<Text>().text =
                            "Fim de jogo! Próximo jogador, prepare-se! (Se houver)\n" + (i - 1);
                        GameModeManager.gameOverCanvas.SetActive(true);
                    }
                    else
                    {
                        StartUp.time = 16;
                        GameModeManager.gameOverCanvas.SetActive(false);
                        GameModeManager.canvas.SetActive(true);
                        GameModeManager.paused = false;
                    }
                    i--;
                    yield return new WaitForSeconds(1f);
                }
            }

            public void ExecuteAction()
            {
                throw new System.NotImplementedException();
            }

            public void ExecuteAction(Player player)
            {
                StartUp.time = 16;
                player.Finish();
                Leaderboard.AddToBoard(player);
                QuestionsManager.LoadQuestions();
                QuestionsManager.GetQuestion();
                Quiz.GetNextTurn();
                if (Quiz.ended)
                {
                    GameModeManager.GameMode.ShowScoreAction.ExecuteAction();
                    Leaderboard.audio.clip = Resources.Load<AudioClip>("Sounds/win_sound");
                    Leaderboard.audio.Play();
                    Leaderboard.panel.SetActive(true);
                }
                else
                {
                    GameModeManager.toExecute2 = ShowMessageAndGetNextTurn();
                    PlayerManager.CurrentPlayer.Trigger();
                    //PlayerManager.CurrentPlayer.Trigger();
                    //GameModeManager.paused = false;
                }
            }

            public void ExecuteAction(GameObject gameObject)
            {
                throw new System.NotImplementedException();
            }
        }
    }

}