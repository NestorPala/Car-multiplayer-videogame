using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
 
public class Button_Back_Graphics : MonoBehaviour 
{    
    public Button Back;

    void Start () {
        Back.onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick()
    {
        SceneManager.UnloadScene("005_Graphics");
    }
}