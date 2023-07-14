using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BD_Weapon_SS : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log ("The enemy hit the the sword");

            Destroy (collision.gameObject);
        }
    }
}
