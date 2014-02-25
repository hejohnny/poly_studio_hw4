using UnityEngine;
using System.Collections;

public class rigid_behavior : MonoBehaviour {
	//public variables are exposed in the inspector
	public Transform capsulePlayer;
	public float speed = 10f;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Rigidbody controller = GetComponent<Rigidbody>();
		//if (player presses W)
		//	then move forward (google transform.forward)

		if (Input.GetKey (KeyCode.W)) {
			controller.AddForce(0,11,0);
			controller.velocity += speed * transform.forward * Time.deltaTime ;
		}
		//if (player presses S)then move backward

		if (Input.GetKey (KeyCode.A)) {
			controller.AddForce(10,0,0);
			controller.velocity -= speed * transform.forward * Time.deltaTime ;
		}
		//if (player presses S)turn left (google transform.right)

		if (Input.GetKey (KeyCode.S)) {
			controller.AddForce(0,0,10);
			controller.velocity += speed * transform.right * Time.deltaTime ;
		}
		//if (player presses A)then turn right
		if (Input.GetKey (KeyCode.D)) {
			controller.AddForce(0,0,10);
			controller.velocity -= speed * transform.right * Time.deltaTime ;
		}

		if (Input.GetKeyDown(KeyCode.Space)) {

		}
	}
}
