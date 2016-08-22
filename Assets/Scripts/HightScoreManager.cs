using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HightScoreManager : MonoBehaviour {
	public static float HightScore;

	Text text;

	// Use this for initialization
	void Awake () {
		text = GetComponent<Text> ();


		HightScore = PlayerPrefs.GetFloat ("HS");
	}

	// Update is called once per frame
	void Update () {

			text.text ="Meilleur : "+ Mathf.Round (HightScore) + " m";

		if (PlayerController.IsDead == true) {
			HightScore = PlayerPrefs.GetFloat ("HS");
		}
		

	}
}
