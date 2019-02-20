using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory : MonoBehaviour
{

	public GameObject Stockpile;
	public GameObject StockpilePart;
	
	public GameObject EnemyPrefab;
	
	public GameObject EnemySpawn0;
	public GameObject EnemySpawn1;
	public GameObject EnemySpawn2;
	public GameObject EnemySpawn3;
	public GameObject EnemySpawn4;
	public GameObject EnemySpawn5;
	
	private float _spawnInterval = 2;

	private GameObject _spawnLocationObj;
	private Vector3 _spawnLocation;
	private Quaternion _spawnRotation;
	
	// Use this for initialization
	void Start ()
	{
		Invoke("SpawnEnemy", _spawnInterval);
	}

	void SpawnEnemy()
	{
		switch (Random.Range(0, 6))
		{
			case 0:
				_spawnLocationObj = EnemySpawn0;
				_spawnLocation = EnemySpawn0.transform.position;
				_spawnRotation = EnemySpawn0.transform.rotation;
				break;
			case 1:
				_spawnLocationObj = EnemySpawn1;
				_spawnLocation = EnemySpawn1.transform.position;
				_spawnRotation = EnemySpawn1.transform.rotation;
				break;
			case 2:
				_spawnLocationObj = EnemySpawn2;
				_spawnLocation = EnemySpawn2.transform.position;
				_spawnRotation = EnemySpawn2.transform.rotation;
				break;
			case 3:
				_spawnLocationObj = EnemySpawn3;
				_spawnLocation = EnemySpawn3.transform.position;
				_spawnRotation = EnemySpawn3.transform.rotation;
				break;
			case 4:
				_spawnLocationObj = EnemySpawn4;
				_spawnLocation = EnemySpawn4.transform.position;
				_spawnRotation = EnemySpawn4.transform.rotation;
				break;
			case 5:
				_spawnLocationObj = EnemySpawn5;
				_spawnLocation = EnemySpawn5.transform.position;
				_spawnRotation = EnemySpawn5.transform.rotation;
				break;
		}
			
		GameObject newEnemy = (GameObject)Instantiate(EnemyPrefab, _spawnLocation, _spawnRotation);
		//newEnemy.transform.SetParent(gameObject.transform);
		newEnemy.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
		newEnemy.GetComponent<Enemy>().Escape = _spawnLocationObj;
		newEnemy.GetComponent<Enemy>().Stockpile = Stockpile;
		newEnemy.GetComponent<Enemy>().StockpilePart = StockpilePart;

		_spawnInterval -= 0.01f;
		
		// Restart spawn timer
		Invoke("SpawnEnemy", _spawnInterval);
	}
}
