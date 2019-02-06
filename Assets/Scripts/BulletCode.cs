using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCode : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
		Destroy(gameObject, 5);
		//Invoke("AddGravity", 3);
	}
	
	// Update is called once per frame
	void Update ()
	{
		this.GetComponent<Rigidbody>().AddForce(transform.forward * 10);
	}

	void AddGravity()
	{
		this.GetComponent<Rigidbody>().useGravity = true;
	}
}