using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Enemy : MonoBehaviour
{
	private bool _hitStockPile = false;

	public GameObject Stockpile;

	public GameObject Escape;
	
	private int _health = 100;

	// Use this for initialization
	void Start ()
	{
		Stockpile = GameObject.Find("EnemyMoveTowards");
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(_hitStockPile)
		{
			transform.position = Vector3.MoveTowards(transform.position, Escape.transform.position, Time.deltaTime * 1.5f);
		}
		else
		{
			transform.position = Vector3.MoveTowards(transform.position, Stockpile.transform.position, Time.deltaTime * 1.5f);
		}
		
		if (_health <= 0)
		{
			this.transform.parent = null;

			foreach (Transform t in this.transform)
			{
				//t.parent = GameObject.Find("BodyParts-Storage").transform;
				t.parent = null;
				t.gameObject.AddComponent<KillSelf>();
				t.gameObject.AddComponent<BoxCollider>();
				t.gameObject.AddComponent<Rigidbody>().useGravity = true;
			}
			
			//GameObject deadDummy = (GameObject)Instantiate(TestDummyDeath, this.transform.position, this.transform.rotation);
			//deadDummy.transform.localScale = this.transform.localScale;
			Destroy(gameObject);
		}
	}

	void Hit()
	{
		_health -= 10;
		Debug.Log(gameObject.name + " got shot | " + _health);
	}
	
	void HitSword()
	{
		_health = 0;
		Debug.Log(gameObject.name + " got sworded | " + _health);
	}

	void HitStockpile()
	{
		_hitStockPile = true;
	}
}
