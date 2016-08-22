using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CanabisScore : MonoBehaviour {

	public static float Feuilles;
	public static int MemoryFeuilles;

	Text text;

	// Use this for initialization
	void Awake () {
		text = GetComponent<Text> ();
		MemoryFeuilles = PlayerPrefs.GetInt ("Feuilles");

		Feuilles = 0;
	}

	// Update is called once per frame
	void Update () {


		text.text = "X "+Feuilles;

	}
}
