using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickable : MonoBehaviour {

	public GameObject myObject;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider c){

		if (c.gameObject.tag == "Player") {

			myObject.SetActive (false);

			ball bc = c.gameObject.GetComponent<ball> ();
			if (bc == null) {
				Debug.Log ("Error, component ball no encontrado");
			} else {
				bc.sumCounter ();		
			}
		}
	}
}
