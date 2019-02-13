using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordStab : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //transform.position = new Vector3(transform.parent.position.x - 0.023f, transform.parent.position.y, transform.parent.position.z + 0.212f);
    }
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("killable"))
        {
            collision.gameObject.SendMessage("HitSword");
        }
    }
}
