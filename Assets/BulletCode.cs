using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCode : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
		Destroy(gameObject, 5);
		Invoke("AddGravity", 2);
	}
	
	// Update is called once per frame
	void Update ()
	{
		this.GetComponent<Rigidbody>().AddForce(transform.forward * 5);
	}

	void AddGravity()
	{
		this.GetComponent<Rigidbody>().useGravity = true;
	}
}
