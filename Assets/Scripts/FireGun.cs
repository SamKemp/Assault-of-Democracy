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

	private int _bullets = 100;
	private int _initialBullets;

	private bool _automatic = false;
	public bool BulletsMatter = false;
	
	// Use this for initialization
	void Start ()
	{
		_initialBullets = _bullets;
	}

	// Update is called once per frame
	void Update ()
	{
		if (_automatic)
		{
			if (Input.GetButton("Button Fire"))
			{
				FireBullet();
			}
		}
		else
		{
			if (Input.GetButtonDown("Button Fire"))
			{
				FireBullet();
			}
		}
		
		if (Input.GetButtonDown("Button Auto"))
		{
			_automatic = !_automatic;
		}
		
		if (Input.GetButtonDown("Button Reload"))
		{
			_bullets = _initialBullets;
		}

		AmmoCount.GetComponent<TextMesh>().text = _bullets.ToString();
	}

	void FireBullet()
	{
		if(_bullets > 0)
		{
			if(BulletsMatter)
				_bullets--;
	
			GameObject bullet = (GameObject)Instantiate(BulletPrefab, BulletSpawn.position, BulletSpawn.rotation);
			bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 10;
		}
	}
}