using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CanaMainMenu : MonoBehaviour {

	public static int MemoryFeuilles;

	Text text;

	// Use this for initialization
	void Awake () {
		text = GetComponent<Text> ();

	}

	// Update is called once per frame
	void Update () {


		text.text = "X "+PlayerPrefs.GetInt ("Feuilles");

	}
}
