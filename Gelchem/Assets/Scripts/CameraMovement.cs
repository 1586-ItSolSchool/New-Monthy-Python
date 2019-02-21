using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	private float speed = 10.0f;
	private float horizontalSpeed = 1.0f;
    private float verticalSpeed = 1.0f;
    private float horizontalMinX = -2.5f;
    private float horizontalMaxY = 2.5f;
    private float verticalMinX = -0.20f;
    private float verticalMaxY = 0.20f;

	void Update () {
		if (Input.GetKey(KeyCode.RightArrow)){
			transform.position += Vector3.left * speed * Time.deltaTime;
			Vector3 pos = transform.position;
			pos.x = Mathf.Clamp(transform.position.x, horizontalMinX, horizontalMaxY);
			transform.position = pos;
		}
		if (Input.GetKey(KeyCode.LeftArrow)){
			transform.position += Vector3.right * speed * Time.deltaTime;
			Vector3 pos = transform.position;
			pos.x = Mathf.Clamp(transform.position.x, horizontalMinX, horizontalMaxY);
			transform.position = pos;
		}
		if (Input.GetKey(KeyCode.UpArrow)){
			transform.position += Vector3.down * speed * Time.deltaTime;
			Vector3 pos = transform.position;
			pos.y = Mathf.Clamp(transform.position.y, verticalMinX, verticalMaxY);
			transform.position = pos;
		}
		if (Input.GetKey(KeyCode.DownArrow)){
			transform.position += Vector3.up * speed * Time.deltaTime;
			Vector3 pos = transform.position;
			pos.y = Mathf.Clamp(transform.position.y, verticalMinX, verticalMaxY);
			transform.position = pos;
		}
		if (Input.GetMouseButton (1)) {
			float h = horizontalSpeed * Input.GetAxis("Mouse X");
			float v = verticalSpeed * Input.GetAxis("Mouse Y");
			transform.Translate(-h, -v, 0);
			Vector3 pos = transform.position;
			pos.x = Mathf.Clamp(transform.position.x, horizontalMinX, horizontalMaxY);
			pos.y = Mathf.Clamp(transform.position.y, verticalMinX, verticalMaxY);
			transform.position = pos;
		}
	}
}
