using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wikipedia : MonoBehaviour
{


public void WikipediaOrg() {
	
	var currentScene = SceneManager.GetActiveScene();
	string currentSceneName = currentScene.name;
	string WikiUrl = "";
	
	switch (currentSceneName)
{
    case "H":
		WikiUrl = "https://ru.wikipedia.org/wiki/%D0%92%D0%BE%D0%B4%D0%BE%D1%80%D0%BE%D0%B4";
        break;
    case "C":
		WikiUrl = "https://ru.wikipedia.org/wiki/%D0%A3%D0%B3%D0%BB%D0%B5%D1%80%D0%BE%D0%B4";
        break;
    case "N":
		WikiUrl = "https://ru.wikipedia.org/wiki/%D0%90%D0%B7%D0%BE%D1%82";
        break;
    case "O":
		WikiUrl = "https://ru.wikipedia.org/wiki/%D0%9A%D0%B8%D1%81%D0%BB%D0%BE%D1%80%D0%BE%D0%B4";
        break;
    case "F":
		WikiUrl = "https://ru.wikipedia.org/wiki/%D0%A4%D1%82%D0%BE%D1%80";
        break;
    case "Cl":
		WikiUrl = "https://ru.wikipedia.org/wiki/%D0%A5%D0%BB%D0%BE%D1%80";
        break;
    case "Br":
		WikiUrl = "https://ru.wikipedia.org/wiki/%D0%91%D1%80%D0%BE%D0%BC";
        break;
    case "I":
		WikiUrl = "https://ru.wikipedia.org/wiki/%D0%98%D0%BE%D0%B4";
        break;
    case "Xe":
		WikiUrl = "https://ru.wikipedia.org/wiki/%D0%9A%D1%81%D0%B5%D0%BD%D0%BE%D0%BD";
        break;
    case "P":
		WikiUrl = "https://ru.wikipedia.org/wiki/%D0%A4%D0%BE%D1%81%D1%84%D0%BE%D1%80";
        break;
    case "S":
		WikiUrl = "https://ru.wikipedia.org/wiki/%D0%A1%D0%B5%D1%80%D0%B0";
        break;
    case "B":
		WikiUrl = "https://ru.wikipedia.org/wiki/%D0%91%D0%BE%D1%80_(%D1%8D%D0%BB%D0%B5%D0%BC%D0%B5%D0%BD%D1%82)";
        break;
    case "Hg":
		WikiUrl = "https://ru.wikipedia.org/wiki/%D0%A0%D1%82%D1%83%D1%82%D1%8C";
        break;
    case "Be":
		WikiUrl = "https://ru.wikipedia.org/wiki/%D0%91%D0%B5%D1%80%D0%B8%D0%BB%D0%BB%D0%B8%D0%B9";
        break;
    case "Main":
		WikiUrl = "https://ru.wikipedia.org/wiki/%D0%A2%D0%B5%D0%BE%D1%80%D0%B8%D1%8F_%D0%BE%D1%82%D1%82%D0%B0%D0%BB%D0%BA%D0%B8%D0%B2%D0%B0%D0%BD%D0%B8%D1%8F_%D1%8D%D0%BB%D0%B5%D0%BA%D1%82%D1%80%D0%BE%D0%BD%D0%BD%D1%8B%D1%85_%D0%BF%D0%B0%D1%80";
        break;
    case "Molecules":
		WikiUrl = "https://ru.wikipedia.org/wiki/%D0%9C%D0%BE%D0%BB%D0%B5%D0%BA%D1%83%D0%BB%D0%B0";
        break;
    case "BeCl2":
		WikiUrl = "https://ru.wikipedia.org/wiki/%D0%A5%D0%BB%D0%BE%D1%80%D0%B8%D0%B4_%D0%B1%D0%B5%D1%80%D0%B8%D0%BB%D0%BB%D0%B8%D1%8F";
        break;
    case "BF3":
		WikiUrl = "https://ru.wikipedia.org/wiki/%D0%A2%D1%80%D0%B8%D1%84%D1%82%D0%BE%D1%80%D0%B8%D0%B4_%D0%B1%D0%BE%D1%80%D0%B0";
        break;
    case "BrF3":
		WikiUrl = "https://ru.wikipedia.org/wiki/%D0%A4%D1%82%D0%BE%D1%80%D0%B8%D0%B4_%D0%B1%D1%80%D0%BE%D0%BC%D0%B0(III)";
        break;
    case "BrF5":
		WikiUrl = "https://ru.wikipedia.org/wiki/%D0%A4%D1%82%D0%BE%D1%80%D0%B8%D0%B4_%D0%B1%D1%80%D0%BE%D0%BC%D0%B0(V)";
        break;
    case "CH4":
		WikiUrl = "https://ru.wikipedia.org/wiki/%D0%9C%D0%B5%D1%82%D0%B0%D0%BD";
        break;
    case "ClF3":
		WikiUrl = "https://ru.wikipedia.org/wiki/%D0%A4%D1%82%D0%BE%D1%80%D0%B8%D0%B4_%D1%85%D0%BB%D0%BE%D1%80%D0%B0(III)";
        break;
    case "ClF5":
		WikiUrl = "https://ru.wikipedia.org/wiki/%D0%A4%D1%82%D0%BE%D1%80%D0%B8%D0%B4_%D1%85%D0%BB%D0%BE%D1%80%D0%B0(V)";
        break;
    case "ClO4":
		WikiUrl = "https://en.wikipedia.org/wiki/Perchlorate";
        break;
    case "CO2":
		WikiUrl = "https://ru.wikipedia.org/wiki/%D0%94%D0%B8%D0%BE%D0%BA%D1%81%D0%B8%D0%B4_%D1%83%D0%B3%D0%BB%D0%B5%D1%80%D0%BE%D0%B4%D0%B0";
        break;
    case "CO3":
		WikiUrl = "https://en.wikipedia.org/wiki/Carbonate";
        break;
    case "H2O":
		WikiUrl = "https://ru.wikipedia.org/wiki/%D0%92%D0%BE%D0%B4%D0%B0";
        break;
    case "HF":
		WikiUrl = "https://ru.wikipedia.org/wiki/%D0%A4%D1%82%D0%BE%D1%80%D0%BE%D0%B2%D0%BE%D0%B4%D0%BE%D1%80%D0%BE%D0%B4";
        break;
    case "HgCl2":
		WikiUrl = "https://ru.wikipedia.org/wiki/%D0%A5%D0%BB%D0%BE%D1%80%D0%B8%D0%B4_%D1%80%D1%82%D1%83%D1%82%D0%B8(II)";
        break;
    case "I3":
		WikiUrl = "https://en.wikipedia.org/wiki/Triiodide";
        break;
    case "IF7":
		WikiUrl = "https://ru.wikipedia.org/wiki/%D0%A4%D1%82%D0%BE%D1%80%D0%B8%D0%B4_%D0%B8%D0%BE%D0%B4%D0%B0(VII)";
        break;
    case "NH3":
		WikiUrl = "https://ru.wikipedia.org/wiki/%D0%90%D0%BC%D0%BC%D0%B8%D0%B0%D0%BA";
        break;
    case "NO2":
		WikiUrl = "https://ru.wikipedia.org/wiki/%D0%9E%D0%BA%D1%81%D0%B8%D0%B4_%D0%B0%D0%B7%D0%BE%D1%82%D0%B0(IV)";
        break;
    case "NO3":
		WikiUrl = "https://en.wikipedia.org/wiki/Nitrate";
        break;
    case "O2":
		WikiUrl = "https://ru.wikipedia.org/wiki/%D0%9A%D0%B8%D1%81%D0%BB%D0%BE%D1%80%D0%BE%D0%B4"; //jjj
        break;
    case "O3":
		WikiUrl = "https://ru.wikipedia.org/wiki/%D0%9E%D0%B7%D0%BE%D0%BD";
        break;
    case "OF2":
		WikiUrl = "https://ru.wikipedia.org/wiki/%D0%A4%D1%82%D0%BE%D1%80%D0%B8%D0%B4_%D0%BA%D0%B8%D1%81%D0%BB%D0%BE%D1%80%D0%BE%D0%B4%D0%B0(II)";
        break;
    case "PCl3":
		WikiUrl = "https://ru.wikipedia.org/wiki/%D0%A5%D0%BB%D0%BE%D1%80%D0%B8%D0%B4_%D1%84%D0%BE%D1%81%D1%84%D0%BE%D1%80%D0%B0(III)";
        break;
    case "PCl5":
		WikiUrl = "https://ru.wikipedia.org/wiki/%D0%A5%D0%BB%D0%BE%D1%80%D0%B8%D0%B4_%D1%84%D0%BE%D1%81%D1%84%D0%BE%D1%80%D0%B0(V)";
        break;
    case "PO4":
		WikiUrl = "https://en.wikipedia.org/wiki/Phosphate";
        break;
    case "SF4":
		WikiUrl = "https://ru.wikipedia.org/wiki/%D0%A2%D0%B5%D1%82%D1%80%D0%B0%D1%84%D1%82%D0%BE%D1%80%D0%B8%D0%B4_%D1%81%D0%B5%D1%80%D1%8B";
        break;
    case "SF6":
		WikiUrl = "https://ru.wikipedia.org/wiki/%D0%A4%D1%82%D0%BE%D1%80%D0%B8%D0%B4_%D1%81%D0%B5%D1%80%D1%8B(VI)";
        break;
    case "SO2":
		WikiUrl = "https://ru.wikipedia.org/wiki/%D0%9E%D0%BA%D1%81%D0%B8%D0%B4_%D1%81%D0%B5%D1%80%D1%8B(IV)";
        break;
    case "SO3":
		WikiUrl = "https://ru.wikipedia.org/wiki/%D0%9E%D0%BA%D1%81%D0%B8%D0%B4_%D1%81%D0%B5%D1%80%D1%8B(VI)";
        break;
    case "SO4":
		WikiUrl = "https://en.wikipedia.org/wiki/Sulfate";
        break;
    case "XeF2":
		WikiUrl = "https://ru.wikipedia.org/wiki/%D0%A4%D1%82%D0%BE%D1%80%D0%B8%D0%B4_%D0%BA%D1%81%D0%B5%D0%BD%D0%BE%D0%BD%D0%B0(II)";
        break;
    case "XeF4":
		WikiUrl = "https://ru.wikipedia.org/wiki/%D0%A4%D1%82%D0%BE%D1%80%D0%B8%D0%B4_%D0%BA%D1%81%D0%B5%D0%BD%D0%BE%D0%BD%D0%B0(IV)";
        break;
    case "XeF5":
		WikiUrl = "https://en.wikipedia.org/wiki/Tetramethylammonium_pentafluoroxenate";
        break;
    case "XeF6":
		WikiUrl = "https://ru.wikipedia.org/wiki/%D0%A4%D1%82%D0%BE%D1%80%D0%B8%D0%B4_%D0%BA%D1%81%D0%B5%D0%BD%D0%BE%D0%BD%D0%B0(VI)";
        break;
    default:
        WikiUrl = "https://ru.wikipedia.org/wiki/%D0%A1%D0%BF%D0%B8%D1%81%D0%BE%D0%BA_%D1%85%D0%B8%D0%BC%D0%B8%D1%87%D0%B5%D1%81%D0%BA%D0%B8%D1%85_%D1%8D%D0%BB%D0%B5%D0%BC%D0%B5%D0%BD%D1%82%D0%BE%D0%B2";
        break;
}

	Application.OpenURL(WikiUrl);	
	
}


}