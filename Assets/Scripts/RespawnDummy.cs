using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnDummy : MonoBehaviour
{
	public GameObject TestDummyPrefab;
	
	private int _childcount = 0;

	void Start()
	{
		_childcount = this.transform.childCount;
		Invoke("CheckChildren", 5);
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (_childcount.Equals(0))
		{
			_childcount++;
			
			GameObject testDummy = (GameObject)Instantiate(TestDummyPrefab, this.transform.position, this.transform.rotation);
			testDummy.transform.SetParent(gameObject.transform);
			testDummy.transform.localScale = new Vector3(1, 1, 1);
			testDummy.GetComponent<Enemy>().Dummy = true;
			
			Debug.Log("Created new dummy");
		}
	}

	void CheckChildren()
	{
		_childcount = this.transform.childCount;
		Invoke("CheckChildren", 5);
	}
}
