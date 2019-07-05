using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Biofizz
{
    namespace RaceMode
    {
        public class CorrectAnswer : Action
        {
            bool moving = false;
            float y = 1, t = 0;
            Vector3 oldpos;
            public static Player player;

            public IEnumerator MovePlayer()
            {
                while(moving)
                {
                    if (t <= 1.0f)
                    {
                        Vector3 pos = player.Transform.position, cpos = GameModeManager.camera.transform.position;
                        if(oldpos.y + y >= 4.37)
                        {
                            y = 4.37f - oldpos.y;
                        }
                        player.Transform.position = Vector3.Lerp(oldpos, oldpos + new Vector3(0, y, 0), t);
                        Debug.Log("Player.y :" + player.Transform.position.y + " - t: " + t);
                        if (GameModeManager.camera.transform.position.y <= 0.6 && GameModeManager.camera.transform.position.y >= -15)
                        {
                            if (!(player.Transform.position.y - pos.y < 0 && GameModeManager.camera.transform.position.y == -15) && !(player.Transform.position.y - pos.y > 0.6 && GameModeManager.camera.transform.position.y == 0))
                                GameModeManager.camera.transform.position = cpos + new Vector3(0, player.Transform.position.y - pos.y);
                        }
                        t += 0.05f;
                        t = (float)Math.Round(t * 100f) / 100f;
                    }
                    else
                    {
                        moving = false;
                        t = 0;
                        QuestionsManager.GetQuestion();
                        //player.Transform.position = oldpos + new Vector3(0, y, 0);
                        if (Leaderboard.Board.Count == PlayerManager.GetPlayers.Length - 1)
                        {
                            PlayerManager.CurrentPlayer.Finish();
                            Leaderboard.AddToBoard(PlayerManager.CurrentPlayer);
                            Quiz.GetNextTurn();
                        }
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
                y = 1.8f * QuestionsManager.currentQuestion.GetDifficulty();
                player.AddScore(y);
                if (GameModeManager.GameMode.HasMaxPoints(player))
                {
                    player.Finish();
                    Leaderboard.AddToBoard(player);
                }
                t = 0;
                CorrectAnswer.player = player;
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