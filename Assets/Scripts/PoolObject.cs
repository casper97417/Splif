using UnityEngine;
using System.Collections;

public class PoolObject : MonoBehaviour {
	public float createTime = 2f;

	public float Time = 500f;

	public float ReducTime = 500f;



	void create (){

		GameObject obj = NewObjectPooler.current.GetPooledObject();

		if (obj == null)
			return;

		obj.transform.position = new Vector3 (15, -2, -4);
		obj.transform.rotation = transform.rotation;
		obj.SetActive (true);

		createTime = 10f;





	}

	// Update is called once per frame
	void Update () {

	
		Time++;

		if (Time >= 1000) {

			Invoke ("create", 0f);
			Time = Random.Range (ReducTime, 950);
		}

		if (ReducTime < 850) {
			ReducTime = ReducTime + 0.1f;
		}

	}

}
