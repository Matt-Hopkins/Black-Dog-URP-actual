using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BD_CS_Stun_SS : MonoBehaviour
{
    public BD_CS_Enemy_AI stunBullet;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "StunBullet")
        {
            Debug.Log("The enemy been freezed");

            stunBullet.stunTimmer = 0.1f;

        }

    }
}
