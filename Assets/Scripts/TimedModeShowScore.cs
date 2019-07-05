using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Biofizz
{
    namespace TimedMode
    {
        public class ShowScore : Action
        {
            public void ExecuteAction()
            {
                for (int i = 0; i < PlayerManager.GetPlayers.Length; i++)
                {
                    Leaderboard.AddToBoard(PlayerManager.GetPlayers[i]);
                }
                Leaderboard.SortByPoints();
                Leaderboard.panel.GetComponentInChildren<Text>().text = "Colocação:\n\n";
                for (int i = 0; i < Leaderboard.Board.Count; i++)
                {
                    Leaderboard.panel.GetComponentInChildren<Text>().text += i + 1 + "º) " + Leaderboard.Board[i].Name + ": " + Leaderboard.Board[i].Score + " Ponto(s)\n";
                }
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