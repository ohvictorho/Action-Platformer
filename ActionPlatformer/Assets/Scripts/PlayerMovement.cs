using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float speed = 10.0F;

	// Use this for initialization
	void Start ()
	{
		Cursor.lockState = CursorLockMode.Locked;
	}

	// Update is called once per frame
	void Update () {

		float Translation = Input.GetAxis ("Vertical") * speed;
		float straffe = Input.GetAxis("Horizontal") * speed;
		Translation *= Time.deltaTime;
		straffe *= Time.deltaTime;

		transform.Translate (straffe, 0, Translation);

		if (Input.GetKeyDown("escape"))
			Cursor.lockState = CursorLockMode.None;
	}
}