using UnityEngine;
using System.Collections;

public class AndroidControls : MonoBehaviour {

	public static bool left ;
	public static bool right;
	public static bool jump;

	public GameObject[] Personnages;

	public int ChoosePersonnage;

	void Start () {
		left = false;
		right = false;
		jump = false;

		ChoosePersonnage = PlayerPrefs.GetInt ("RealChoice");

		if (ChoosePersonnage == 0) {
			Instantiate (Personnages [0], new Vector3 (-7f, -1f, -4f), Quaternion.identity);
		}
		if (ChoosePersonnage == 1) {
			Instantiate (Personnages [1], new Vector3 (-9.5f, -1f, -4f), Quaternion.identity);
		}
		if (ChoosePersonnage == 2) {
			Instantiate (Personnages [2], new Vector3 (-9.5f, -1f, -4f), Quaternion.identity);
		}
		if (ChoosePersonnage == 3) {
			Instantiate (Personnages [3], new Vector3 (-9.5f, -1f, -4f), Quaternion.identity);
		}
		if (ChoosePersonnage == 4) {
			Instantiate (Personnages [4], new Vector3 (-9.5f, -1f, -4f), Quaternion.identity);
		}
		if (ChoosePersonnage == 5) {
			Instantiate (Personnages [5], new Vector3 (-9.5f, -1f, -4f), Quaternion.identity);
		}
		if (ChoosePersonnage == 6) {
			Instantiate (Personnages [6], new Vector3 (-9.5f, -1f, -4f), Quaternion.identity);
		}
		if (ChoosePersonnage == 7) {
			Instantiate (Personnages [7], new Vector3 (-9.5f, -1f, -4f), Quaternion.identity);
		}
		if (ChoosePersonnage == 8) {
			Instantiate (Personnages [8], new Vector3 (-9.5f, -1f, -4f), Quaternion.identity);
		}
		if (ChoosePersonnage == 9) {
			Instantiate (Personnages [9], new Vector3 (-9.5f, -1f, -4f), Quaternion.identity);
		}
		if (ChoosePersonnage == 10) {
			Instantiate (Personnages [10], new Vector3 (-9.5f, -1f, -4f), Quaternion.identity);
		}


	}


	public void leftButton(){
		left = true;

	}

	public void EndleftButton(){
		left = false;

	}

	public void RightButton(){
		right = true;

	}

	public void EndRightButton(){
		right = false;

	}

	public void Jumping(){
		jump = true;
	}

	public void UnJumping(){
		jump = false;
	}
}
