using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
 
public class Button_Config : MonoBehaviour 
{    
    public Button Config;

    void Start () {
        Config.onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick()
    {
        SceneManager.LoadScene("003_Config");
    }
}