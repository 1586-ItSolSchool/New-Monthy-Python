using UnityEngine;
using UnityEngine.UI;
using System.Collections;
 
public class ToolTipHover: MonoBehaviour {
 
void Start() {
	GetComponent<TextMesh>().GetComponent<Renderer>().sortingOrder = 10;
}

void Update() {
	
	if(ToolTip.textstatus == "off")
	{
		Destroy(gameObject);
	}
	
}



 
}