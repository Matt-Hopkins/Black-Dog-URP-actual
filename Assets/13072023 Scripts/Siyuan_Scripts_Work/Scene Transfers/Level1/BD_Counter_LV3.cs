using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BD_Counter_LV3 : MonoBehaviour
{
    public Transfer3toQuit checkBD;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Sword")
        {
            Debug.Log ("The enemy hit the the sword");

            checkBD.counter_BD = checkBD.counter_BD + 1;

            Destroy(this.gameObject);
        }
        
    }

}
