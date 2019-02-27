using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Enemy : MonoBehaviour
{
	private bool _hitStockPile = false;

	public GameObject StockpilePart;

	public GameObject Stockpile;
	
	public GameObject MoveTowards;

	public GameObject Escape;
	
	private int _health = 0;

	// Use this for initialization
	void Start ()
	{
		MoveTowards = GameObject.Find("EnemyMoveTowards");
	}
	
	// Fixed Update is called once per fixed frame
	void FixedUpdate()
	{
		//NOOP
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(_hitStockPile)
		{
			transform.position = Vector3.MoveTowards(transform.position, Escape.transform.position, Time.deltaTime * 1.5f);
			transform.LookAt(Escape.transform);
			transform.eulerAngles = new Vector3(90, transform.eulerAngles.y, transform.eulerAngles.z);
		}
		else
		{
			transform.position = Vector3.MoveTowards(transform.position, MoveTowards.transform.position, Time.deltaTime * 1.5f);
			transform.LookAt(MoveTowards.transform);
			transform.eulerAngles = new Vector3(90, transform.eulerAngles.y, transform.eulerAngles.z);
		}
		
		if (_health <= 0)
		{
			this.transform.parent = null;
			
			if(_hitStockPile)
			{
				GameObject newStockpilePart = (GameObject)Instantiate(StockpilePart, this.transform.position, this.transform.rotation);
				newStockpilePart.GetComponent<StockpilePart>().Stockpile = Stockpile;
				newStockpilePart.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
			}

			foreach (Transform t in this.transform)
			{
				t.parent = null;
				t.gameObject.AddComponent<KillSelf>();
				t.gameObject.AddComponent<BoxCollider>();
				t.gameObject.AddComponent<Rigidbody>().useGravity = true;
			}

			Destroy(gameObject);
		}
	}

	void Hit()
	{
		_health -= 10;
	}
	
	void HitSword()
	{
		_health = 0;
	}

	void HitStockpile()
	{
		_hitStockPile = true;
	}
}
