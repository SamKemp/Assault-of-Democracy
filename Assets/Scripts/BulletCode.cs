using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Random = UnityEngine.Random;

public class BulletCode : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
		Destroy(gameObject, 5);
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		this.GetComponent<Rigidbody>().AddForce(transform.forward);
	}
	
	void OnCollisionEnter(Collision collision)
	{
		Destroy(gameObject);

		if (collision.gameObject.CompareTag("killable"))
		{
			collision.gameObject.SendMessage("Hit");
		}
	}
}