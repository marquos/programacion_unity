using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour {
	public GameObject ball;
	private Vector3 diff;
	void Start () {
		this.diff = transform.position - ball.transform.position;
	}

	// Update is called once per frame
	void LateUpdate () {
		transform.position = ball.transform.position + this.diff;

	}
}
