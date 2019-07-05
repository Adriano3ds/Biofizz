using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Biofizz
{
    public static class Leaderboard
    {
        private static List<Player> _board = new List<Player>();
        public static AudioSource audio;
        public static GameObject panel;

        public static List<Player> Board
        {
            get => _board;
        }

        public static void AddToBoard(Player p)
        {
            bool cont = false;
            for(int i = 0; i<_board.Count; i++)
            {
                if (_board[i].Id.Equals(p.Id))
                {
                    cont = true;
                    break;
                }
            }
            if (!cont)
            {
                _board.Add(p);
            }
        }

        public static void SortByPoints()
        {
            _board.Sort(comparePoints);
        }

        private static int comparePoints(Player a, Player b)
        {
            if (a.Score == b.Score) return 0;
            float c = (b.Score - a.Score);
            return (int)(c / Mathf.Abs(c));
        }
    }
}
