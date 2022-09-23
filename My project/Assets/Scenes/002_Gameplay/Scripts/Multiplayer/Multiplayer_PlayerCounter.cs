using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Multiplayer_PlayerCounter : MonoBehaviour
{
    public static int playersInGame;
    public static bool readyToStart = false;

    void Start() {
        playersInGame = 0;
    }
    
    void Update () {
        if (playersInGame == LevelSettings.TotalPlayers) {
            readyToStart = true;
        }
    }

    public static int getPlayerID() {
        playersInGame++;
        return playersInGame;
    }
}
