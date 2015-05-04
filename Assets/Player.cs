using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	public float forwardSpeed;
	public float reverseSpeed;
	public float turningSpeed;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("a"))
		{
			transform.Rotate(Vector3.forward * (Time.deltaTime * turningSpeed));
		}
		
		if (Input.GetKey("d"))
		{
			transform.Rotate(Vector3.forward * -(Time.deltaTime * turningSpeed));
		}
		
		if (Input.GetKey("w"))
		{
			// transform.Translate(Vector3.up * (Time.deltaTime * (forwardSpeed)));
			// GetComponent<Rigidbody>().AddForce(transform.up * 8);
			GetComponent<Rigidbody>().AddForce(transform.up * 8);
		}
		
		if (Input.GetKey("s"))
		{
			// transform.Translate(Vector3.up * -(Time.deltaTime * (reverseSpeed)));
			GetComponent<Rigidbody>().AddForce(transform.up * -8);
		}
		
		
	}
}
