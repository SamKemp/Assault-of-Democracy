using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class FireGun : MonoBehaviour
{

	public GameObject BulletPrefab;
	public Transform BulletSpawn;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.Mouse0))
		{
			GameObject bullet = (GameObject)Instantiate(BulletPrefab, BulletSpawn.position, BulletSpawn.rotation);

			bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 5;
		}
	}
}
