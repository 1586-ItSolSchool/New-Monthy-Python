using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Menu : MonoBehaviour
{
	
	
	public void GithubCom() {
		Application.OpenURL("https://github.com/1586-ItSolSchool");
	}
	
	public static string LSScene = "";

	public void LoadSceneMolecules () {
		SceneManager.LoadScene("Molecules");
	}

	public void LoadSceneElements () {
		SceneManager.LoadScene("Elements");
	}

	public void LoadSceneAbout () {
		SceneManager.LoadScene("About");
	}

	public void LoadSceneMain () {
		SceneManager.LoadScene("Main");
	}
	
	public void AppQuit () {
		Application.Quit();
	}

	public void LoadSceneBeCl2 () {
		SceneManager.LoadScene("BeCl2");
		LSScene = "BeCl2";
	}

	public void LoadSceneBF3 () {
		SceneManager.LoadScene("BF3");
		LSScene = "BF3";
	}

	public void LoadSceneBrF3 () {
		SceneManager.LoadScene("BrF3");
		LSScene = "BrF3";
	}

	public void LoadSceneBrF5 () {
		SceneManager.LoadScene("BrF5");
		LSScene = "BrF5";
	}

	public void LoadSceneCH4 () {
		SceneManager.LoadScene("CH4");
		LSScene = "CH4";
	}

	public void LoadSceneClF3 () {
		SceneManager.LoadScene("ClF3");
		LSScene = "ClF3";
	}

	public void LoadSceneClF5 () {
		SceneManager.LoadScene("ClF5");
		LSScene = "ClF5";
	}

	public void LoadSceneClO4 () {
		SceneManager.LoadScene("ClO4");
		LSScene = "ClO4";
	}

	public void LoadSceneCO2 () {
		SceneManager.LoadScene("CO2");
		LSScene = "CO2";
	}

	public void LoadSceneCO3 () {
		SceneManager.LoadScene("CO3");
		LSScene = "CO3";
	}

	public void LoadSceneH2O () {
		SceneManager.LoadScene("H2O");
		LSScene = "H2O";
	}

	public void LoadSceneHF () {
		SceneManager.LoadScene("HF");
		LSScene = "HF";
	}

	public void LoadSceneHgCl2 () {
		SceneManager.LoadScene("HgCl2");
		LSScene = "HgCl2";
	}

	public void LoadSceneI3 () {
		SceneManager.LoadScene("I3");
		LSScene = "I3";
	}

	public void LoadSceneIF7 () {
		SceneManager.LoadScene("IF7");
		LSScene = "IF7";
	}

	public void LoadSceneNH3 () {
		SceneManager.LoadScene("NH3");
		LSScene = "NH3";
	}

	public void LoadSceneNO2 () {
		SceneManager.LoadScene("NO2");
		LSScene = "NO2";
	}

	public void LoadSceneNO3 () {
		SceneManager.LoadScene("NO3");
		LSScene = "NO3";
	}

	public void LoadSceneO2 () {
		SceneManager.LoadScene("O2");
		LSScene = "O2";
	}

	public void LoadSceneO3 () {
		SceneManager.LoadScene("O3");
		LSScene = "O3";
	}

	public void LoadSceneOF2 () {
		SceneManager.LoadScene("OF2");
		LSScene = "OF2";
	}

	public void LoadScenePCl3 () {
		SceneManager.LoadScene("PCl3");
		LSScene = "PCl3";
	}

	public void LoadScenePCl5 () {
		SceneManager.LoadScene("PCl5");
		LSScene = "PCl5";
	}

	public void LoadScenePO4 () {
		SceneManager.LoadScene("PO4");
		LSScene = "PO4";
	}

	public void LoadSceneSF4 () {
		SceneManager.LoadScene("SF4");
		LSScene = "SF4";
	}

	public void LoadSceneSF6 () {
		SceneManager.LoadScene("SF6");
		LSScene = "SF6";
	}

	public void LoadSceneSO2 () {
		SceneManager.LoadScene("SO2");
		LSScene = "SO2";
	}

	public void LoadSceneSO3 () {
		SceneManager.LoadScene("SO3");
		LSScene = "SO3";
	}

	public void LoadSceneSO4 () {
		SceneManager.LoadScene("SO4");
		LSScene = "SO4";
	}

	public void LoadSceneXeF2 () {
		SceneManager.LoadScene("XeF2");
		LSScene = "XeF2";
	}

	public void LoadSceneXeF4 () {
		SceneManager.LoadScene("XeF4");
		LSScene = "XeF4";
	}

	public void LoadSceneXeF5 () {
		SceneManager.LoadScene("XeF5");
		LSScene = "XeF5";
	}

	public void LoadSceneXeF6 () {
		SceneManager.LoadScene("XeF6");
		LSScene = "XeF6";
	}

	public void LoadSceneB () {
		SceneManager.LoadScene("B");
	}
	
	public void LoadSceneBe () {
		SceneManager.LoadScene("Be");
	}
	
	public void LoadSceneBr () {
		SceneManager.LoadScene("Br");
	}
	
	public void LoadSceneC () {
		SceneManager.LoadScene("C");
	}
	
	public void LoadSceneCl () {
		SceneManager.LoadScene("Cl");
	}
	
	public void LoadSceneF () {
		SceneManager.LoadScene("F");
	}
	
	public void LoadSceneH () {
		SceneManager.LoadScene("H");
	}
	
	public void LoadSceneHg () {
		SceneManager.LoadScene("Hg");
	}
	
	public void LoadSceneI () {
		SceneManager.LoadScene("I");
	}
	
	public void LoadSceneN () {
		SceneManager.LoadScene("N");
	}
	
	public void LoadSceneO () {
		SceneManager.LoadScene("O");
	}
	
	public void LoadSceneP () {
		SceneManager.LoadScene("P");
	}
	
	public void LoadSceneS () {
		SceneManager.LoadScene("S");
	}
	
	public void LoadSceneXe () {
		SceneManager.LoadScene("Xe");
	}
	
	public void ButtonBack () {
		var currentScene = SceneManager.GetActiveScene();
		string currentSceneName = currentScene.name;
		  
			switch (currentSceneName)
			{
				
				case "Main":
					SceneManager.LoadScene("Main");
					break;
				case "About":
					SceneManager.LoadScene("Main");
					break;
				case "Elements":
					SceneManager.LoadScene("Main");
					break;
				case "Molecules":
					SceneManager.LoadScene("Main");
					break;
				case "BeCl2":
					SceneManager.LoadScene("Molecules");
					break;
				case "BF3":
					SceneManager.LoadScene("Molecules");
					break;
				case "BrF3":
					SceneManager.LoadScene("Molecules");
					break;
				case "BrF5":
					SceneManager.LoadScene("Molecules");
					break;
				case "CH4":
					SceneManager.LoadScene("Molecules");
					break;
				case "ClF3":
					SceneManager.LoadScene("Molecules");
					break;
				case "ClF5":
					SceneManager.LoadScene("Molecules");
					break;
				case "ClO4":
					SceneManager.LoadScene("Molecules");
					break;
				case "CO2":
					SceneManager.LoadScene("Molecules");
					break;
				case "CO3":
					SceneManager.LoadScene("Molecules");
					break;
				case "H2O":
					SceneManager.LoadScene("Molecules");
					break;
				case "HF":
					SceneManager.LoadScene("Molecules");
					break;
				case "HgCl2":
					SceneManager.LoadScene("Molecules");
					break;
				case "I3":
					SceneManager.LoadScene("Molecules");
					break;
				case "IF7":
					SceneManager.LoadScene("Molecules");
					break;
				case "NH3":
					SceneManager.LoadScene("Molecules");
					break;
				case "NO2":
					SceneManager.LoadScene("Molecules");
					break;
				case "NO3":
					SceneManager.LoadScene("Molecules");
					break;
				case "O2":
					SceneManager.LoadScene("Molecules");
					break;
				case "O3":
					SceneManager.LoadScene("Molecules");
					break;
				case "OF2":
					SceneManager.LoadScene("Molecules");
					break;
				case "PCl3":
					SceneManager.LoadScene("Molecules");
					break;
				case "PCl5":
					SceneManager.LoadScene("Molecules");
					break;
				case "PO4":
					SceneManager.LoadScene("Molecules");
					break;
				case "SF4":
					SceneManager.LoadScene("Molecules");
					break;
				case "SF6":
					SceneManager.LoadScene("Molecules");
					break;
				case "SO2":
					SceneManager.LoadScene("Molecules");
					break;
				case "SO3":
					SceneManager.LoadScene("Molecules");
					break;
				case "SO4":
					SceneManager.LoadScene("Molecules");
					break;
				case "XeF2":
					SceneManager.LoadScene("Molecules");
					break;
				case "XeF4":
					SceneManager.LoadScene("Molecules");
					break;
				case "XeF5":
					SceneManager.LoadScene("Molecules");
					break;
				case "XeF6":
					SceneManager.LoadScene("Molecules");
					break;
				case "B":
						switch (LSScene){
							case "BF3":
								SceneManager.LoadScene("BF3");
							break;
							default:
								SceneManager.LoadScene("Main");
							break;
						}
					break;
				case "Be":
						switch (LSScene){
							case "BeCl2":
								SceneManager.LoadScene("BeCl2");
							break;
							default:
								SceneManager.LoadScene("Main");
							break;
						}
					break;
				case "Br":
						switch (LSScene){
							case "BrF3":
								SceneManager.LoadScene("BrF3");
							break;
							case "BrF5":
								SceneManager.LoadScene("BrF5");
							break;
							default:
								SceneManager.LoadScene("Main");
							break;
						}
					break;
				case "C":
						switch (LSScene){
							case "CH4":
								SceneManager.LoadScene("CH4");
							break;
							case "CO2":
								SceneManager.LoadScene("CO2");
							break;
							case "CO3":
								SceneManager.LoadScene("CO3");
							break;
							default:
								SceneManager.LoadScene("Main");
							break;
						}
					break;
				case "Cl":
						switch (LSScene){
							case "BeCl2":
								SceneManager.LoadScene("BeCl2");
							break;
							case "ClF3":
								SceneManager.LoadScene("ClF3");
							break;
							case "ClF5":
								SceneManager.LoadScene("ClF5");
							break;
							case "ClO4":
								SceneManager.LoadScene("ClO4");
							break;
							case "HgCl2":
								SceneManager.LoadScene("HgCl2");
							break;
							case "PCl3":
								SceneManager.LoadScene("PCl3");
							break;
							case "PCl5":
								SceneManager.LoadScene("PCl5");
							break;
							default:
								SceneManager.LoadScene("Main");
							break;
						}
					break;
				case "F":
						switch (LSScene){
							case "BF3":
								SceneManager.LoadScene("BF3");
							break;
							case "BrF3":
								SceneManager.LoadScene("BrF3");
							break;
							case "BrF5":
								SceneManager.LoadScene("BrF5");
							break;
							case "ClF3":
								SceneManager.LoadScene("ClF3");
							break;
							case "ClF5":
								SceneManager.LoadScene("ClF5");
							break;
							case "IF7":
								SceneManager.LoadScene("IF7");
							break;
							case "OF2":
								SceneManager.LoadScene("OF2");
							break;
							case "SF4":
								SceneManager.LoadScene("SF4");
							break;
							case "SF6":
								SceneManager.LoadScene("SF6");
							break;
							case "XeF2":
								SceneManager.LoadScene("XeF2");
							break;
							case "XeF4":
								SceneManager.LoadScene("XeF4");
							break;
							case "XeF5":
								SceneManager.LoadScene("XeF5");
							break;
							case "XeF6":
								SceneManager.LoadScene("XeF6");
							break;
							default:
								SceneManager.LoadScene("Main");
							break;
						}
					break;
				case "H":
						switch (LSScene){
							case "CH4":
								SceneManager.LoadScene("CH4");
							break;
							case "H2O":
								SceneManager.LoadScene("H2O");
							break;
							case "HF":
								SceneManager.LoadScene("HF");
							break;
							case "NH3":
								SceneManager.LoadScene("NH3");
							break;
							default:
								SceneManager.LoadScene("Main");
							break;
						}
					break;
				case "Hg":
						switch (LSScene){
							case "HgCl2":
								SceneManager.LoadScene("HgCl2");
							break;
							default:
								SceneManager.LoadScene("Main");
							break;
						}
					break;
				case "I":
						switch (LSScene){
							case "I3":
								SceneManager.LoadScene("I3");
							break;
							case "IF7":
								SceneManager.LoadScene("IF7");
							break;
							default:
								SceneManager.LoadScene("Main");
							break;
						}
					break;
				case "N":
						switch (LSScene){
							case "NH3":
								SceneManager.LoadScene("NH3");
							break;
							case "NO2":
								SceneManager.LoadScene("NO2");
							break;
							case "NO3":
								SceneManager.LoadScene("NO3");
							break;
							default:
								SceneManager.LoadScene("Main");
							break;
						}
					break;
				case "O":
						switch (LSScene){
							case "ClO4":
								SceneManager.LoadScene("ClO4");
							break;
							case "CO2":
								SceneManager.LoadScene("CO2");
							break;
							case "CO3":
								SceneManager.LoadScene("CO3");
							break;
							case "H2O":
								SceneManager.LoadScene("H2O");
							break;
							case "NO2":
								SceneManager.LoadScene("NO2");
							break;
							case "NO3":
								SceneManager.LoadScene("NO3");
							break;
							case "O2":
								SceneManager.LoadScene("O2");
							break;
							case "O3":
								SceneManager.LoadScene("O3");
							break;
							case "OF2":
								SceneManager.LoadScene("OF2");
							break;
							case "PO4":
								SceneManager.LoadScene("PO4");
							break;
							case "SO2":
								SceneManager.LoadScene("SO2");
							break;
							case "SO3":
								SceneManager.LoadScene("SO3");
							break;
							case "SO4":
								SceneManager.LoadScene("SO4");
							break;
							default:
								SceneManager.LoadScene("Main");
							break;
						}
					break;
				case "P":
						switch (LSScene){
							case "PCl3":
								SceneManager.LoadScene("PCl3");
							break;
							case "PCl5":
								SceneManager.LoadScene("PCl5");
							break;
							case "PO4":
								SceneManager.LoadScene("PO4");
							break;
							default:
								SceneManager.LoadScene("Main");
							break;
						}
					break;
				case "S":
						switch (LSScene){
							case "SF4":
								SceneManager.LoadScene("SF4");
							break;
							case "SF6":
								SceneManager.LoadScene("SF6");
							break;
							case "SO2":
								SceneManager.LoadScene("SO2");
							break;
							case "SO3":
								SceneManager.LoadScene("SO3");
							break;
							case "SO4":
								SceneManager.LoadScene("SO4");
							break;
							default:
								SceneManager.LoadScene("Main");
							break;
						}
					break;
				case "Xe":
						switch (LSScene){
							case "XeF2":
								SceneManager.LoadScene("XeF2");
							break;
							case "XeF4":
								SceneManager.LoadScene("XeF4");
							break;
							case "XeF5":
								SceneManager.LoadScene("XeF5");
							break;
							case "XeF6":
								SceneManager.LoadScene("XeF6");
							break;
							default:
								SceneManager.LoadScene("Main");
							break;
						}
					break;
				default:
					SceneManager.LoadScene("Main");
					break;
			}
	
	}
	
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;
			SceneManager.LoadScene("Main");
        }
		
		if (Input.GetMouseButtonUp(0)) 
		{ 
		 EventSystem.current.SetSelectedGameObject(null); 
		} 

    }
	
	
	
	

}