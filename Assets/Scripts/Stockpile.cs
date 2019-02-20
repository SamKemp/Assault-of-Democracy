using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stockpile : MonoBehaviour
{
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
        Debug.Log("Stockpile collision");

        GlobalVariables.StockpileHealth =- 10;

        if (collision.gameObject.CompareTag("killable"))
        {
            collision.gameObject.SendMessage("HitStockpile");
        }
    }
}
