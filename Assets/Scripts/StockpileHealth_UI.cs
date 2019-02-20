using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StockpileHealth_UI : MonoBehaviour
{
    public string Text = "Stockpile Health: ";
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Text>().text = Text + GlobalVariables.StockpileHealth + "/" + GlobalVariables.StockpileMaxHealth;
    }
}
