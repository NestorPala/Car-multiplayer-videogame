using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameplay_Start : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 1;
        //Gameplay_Finish.IsUpsideDown = false;

        /*
        //PRUEBA RAPIDA DE GAMEPLAY FINISHED
        var players = FindObjectsOfType<Player>();

        for (int i=0; i<players.Length; i++) {
            players[i].setLapsDone(1);
            players[i].setAlmostFinishedRace(true);
        }
        */
    }
}
