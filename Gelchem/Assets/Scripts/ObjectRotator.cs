using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ObjectRotator : MonoBehaviour {
	
	float horizontalSpeed = 10.0f;
    float verticalSpeed = 10.0f;
	private bool cursorSt = false;

	void Start () {
		//Cursor.lockState = CursorLockMode.Locked;
		//Cursor.visible = false;
	}
	
	void FixedUpdate () {
		if (Input.GetMouseButton (0)) {
			float h = horizontalSpeed * Input.GetAxis("Mouse X");
			float v = verticalSpeed * Input.GetAxis("Mouse Y");
			transform.Rotate(v, h, 0);
		}
	}
	
		
    float clicked = 0;
    float clicktime = 0;
    float clickdelay = 0.5f;
 
    public void OnPointerDown(PointerEventData data)
    {
        clicked++;
        if (clicked == 1) clicktime = Time.time;
 
        if (clicked > 1 && Time.time - clicktime < clickdelay)
        {
            clicked = 0;
            clicktime = 0;
			Debug.Log("Double CLick: "+this.GetComponent<RectTransform>().name);

 
        }
        else if (clicked > 2 || Time.time - clicktime > 1) clicked = 0;
 
    }
	
	 void OnGUI()
 {
	 
     if(Event.current.isMouse && Event.current.button == 0 && Event.current.clickCount > 1)
     {
		if(cursorSt){
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;
			cursorSt = false;
		}
		else {
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = false;
			cursorSt = true;
		}
     }
 }
 	
	
	
	
	
	
	
	
	
	
	
	
}
