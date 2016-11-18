using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;

	private Vector3 offset;
	// Use this for initialization
	void Start () {

		offset = transform.position - player.transform.position;   //this gives the difference between camera and player position
	
	}
	
	// LateUpdate is called once per frame
	void LateUpdate () {   //LateUpdate is guaranteeed to run after everything else has been done in that frame
		transform.position = player.transform.position + offset;  //as player moves camera is moved to align with player object
	}
}
