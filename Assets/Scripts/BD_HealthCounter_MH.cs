using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HealthCounter : MonoBehaviour
{
    
    public TextMeshProUGUI healthCounterUI;
    public string healthCounter;
    public string tempText;

    public int LineCount;
    public int LineCountMax;

    public float damage;

    public float HP = 5;
    public float maxHP = 5;

    public Text displayText;


    // Start is called before the first frame update
    void Start()
    {
        healthCounter = "" + maxHP;
        UpdateText(healthCounter);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

/*
    public void Combat()
    {
        damage = 1;
        HP -= damage;
        tempText = "" + HP + "/" + maxHP;
       // myText += tempText;
        UpdateText(tempText);
    }
*/

    public void UpdateText(string newHealth)
    {
        //displayText.text = myText;
        healthCounterUI.text = "" + newHealth + "/" + maxHP;
    }
}