using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StockpilePart : MonoBehaviour
{
    public GameObject Stockpile;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            Destroy(gameObject);
            Stockpile.SendMessage("PartRecovered");
            
        }
    }
}
