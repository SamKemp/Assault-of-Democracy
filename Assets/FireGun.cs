using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class FireGun : MonoBehaviour
{

	public GameObject BulletPrefab;
	public Transform BulletSpawn;
	public GameObject AmmoCount;

	private int Bullets = 10;
	private int initialBullets;
	
	// Use this for initialization
	void Start ()
	{
		initialBullets = Bullets;		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.Mouse0))
		{
			if(Bullets > 0)
			{
				Bullets--;

				GameObject bullet = (GameObject)Instantiate(BulletPrefab, BulletSpawn.position, BulletSpawn.rotation);
				bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 10;
			}
		}
		if (Input.GetKeyDown(KeyCode.R))
		{
			Bullets = initialBullets;
		}

		AmmoCount.GetComponent<TextMesh>().text = Bullets.ToString();
	}
}