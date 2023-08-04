using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BD_CS_Counter_Lv3 : MonoBehaviour
{
    //public Transfer1o2 checkCS;

    void Start()
    {

    }

    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Sword")
        {
            Debug.Log("The enemy hit the the sword");

           // checkCS.counter_CS = checkCS.counter_CS + 1;

            Destroy(this.gameObject);
        }

    }
}
