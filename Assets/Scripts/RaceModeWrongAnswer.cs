using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Biofizz
{
    namespace RaceMode
    {
        public class WrongAnswer : Action
        {
            bool moving = false;
            float y = 1, t = 0;
            Vector3 oldpos;
            public static Player player;

            public IEnumerator MovePlayer()
            {
                while (moving)
                {
                    if (t <= 1)
                    {
                        if (player.Transform.position.y > -16.15f)
                        {
                            if (oldpos.y + y <= -16.15f)
                            {
                                y = -16.15f - oldpos.y;
                            }
                            Vector3 pos = player.Transform.position, cpos = GameModeManager.camera.transform.position;
                            player.Transform.position = Vector3.Lerp(oldpos, oldpos + new Vector3(0, y, 0), t);
                            if (GameModeManager.camera.transform.position.y <= 0.6 && GameModeManager.camera.transform.position.y >= -15)
                            {
                                if (!(player.Transform.position.y - pos.y < 0 && GameModeManager.camera.transform.position.y == -15) && !(player.Transform.position.y - pos.y > 0.6 && GameModeManager.camera.transform.position.y == 0))
                                    GameModeManager.camera.transform.position = cpos + new Vector3(0, player.Transform.position.y - pos.y);
                            }
                        }
                        t += 0.05f;
                        t = (float)Math.Round(t * 100f) / 100f;
                    }
                    else
                    {
                        moving = false;
                        t = 0;
                        QuestionsManager.GetQuestion();
                        if (!Quiz.ended)
                        {
                            GameModeManager.canvas.SetActive(true);
                        }
                        else
                        {
                            GameModeManager.GameMode.ShowScoreAction.ExecuteAction();
                            Leaderboard.audio.clip = Resources.Load<AudioClip>("Sounds/win_sound");
                            Leaderboard.audio.Play();
                            Leaderboard.panel.SetActive(true);
                        }
                    }
                    yield return new WaitForSeconds(.05f);
                }
            }

            public void ExecuteAction(Player player)
            {
                GameModeManager.canvas.SetActive(false);
                moving = true;
                y = (-1.8f) * (4 - QuestionsManager.currentQuestion.GetDifficulty());
                WrongAnswer.player = player;
                if (player.Score > 0)
                {
                    player.AddScore(y);
                }
                player.Focus();
                oldpos = player.Transform.position;
                player.Trigger();
                GameModeManager.toExecute = MovePlayer();
                Quiz.GetNextTurn();
            }

            public void ExecuteAction()
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