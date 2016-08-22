using UnityEngine;
using System.Collections;

public class MooveFeuille : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		this.transform.Translate (Vector3.left * 2f * Time.deltaTime);
	
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "Player") {
			this.gameObject.SetActive (false);

		}
	}
}
