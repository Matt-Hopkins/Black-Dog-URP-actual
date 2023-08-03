using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WW_Counter_LV3 : MonoBehaviour
{
    public int HP;
    public float damageCooler;
    public int damageCoolingTimeLength = 1;
    public Transfer3toQuit checkWW;
    
    void Start()
    {
        HP = 5;
        damageCooler = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (HP == 0)
        {
            Destroy(this.gameObject);

            checkWW.counter_WW = checkWW.counter_WW + 1;
        }

        if (damageCooler >= 0.1f)
        {
            damageCooler += Time.deltaTime;
        }

        if (damageCooler >= damageCoolingTimeLength)
        {
          damageCooler = 0;
        } 
    }

     void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Sword")
        {
            Debug.Log ("The enemy hit the the sword");

            HP = HP - 1;
            damageCooler = 0.1f;
        }
        
    }
}
