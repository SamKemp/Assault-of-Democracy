using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillSelf : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
		Destroy(gameObject, 2);
	}
}
