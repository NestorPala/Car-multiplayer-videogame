using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Stick_Android : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {

  private bool isDown;
  public static bool isPressed;
  public Canvas hud;
  public Button topButton, bottomButton, leftButton, rightButton;

  public void OnPointerDown(PointerEventData eventData) {
    this.isDown = true;
  }

  public void OnPointerUp(PointerEventData eventData) {
    this.isDown = false;
  }

  void Start () {
    /*
    topButton.interactable = false;
    bottomButton.interactable = false;
    leftButton.interactable = false;
    rightButton.interactable = false;
    */
  }
  void Update() {
    if (this.isDown) {
        Debug.Log(this.isDown);

        double top = hud.transform.position.y/1.5;
        double bottom = hud.transform.position.y/11;
        double left = hud.transform.position.x/11;
        double right = hud.transform.position.x/2.5;
        

        if (Input.mousePosition.x < right && Input.mousePosition.y < top && 
            Input.mousePosition.x > left  && Input.mousePosition.y > bottom) {
          this.gameObject.transform.position = Input.mousePosition;
        }
        else if (Input.mousePosition.y < top) {
          this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, Input.mousePosition.y, this.gameObject.transform.position.z);
        }
        else if (Input.mousePosition.x < right) {
          this.gameObject.transform.position = new Vector3(Input.mousePosition.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
        }
        else if (Input.mousePosition.y > bottom) {
          this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, Input.mousePosition.y, this.gameObject.transform.position.z);
        }
        else if (Input.mousePosition.x > left) {
          this.gameObject.transform.position = new Vector3(Input.mousePosition.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
        }
 

        /*
        if (Input.mousePosition.y == top) {
          topButton.interactable = true;
        }
        else {
          topButton.interactable = false;
        }

        if (Input.mousePosition.y == bottom) {
          bottomButton.interactable = true;
        }
        else {
          bottomButton.interactable = false;
        }

        if (Input.mousePosition.x == left) {
          leftButton.interactable = true;
        }
        else {
          leftButton.interactable = false;
        }

        if (Input.mousePosition.x == right) {
          rightButton.interactable = true;
        }
        else {
          rightButton.interactable = false;
        }
        */
    }
    else {
        this.gameObject.transform.localPosition = new Vector3(0, 0, 0);
    }
  }
}