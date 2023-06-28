using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BD_Combat_MH : MonoBehaviour
{
    public int biteDamage = 1;

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("The enemy collided with the player!");

            if (collision.gameObject.GetComponent<Health>() == true)
            {
                collision.gameObject.GetComponent<Health>().TakeDamage(biteDamage);
            }
        }

    }

}
