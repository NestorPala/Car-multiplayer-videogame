using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gameplay_Finish : MonoBehaviour
{
    public static bool LevelCompleted = false;

    /*
    void Update()
    {
        if (IsUpsideDown) {
            SceneManager.LoadScene("002_Gameplay");
            RestartEverything();
        }
    }
    */

    public static void FinishRace () {
        LevelCompleted = true;
        var players = FindObjectsOfType<Player>();
        Results.setResults(players);
        SceneManager.LoadScene("008_Scoreboard");
    }

    public static void RestartEverything () {
        LevelCompleted = false;

        Indicator_Timer.GameHasStarted = false;
        Indicator_Timer.TimerAux = 0;
        Indicator_Timer.TimerString = "";
        Indicator_Timer.TimerString2 = "";
        Indicator_Timer.TimerControl = 0;
        Indicator_Timer.mins = "";
        Indicator_Timer.secs = "";
        Indicator_Timer.milisecs = "";
        
        var players = FindObjectsOfType<Player>();
        for (int i=0; i<players.Length; i++) {
            players[i].setAlmostFinishedRace(false);
            players[i].setLapsDone(0);
            players[i].setSpeed(0);
            //players[i].isUpsideDown(false);  
        }
        
        FinishedPlayers.amount = 0;
        
        return;
    }

/*
    void Countdown (float seconds) {
        float timeLeft = seconds;

        if (timeLeft > 0.0f) {
                timeLeft -= Time.deltaTime/60;
        }
        return;
    }
*/
}
