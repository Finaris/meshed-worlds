using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player_Controller : MonoBehaviour {

	public float speed; //will now show up in inspector
	private Rigidbody rb;  // holds rigid body reference

	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	void FixedUpdate ()  //used for physics
	{
		Vector2 move = Input.mousePosition;
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 ((1300 - move.x) / 300, 0.0f, (move.y - 740)/300);
		print (move);

		rb.AddForce (movement * speed);
	}


	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Pick Up")) 
		{
			other.gameObject.SetActive(false);

		}

	}
}
