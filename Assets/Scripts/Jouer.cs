using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Jouer : MonoBehaviour {

	public static AsyncOperation Personnages;
	public static AsyncOperation Gamez;

	public GameObject MainMenu;
	public GameObject Loading;
	public GameObject Play;



	public void LoadLevel(){
		Gamez = SceneManager.LoadSceneAsync (1, LoadSceneMode.Single);
		if (Gamez.progress <= 1f){
			MainMenu.SetActive (false);
			Loading.SetActive (true);
			Play.SetActive (false);
		}
	}

	public void ChoosePersonnage(){
		
		Personnages = SceneManager.LoadSceneAsync(2, LoadSceneMode.Single);
		if (Personnages.progress <= 1f){
			MainMenu.SetActive (false);
			Loading.SetActive (true);
			Play.SetActive (false);
		}
	}

	void Start(){
		

		MainMenu.SetActive (true);
		Loading.SetActive (false);
		Play.SetActive (true);

	}

	public void Quit(){
		Application.Quit ();
	}


		
}
