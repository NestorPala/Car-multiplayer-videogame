using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class Indicator_Lap : MonoBehaviour
{
    public GameObject player;
    Player playerController;
    public Text lapIndicator;

    void Start () {
        playerController = player.GetComponent<Player>();
    }

    void Update()
    {
        if (playerController.getLapsDone() > LevelSettings.TotalLaps) {

            playerController.setLapsDone(LevelSettings.TotalLaps); //CORRECION BIEN PIOLA

        }
        
        lapIndicator.text = "VUELTA " + (playerController.getLapsDone() + 1) + "/" + LevelSettings.TotalLaps;
    }
}