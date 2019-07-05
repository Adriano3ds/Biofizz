using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Biofizz
{
    namespace TimedMode
    {
        public class StartUp : Action
        {
            public static GameObject canvas;
            public static int time = 4;
            static bool firstInit = true;

            public IEnumerator Tick()
            {
                while (!Quiz.ended)
                {
                    if (!GameModeManager.paused)
                    {
                        if (firstInit)
                        {
                            if (time > 0)
                            {
                                GameModeManager.canvas.SetActive(false);
                                GameModeManager.gameOverCanvas.GetComponentInChildren<Text>().text =
                                "Prepare-se!\n" + (time - 1);
                                GameModeManager.gameOverCanvas.SetActive(true);
                                time--;
                            }
                            else
                            {
                                GameModeManager.canvas.SetActive(true); ;
                                GameModeManager.gameOverCanvas.SetActive(false);
                                time = 16;
                                firstInit = false;
                            }
                        }
                        if(!firstInit)
                        {
                            if (time > 0)
                            {
                                time--;
                                canvas.GetComponentInChildren<Text>().text = time.ToString();
                            }
                            else
                            {
                                GameModeManager.GameMode.GameOverAction.ExecuteAction();
                            }
                        }
                        yield return new WaitForSeconds(1f);
                    }
                    else
                    {
                        yield return new WaitForSeconds(0.05f);
                    }
                }
            }

            public void ExecuteAction()
            {
                throw new System.NotImplementedException();
            }

            public void ExecuteAction(Player player)
            {
                throw new System.NotImplementedException();
            }

            public void ExecuteAction(GameObject gameObject)
            {
                canvas = gameObject;
                GameModeManager.toExecute = Tick();
                PlayerManager.CurrentPlayer.Trigger();
            }
        }
    }

}