using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player_Controller : MonoBehaviour {

	public float speed = 1.0F; //will now show up in inspector
	private Rigidbody rb;  // holds rigid body reference
	float[] array3D = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0};

	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	void FixedUpdate ()  //used for physics
	{
		array3D [0] = Time.deltaTime;
		Vector3 dir = Vector3.zero;
		array3D [1] = Input.acceleration.x;
		array3D [2] = Input.acceleration.y;
		array3D [3] = Input.acceleration.z;
		array3D [4] = array3D [1] * array3D [0] + array3D [4];
		array3D [5] = array3D [2] * array3D [0] + array3D [5];
		array3D [6] = array3D [3] * array3D [0] + array3D [6];
		array3D [7] = array3D [4] * array3D [0] + array3D [7];
		array3D [8] = array3D [5] * array3D [0] + array3D [8];
		array3D [9] = array3D [6] * array3D [0] + array3D [9];

		dir.x = -array3D [7];
		dir.y = 0;
		dir.z = array3D [8];

		if (dir.sqrMagnitude > 1)
			dir.Normalize();

		Vector2 move = Input.mousePosition;
		Vector3 movement = new Vector3 ((1300 - move.x) / 300, 0.0f, (move.y - 740)/300);

		rb.AddForce (movement * speed);

		//rb.transform.Translate (0, 0, -Input.acceleration.z);
		//Input.acceleration.x

	}
		
	/*Vector2 move = Input.mousePosition;
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 ((1300 - move.x) / 300, 0.0f, (move.y - 740)/300);
		print (move);

		rb.AddForce (movement * speed);*/

}
