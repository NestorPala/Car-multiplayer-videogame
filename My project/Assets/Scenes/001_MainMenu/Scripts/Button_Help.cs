using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
 
public class Button_Help : MonoBehaviour 
{    
    public Button Boton_Iniciar;

    void Start () {
        Boton_Iniciar.onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick()
    {
        SceneManager.LoadScene("004_HowToPlay");
    }
}