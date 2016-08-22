using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PauseButton : MonoBehaviour {

	public GameObject[] obj;
	public static Vector3 posx;
	public static Vector3 posx2;

	public float inch;

	void Start(){
		obj [0].SetActive (true);
		obj [1].SetActive (false);
		obj [2].SetActive (false);
		obj [3].SetActive (false);
		obj [4].SetActive (false);
		Time.timeScale = 1;
		PlayerController.Score = true;
		PlayerController.IsDead = false;

		inch = Mathf.Sqrt (Screen.width / Screen.dpi);





	}



	// Use this for initialization
	public void Pause(){
		
		Time.timeScale = 0;
		obj[0].SetActive (false);
		obj [1].SetActive (true);
		obj [2].SetActive (true);
		obj [3].SetActive (true);
		PlayerController.Score = false;


	}

	public void Play(){
		Time.timeScale = 1;
		obj[1].SetActive (false);
		obj [0].SetActive (true);
		obj [2].SetActive (false);
		obj [3].SetActive (false);
		PlayerController.Score = true;

	}

	public void Quit(){

		SceneManager.LoadScene (0, LoadSceneMode.Single);
		
	}

	void Update(){
		if (PlayerController.IsDead) {
			obj[0].SetActive (false);
			obj [1].SetActive (false);
			obj [2].SetActive (true);
			obj [3].SetActive (true);
			obj [4].SetActive (true);
		}
		Camera camera = GetComponent<Camera> ();
		posx = camera.ScreenToWorldPoint(new Vector3(inch - inch + 30,Screen.height/5, camera.nearClipPlane));
		posx2 = camera.ScreenToWorldPoint(new Vector3(Screen.width -30, Screen.height/5, camera.nearClipPlane));

	}
}
