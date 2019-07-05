using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Biofizz
{
    namespace RaceMode
    {
        public class GameOver : Action
        {
            public IEnumerator ShowMessageAndScore()
            {
                int i = 4;
                while (i>=0)
                {
                    if (i > 0)
                    {
                        GameModeManager.gameOverCanvas.GetComponentInChildren<Text>().text = 
                            "Ah não! As perguntas acabaram!\nOs resultados serão mostrados em:\n" + (i - 1);
                    }
                    else
                    {
                        GameModeManager.gameOverCanvas.SetActive(false);
                        GameModeManager.canvas.SetActive(false);
                        Leaderboard.SortByPoints();
                        GameModeManager.GameMode.ShowScoreAction.ExecuteAction();
                        Leaderboard.audio.clip = Resources.Load<AudioClip>("Sounds/win_sound");
                        Leaderboard.audio.Play();
                        Leaderboard.panel.SetActive(true);
                    }
                    i--;
                    yield return new WaitForSeconds(1f);
                }
            }

            public void ExecuteAction()
            {
                GameModeManager.gameOverCanvas.SetActive(true);
                GameModeManager.toExecute = ShowMessageAndScore();
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