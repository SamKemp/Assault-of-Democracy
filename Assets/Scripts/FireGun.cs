using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using Valve.VR;

public class FireGun : MonoBehaviour
{

	public GameObject BulletPrefab;
	public Transform BulletSpawn;
	public GameObject AmmoCount;

	private int _bullets = 30;
	private int _initialBullets;
	
	// Use this for initialization
	void Start ()
	{
		_initialBullets = _bullets;		
	}

	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey(KeyCode.Mouse0));
		{
			//if(_bullets > 0)
			{
				//_bullets--;

				//GameObject bullet = (GameObject)Instantiate(BulletPrefab, BulletSpawn.position, BulletSpawn.rotation);
				//bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 10;
			}
		}
		if (Input.GetKeyDown(KeyCode.R))
		{
			_bullets = _initialBullets;
		}

		AmmoCount.GetComponent<TextMesh>().text = _bullets.ToString();
	}
}