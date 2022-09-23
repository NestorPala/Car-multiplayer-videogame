using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
 
public class Button_Back_Scoreboard : MonoBehaviour 
{    
    public Button Back;

    void Start () {
        Back.onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick()
    {
        SceneManager.LoadScene("000_Splash");
        SceneManager.UnloadSceneAsync("008_Scoreboard");
        Gameplay_Finish.RestartEverything();
    }
}