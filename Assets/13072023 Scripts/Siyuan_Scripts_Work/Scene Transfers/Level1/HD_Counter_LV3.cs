using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HD_Counter_LV3 : MonoBehaviour
{
    public Transfer3toQuit checkHD;
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

            checkHD.counter_HD = checkHD.counter_HD + 1;

            Destroy(this.gameObject);
        }
        
    }
}
