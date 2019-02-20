using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stockpile : MonoBehaviour
{

    private GameObject _stockpileObj;
    
    // Start is called before the first frame update
    void Start()
    {
        _stockpileObj = transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (GlobalVariables.StockpileHealth == 0)
        {
            Time.timeScale = 0.0f;
        }
    }
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("killable"))
        {
            GlobalVariables.StockpileHealth -= 10;
            _stockpileObj.transform.position = new Vector3(0, _stockpileObj.transform.position.y -0.05f, 0);
            
            collision.gameObject.SendMessage("HitStockpile");
        }
    }
}