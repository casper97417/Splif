using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NewObjectPool2 : MonoBehaviour {
	public static NewObjectPool2 current;
	public GameObject PooledObject;
	public int PooledAmount = 10;
	public bool WillGrow = true;

	public List<GameObject> PooledObjects;


	void Awake(){
		current = this;
	}


	void Start () {

		PooledObjects = new List<GameObject> ();
		for (int i = 0; i < PooledAmount; i++) {
			GameObject obj = (GameObject)Instantiate (PooledObject);
			obj.SetActive (false);
			PooledObjects.Add (obj);
		}

	}

	public GameObject GetPooledObject(){
		for (int i = 0; i < PooledObjects.Count; i++) {
			if (!PooledObjects [i].activeInHierarchy) {
				return PooledObjects [i];
			}
		}

		if (WillGrow) {
			GameObject obj = (GameObject)Instantiate (PooledObject);
			PooledObjects.Add (obj);
			return obj;
		}

		return null;
	}
}
