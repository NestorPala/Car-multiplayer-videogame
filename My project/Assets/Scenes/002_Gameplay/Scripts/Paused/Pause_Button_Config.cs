using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
 
public class Pause_Button_Config : MonoBehaviour 
{    
    public Button Back;

    void Start () {
        Back.onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick()
    {
        PausedGame.isPaused = true;
        SceneManager.LoadScene("003_Config", LoadSceneMode.Additive);
    }
}