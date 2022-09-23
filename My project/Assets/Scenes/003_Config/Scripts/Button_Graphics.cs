using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
 
public class Button_Graphics : MonoBehaviour 
{    
    public Button Back;

    void Start () {
        Back.onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick()
    {
        SceneManager.LoadScene("005_Graphics", LoadSceneMode.Additive);
    }
}