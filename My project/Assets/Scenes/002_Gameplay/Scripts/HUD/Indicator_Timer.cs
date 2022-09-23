 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.UI;

 public class Indicator_Timer : MonoBehaviour {
    public static string mins, secs, milisecs;
    public static string TimerString;
    public static string TimerString2;
    public static float TimerControl, TimerAux;
    public static bool GameHasStarted;

    void Update(){
         
        if (!GameHasStarted) {
            TimerAux = Time.time;
        }

        if (GameHasStarted) {
            TimerControl = Time.time - TimerAux;
        }

        mins = ((int)TimerControl/60).ToString("00");

        secs = (TimerControl % 60).ToString("00");
        if (secs == "60") secs = "59";

        milisecs = ((TimerControl * 100)%100).ToString ("00");
        if (milisecs == "100") milisecs = "99";
            
        TimerString = string.Format ("{00}:{01}:{02}", mins, secs, milisecs);
            
        GetComponent<Text>().text = TimerString.ToString();

        if (!Gameplay_Finish.LevelCompleted) {
            TimerString2 = TimerString.ToString();
        }
    }

    public static string getTime() {
        return TimerString2;
    }
 }