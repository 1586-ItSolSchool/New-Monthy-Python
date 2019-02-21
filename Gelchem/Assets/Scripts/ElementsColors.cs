using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class ElementsColors : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
	
    //Reference to button to access its components
    private Button theButton;
 
    //this get the Transitions of the Button as its pressed
    private ColorBlock theColor;
	private Color32 color32;
	private Color Highlighted;
    private Color Normal;
	

void Awake(){

	
	Text text = GetComponentInChildren<Text>();
	theButton = GetComponent<Button>();
	theColor = GetComponent<Button>().colors;
	Highlighted = Color.black;
	
	switch (text.text)
{
    case "H":
		color32 = new Color32(238, 238, 238, 255);
        theColor.normalColor = color32;
        break;
    case "C":
		color32 = new Color32(34, 34, 34, 255);
        theColor.normalColor = color32;
		text.color = new Color(255, 255, 255);
        break;
    case "N":
		color32 = new Color32(34, 51, 255, 255);
        theColor.normalColor = color32;
		text.color = new Color(255, 255, 255);
        break;
    case "O":
		color32 = new Color32(255, 34, 0, 255);
        theColor.normalColor = color32;
		text.color = new Color(255, 255, 255);
        break;
    case "F":
		color32 = new Color32(0, 255, 0, 255);
        theColor.normalColor = color32;
        break;
    case "Cl":
		color32 = new Color32(0, 255, 0, 255);
        theColor.normalColor = color32;
        break;
    case "Br":
		color32 = new Color32(153, 34, 0, 255);
        theColor.normalColor = color32;
		text.color = new Color(255, 255, 255);
        break;
    case "I":
		color32 = new Color32(102, 0, 187, 255);
        theColor.normalColor = color32;
		text.color = new Color(255, 255, 255);
        break;
    case "Xe":
		color32 = new Color32(0, 255, 255, 255);
        theColor.normalColor = color32;
        break;
    case "P":
		color32 = new Color32(255, 153, 0, 255);
        theColor.normalColor = color32;
        break;
    case "S":
		color32 = new Color32(255, 229, 34, 255);
        theColor.normalColor = color32;
        break;
    case "B":
		color32 = new Color32(255, 170, 119, 255);
        theColor.normalColor = color32;
        break;
    case "Hg":
		color32 = new Color32(255, 170, 119, 255);
        theColor.normalColor = color32;
        break;
    case "Be":
		color32 = new Color32(0, 119, 0, 255);
        theColor.normalColor = color32;
		text.color = new Color(255, 255, 255);
        break;
    case "←":
		color32 = new Color32(2, 187, 211, 255);
        theColor.normalColor = color32;
		text.color = new Color(255, 255, 255);
        break;
    case "⌂":
		color32 = new Color32(2, 187, 211, 255);
        theColor.normalColor = color32;
		text.color = new Color(255, 255, 255);
        break;
    case "?":
		color32 = new Color32(2, 187, 211, 255);
        theColor.normalColor = color32;
		text.color = new Color(255, 255, 255);
        break;
    case "Wikipedia.org":
		color32 = new Color32(2, 187, 211, 255);
        theColor.normalColor = color32;
		text.color = new Color(255, 255, 255);
        break;
    case "Молекулы":
		color32 = new Color32(2, 187, 211, 255);
        theColor.normalColor = color32;
		text.color = new Color(255, 255, 255);
        break;
    case ".":
		color32 = new Color32(255, 255, 192, 255);
        theColor.normalColor = color32;
		text.color = new Color(255, 255, 255);
        break;
    default:
        theButton.colors = theColor;
        break;
}

theButton.colors = theColor;
	
}

void Start() {
	Normal = GetComponentInChildren<Text>().color;	
}

    public void OnPointerEnter(PointerEventData pointerEventData)
    {
		GetComponentInChildren<Text>().color = Highlighted;
    }

    public void OnPointerExit(PointerEventData pointerEventData)
    {
		GetComponentInChildren<Text>().color = Normal;
    }


}