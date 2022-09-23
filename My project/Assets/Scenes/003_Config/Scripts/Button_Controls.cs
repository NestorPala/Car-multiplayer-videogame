using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
 
public class Button_Controls : MonoBehaviour 
{    
    public Button Back;

    void Start () {
        Back.onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick()
    {
        SceneManager.LoadScene("007_Controls", LoadSceneMode.Additive);
    }
}