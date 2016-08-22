using UnityEngine;
using System.Collections;

public class MoveEnnemy : MonoBehaviour {



	private float speed;

	// Use this for initialization
	void Start () {
		speed = Random.Range (3f, 17f);

	}
	
	// Update is called once per frame
	void Update () {

		this.transform.Translate (Vector3.left * speed * Time.deltaTime);
	
	}



}
