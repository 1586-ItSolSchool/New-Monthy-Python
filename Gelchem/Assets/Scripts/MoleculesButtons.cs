using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;
public class MoleculesButtons : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
	
public TextMeshProUGUI formText;
private Color Highlighted;
private Color Normal;
private ColorBlock theColor;
private Color32 color32;
private Button theButton;

void Awake() {
	Highlighted = Color.black;
	Normal = Color.white;
	GetComponentInChildren<TextMeshProUGUI>().color = Normal;
	theButton = GetComponent<Button>();
	theColor = GetComponent<Button>().colors;
	color32 = new Color32(2, 187, 211, 255);
	theColor.normalColor = color32;
	theButton.colors = theColor;
	theButton.GetComponent<RectTransform>().sizeDelta = new Vector2 (theButton.GetComponent<RectTransform>().sizeDelta.x, 45);
	theButton.GetComponent<Image>().sprite = Resources.Load<Sprite>("none");
}


void Start() {
	formText = GetComponentInChildren<TextMeshProUGUI>();
}

public void OnPointerEnter(PointerEventData pointerEventData)
{
	GetComponentInChildren<TextMeshProUGUI>().color = Highlighted;
}

public void OnPointerExit(PointerEventData pointerEventData)
{
	GetComponentInChildren<TextMeshProUGUI>().color = Normal;
}




void Update () 
{
	//formText = GetComponent<TextMeshProUGUI>();
	//formText.color = new Color32(255, 255, 255, 255);
	
	//Debug.Log(formText);
}	

}