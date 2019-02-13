using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class BulletCode : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
		Destroy(gameObject, 5);
	}
	
	// Update is called once per frame
	void Update ()
	{
		this.GetComponent<Rigidbody>().AddForce(transform.forward * 10);
	}
	
	void OnCollisionEnter(Collision collision)
	{
		Debug.Log("Bullet collided");
		Destroy(gameObject);
		if (collision.gameObject.CompareTag("killable"))
		{
			Destroy(collision.gameObject);
		}
	}
}