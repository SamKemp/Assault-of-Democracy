using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.XR;

public class ifVR : MonoBehaviour
{
	public bool VrEnabled;

	public GameObject VRCamera;
	public GameObject Camera;

	// Use this for initialization
	void Start ()
	{
		XRSettings.enabled = VrEnabled;

		if (XRSettings.enabled)
		{
			Camera.SetActive(false);
			VRCamera.SetActive(true);
		}
		else
		{
			Camera.SetActive(true);
			VRCamera.SetActive(false);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
