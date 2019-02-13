using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnDummy : MonoBehaviour
{
	public GameObject TestDummyPrefab;
	
	// Update is called once per frame
	void Update ()
	{
		if (!this.transform.childCount.Equals(1))
		{
			GameObject testDummy = (GameObject)Instantiate(TestDummyPrefab, this.transform.position, this.transform.rotation);
			testDummy.transform.parent = gameObject.transform;
			//testDummy.transform.position = new Vector3(0, 0, 0);
			//testDummy.transform.rotation = new Quaternion(180, 180, 180, 1);
			testDummy.transform.localScale = new Vector3(1, 1, 1);
			
			Debug.Log("Created new dummy");
		}
	}
}
