using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
 
public class Button_Start : MonoBehaviour 
{    
    public Button Boton_Iniciar;

    void Start () {
        Boton_Iniciar.onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick()
    {
        SceneManager.LoadScene("001_MainMenu");
    }
}