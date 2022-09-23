using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
 
public class Button_Gameplay : MonoBehaviour 
{    
    public Button Boton_Iniciar;

    void Start () {
        Boton_Iniciar.onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick()
    {
        SceneManager.LoadScene("002_Gameplay");
    }
}