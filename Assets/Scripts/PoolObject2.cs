using UnityEngine;
using System.Collections;

public class PoolObject2 : MonoBehaviour {
	public float createTime = 2f;

	public float Time = 500f;




	void create (){

		GameObject obj = NewObjectPool2.current.GetPooledObject();

		if (obj == null)
			return;

		obj.transform.position = new Vector3 (15, Random.Range(-2f,0.5f), -4);
		obj.transform.rotation = transform.rotation;
		obj.SetActive (true);

		createTime = 10f;





	}

	// Update is called once per frame
	void Update () {


		Time++;

		if (Time >= 1000) {

			Invoke ("create", 0f);
			Time = Random.Range (200, 900);
		}



	}
}
