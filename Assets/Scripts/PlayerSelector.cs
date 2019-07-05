using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Biofizz;

public class PlayerSelector : MonoBehaviour
{
    public int minPlayers = 0;
    public List<Material> colors;
    int GM = 0;
    public static int players = 0, counter;
    public Text playersCounter, namePlaceHolder;
    public InputField playerName;
    public GameObject numberOfPlayer, playersNames;

    public void addPlayer()
    {
        if (players < 4)
            players++;
        playersCounter.text = "Jogadores: " + players;
    }

    public void removePlayer()
    {
        if (players > minPlayers)
            players--;
        playersCounter.text = "Jogadores: " + players;
    }

    public void setMinPlayers(int i)
    {
        minPlayers = i;
        players = minPlayers;
        playersCounter.text = "Jogadores: " + players;
    }

    public void askPlayersNames()
    {
        numberOfPlayer.SetActive(false);
        playersNames.SetActive(true);
        playerName.Select();
    }

    public void SetGM(int i)
    {
        if(i == 0)
        {
            GM = 0;
            GameModeManager.SetGameMode(GameModeManager.GameModes.Race);
        }
        else
        {
            GM = 1;
            GameModeManager.SetGameMode(GameModeManager.GameModes.Timed);
        }
    }

    public void confirmName()
    {
        if (counter < players)
        {
            if (playerName.text != "")
            {
                Player p = new Player(playerName.text, colors[counter]);
                PlayerManager.AddPlayer(p);
                counter++;
                if(counter == players)
                {
                    //Carregar jogo
                    PlayerManager.SetCurrentPlayer(PlayerManager.GetPlayers[0]);
                    SceneManager.LoadScene(GM+1, LoadSceneMode.Single);
                }
                else
                {
                    playerName.Select();
                    playerName.text = "";
                    namePlaceHolder.text = "Nome Jogador " + (counter + 1);
                }
            }
        }
    }
}
