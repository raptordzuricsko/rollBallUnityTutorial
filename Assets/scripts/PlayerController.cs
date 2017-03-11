using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	private Rigidbody rb;

	public float speed;
	//called on first frame script is active
	void Start(){
		rb = GetComponent<Rigidbody> ();
	}

	//not physics
//	void Update(){
//
//	}

	//Physics
	void FixedUpdate(){
		//Input used to get user input
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		//simplest rigidbody
		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
		rb.AddForce(movement * speed);// + does not work!
	}
		
}
