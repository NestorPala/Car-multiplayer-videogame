using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LapCounter : MonoBehaviour
{
    Player player;

    void Start () {
        player = GetComponent<Player>();
    }

    void Update() {
        if (FinishedPlayers.amount == LevelSettings.TotalPlayers) {
            Gameplay_Finish.FinishRace();
        }
    }

    void OnTriggerEnter (Collider col) {
        if (col.gameObject.tag == "Checkpoint") {

            Indicator_Timer.GameHasStarted = true;
            Checkpoint CheckpointDetector = col.gameObject.GetComponent<Checkpoint>();
            player.setActualCheckpoint(CheckpointDetector.ID);

            if ((player.getActualCheckpoint() == 1) && player.getAlmostFinishedRace()) {
                player.setLapsDone(player.getLapsDone() + 1);
                player.setAlmostFinishedRace(false);

                if (player.getLapsDone() == LevelSettings.TotalLaps) { //DETECTA CUANDO SE COMPLETAN TODAS LAS VUELTAS
                    
                    string time = Indicator_Timer.TimerString2;
                    
                    player.setTime(time);

                    FinishedPlayers.amount++;
                }
            }

            if (player.getActualCheckpoint() == 5 && !player.getAlmostFinishedRace()) {
                player.setAlmostFinishedRace(true);
            } 

            if (player.getActualCheckpoint() == LevelSettings.TotalCheckpoints) {
                player.setNextCheckpoint(1);
            } 
            else {
                player.setNextCheckpoint(player.getActualCheckpoint() + 1);
            }

            Debug.Log("CHECKPOINT ACTUAL: " + player.getActualCheckpoint()); 
            Debug.Log("PROXIMO CHECKPOINT: " + player.getNextCheckpoint());

            /*
            //REQUIERE REDISEÑO DE LAS VARIABLES DE PERMISOS PARA ATRAVESAR LOS CHECKPOINTS
            //REVERSE AVOIDER
            for (int i=1; i<=LevelSettings.TotalCheckpoints; i++) {

                if (i == player.getNextCheckpoint()) {
                    Checkpoint_ID.CheckpointControl[i-1] = true;
                }
                else {
                    Checkpoint_ID.CheckpointControl[i-1] = false;
                }
            }
            */
        }
    } 
}

/*
    void OnTriggerEnter (Collider col) {
        if (col.gameObject.tag == "Player") {
        }
    }
 */