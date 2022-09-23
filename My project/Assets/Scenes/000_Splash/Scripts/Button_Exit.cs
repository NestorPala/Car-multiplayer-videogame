using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Button_Exit : MonoBehaviour 
{
    public Button Config;

    void Start () {
        Config.onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick()
    {
        Debug.Log("SALIENDO DEL PROGRAMA");
        Application.Quit();
    }
}