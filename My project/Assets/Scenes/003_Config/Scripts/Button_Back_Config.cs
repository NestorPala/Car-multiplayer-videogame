using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
 
public class Button_Back_Config : MonoBehaviour 
{    
    public Button Back;

    void Start () {
        Back.onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick()
    {
        if (PausedGame.isPaused) {
            PausedGame.isPaused = false;
            SceneManager.UnloadScene("003_Config");
        }
        else {
            SceneManager.LoadScene("001_MainMenu");
        }
    }
}