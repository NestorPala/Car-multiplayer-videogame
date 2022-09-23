using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause_Menu : MonoBehaviour {

    bool active;
    public Canvas Pause_Canvas, Gameplay_Canvas;
    public Button Pause_Back_Button;

	// Use this for initialization
	void Start () {
        Pause_Back_Button.onClick.AddListener(TaskOnClick);
        Pause_Canvas.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
        {
            active = !active;
            Pause_Canvas.enabled = active;
            Gameplay_Canvas.enabled = !active;
            Time.timeScale = (active) ? 0 : 1f;
        }
	}

    void TaskOnClick()
    {
        active = !active;
        Pause_Canvas.enabled = active;
        Gameplay_Canvas.enabled = !active;
        Time.timeScale = (active) ? 0 : 1f;
    }
}
