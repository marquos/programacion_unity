using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {

	public float speed;
	private Rigidbody rb;
	public int counter;
	public int isJumping;
	private int numMaxSaltos;

	// Use this for initialization
	void Start () {
		this.counter = 0;
		this.rb = GetComponent<Rigidbody>();
		this.speed = 15;
	}


	void FixedUpdate () {
		float horizontalAxis = Input.GetAxis("Horizontal");
		float verticalAxis = Input.GetAxis("Vertical");
		Vector3 movement = new Vector3(horizontalAxis, 0.0f,verticalAxis);
		rb.AddForce(movement*speed);

		if (Input.GetKeyDown ("space") && numMaxSaltos > 0) {
			Vector3 jumpForce = new Vector3 (0.0f, 10.0f, 0.0f);
			rb.AddForce (jumpForce, ForceMode.Impulse);
			numMaxSaltos--;

		}
	} 
	void OnCollisionEnter (Collision c){
		this.numMaxSaltos = 1;
		if (c.gameObject.tag == "Pickable"){
			c.gameObject.SetActive (false);
		}
	}
	void OnTriggerEnter (Collision c){
		if (c.gameObject.tag == "Pickable") {
			c.gameObject.SetActive (false);
		}
	}
	public void sumCounter(){
		counter++;
		Debug.Log ("Counter" + counter);
	}
}