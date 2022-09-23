using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Results : MonoBehaviour
{
    static Player[] results_container = new Player[LevelSettings.TotalPlayers];

    public static void setResults (Player[] results) {
        results_container = results;
    }

    public static Player[] getResults () {
        return results_container;
    }
}
