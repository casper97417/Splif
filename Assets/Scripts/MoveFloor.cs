using UnityEngine;
using System.Collections;

public class MoveFloor : MonoBehaviour {

	public static float speed = 6.5f;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {




		this.transform.Translate (Vector3.left * Time.deltaTime * speed);

		if (this.transform.position.x == -100) {
			this.gameObject.SetActive (false);
		}
	
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "Wall") {
			this.transform.position = new Vector3 (29, -4, -4);

		

		}

		if (col.gameObject.tag == "Wall" && this.gameObject.tag == "Dos") {
			this.gameObject.SetActive (false);
		}
	}
}
