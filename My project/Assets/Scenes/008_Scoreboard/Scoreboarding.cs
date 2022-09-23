using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scoreboarding : MonoBehaviour
{
    Player[] results, results2;
    static int totalPlayers = LevelSettings.TotalPlayers;
    public Text[] player_text = new Text[totalPlayers];
    
    void Start () {
        results = Results.getResults();

        results2 = setPlayerPlaces(results);

        //comandos para escribir los textos de players
        for (int i=0; i<totalPlayers; i++) {
            player_text[i].GetComponent<Text>().text = results2[i].getPlace() + "º" + "       " + "PLAYER" + i + "       " +  results2[i].getTime();
        }
    }

    Player[] setPlayerPlaces(Player[] results) {
        Player[] a = results;
        int[] playersSecs = new int[LevelSettings.TotalPlayers];

        for (int i=0; i<results.Length; i++) {
            string str = results[i].getTime();
            string[] strlist = str.Split(':');
            
            for (int j=0; j<strlist.Length; j++) {
                playersSecs[i] += int.Parse(strlist[j]);
            }
        }

        for (int i=1; i<results.Length; i++) {
            for (int j=0; j<(results.Length-1); j++) {
                if (playersSecs[i] > playersSecs[j]) {
                    Player aux = a[i];
                    a[i] = a[j];
                    a[j] = aux;

                    int aux2 = playersSecs[i];
                    playersSecs[i] = playersSecs[j];
                    playersSecs[j] = aux2;
                }
            }
        }

        for (int i=0; i<results.Length; i++) {
            a[i].setPlace(i+1);
        }

        return a;
    }
}
