using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Biofizz
{
    public static class PlayerManager
    {
        private static List<Player> _playerList = new List<Player>();
        private static Player _currentPlayer;
        public static Player[] GetPlayers
        {
            get => _playerList.ToArray();
        }

        public static Player CurrentPlayer
        {
            get =>_currentPlayer;
        }

        public static void AddPlayer(Player player)
        {
            _playerList.Add(player);
        }

        public static float[] GetPosition(int numOfPlayers)
        {
            if(numOfPlayers == 2)
            {
                return new float[] { -3.35f, 3.35f };
            }else if(numOfPlayers == 3)
            {
                return new float[] { -4.47f, 0f, 4.47f };
            }
            else
            {
                return new float[] { -5.025f, -1.675f, 1.675f, 5.025f};
            }
        }

        public static void AddGameObjects()
        {
            for(int i = 0; i < GetPlayers.Length; i++)
            {
                GameObject go = PrimitiveHelper.CreatePrimitive(PrimitiveType.Cylinder, true);
                go.AddComponent<PlayerControl>().p = _playerList[i];
                go.GetComponent<MeshRenderer>().material = GetPlayers[i].Material;
                Vector3 pos = go.transform.position;
                pos.x = GetPosition(GetPlayers.Length)[i];
                pos.y = -16.15f;
                pos.z = 12.73f;
                go.transform.position = pos;
                Quaternion rot = go.transform.rotation;
                rot.z = 90;
                rot.y = 90;
                go.transform.rotation = rot;
                _playerList[i].SetTransform(go.transform);
            }
        }

        public static void RemovePlayer(Player player)
        {
            _playerList.Remove(player);
        }

        public static void SetCurrentPlayer(Player player)
        {
            _currentPlayer = player;
        }
    }
}
