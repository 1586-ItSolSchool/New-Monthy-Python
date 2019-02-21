using UnityEngine;
using UnityEngine.UI;
using System.Collections;
 
public class ToolTip: MonoBehaviour {
 
public Transform popuptext;
public static string textstatus = "off";

void OnMouseEnter()
{
	if(textstatus == "off" && Input.GetMouseButton (0) == false && Input.GetMouseButton (1) == false)
	{

	switch (gameObject.name)
{
    case "SphereH":
		popuptext.GetComponent<TextMesh>().text = "H - Водород";
        break;
    case "SphereC":
		popuptext.GetComponent<TextMesh>().text = "C - Углерод";
        break;
    case "SphereN":
		popuptext.GetComponent<TextMesh>().text = "N - Азот";
        break;
    case "SphereO":
		popuptext.GetComponent<TextMesh>().text = "O - Кислород";
        break;
    case "SphereF":
		popuptext.GetComponent<TextMesh>().text = "F - Фтор";
        break;
    case "SphereCl":
		popuptext.GetComponent<TextMesh>().text = "Cl - Хлор";
        break;
    case "SphereBr":
		popuptext.GetComponent<TextMesh>().text = "Br - Бром";
        break;
    case "SphereI":
		popuptext.GetComponent<TextMesh>().text = "I - Йод";
        break;
    case "SphereXe":
		popuptext.GetComponent<TextMesh>().text = "Xe - Ксенон";
        break;
    case "SphereP":
		popuptext.GetComponent<TextMesh>().text = "P - Фосфор";
        break;
    case "SphereS":
		popuptext.GetComponent<TextMesh>().text = "S - Сера";
        break;
    case "SphereB":
		popuptext.GetComponent<TextMesh>().text = "B - Бор";
        break;
    case "SphereHg":
		popuptext.GetComponent<TextMesh>().text = "Hg - Ртуть";
        break;
    case "SphereBe":
		popuptext.GetComponent<TextMesh>().text = "Be - Бериллий";
        break;
    default:
		popuptext.GetComponent<TextMesh>().text = "Атом";
        break;
}
		
		textstatus = "on";
		Instantiate (popuptext, new Vector3(transform.position.x + 1, transform.position.y + 1), popuptext.rotation);


	}
	
}

void OnMouseExit() {

	if(textstatus == "on")
	{
		textstatus = "off";
	}

	
	
}


 
}