using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BD_Player_MH : MonoBehaviour
{
    [SerializeField]
    public float moveSpeed = 5f;
    //create a list for the weapons
   
    // Update is called once per frame
    void Update()
    {
        DetectInput();  
    }

    void MovePlayer()
    {
       
    }

    void DetectInput() 
    {
        if (Input.GetKey(KeyCode.W) == true) 
        {
            this.transform.position += this.transform.forward * moveSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S) == true) 
        {
            this.transform.position -= this.transform.forward * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A) == true) 
        {
            this.transform.position -= this.transform.right * moveSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D) == true) 
        {
            this.transform.position += this.transform.right * moveSpeed * Time.deltaTime;
        }

        // when 1 is pressed it swaps to the sword
        if (Input.GetMouseButtonDown(0) == true)
        {
            Debug.Log("sword");
        }
        // when 2 is pressed it swaps to the bow
        else if (Input.GetKeyDown("2") == true)
        {
            Debug.Log("bow");
        }
        // when 3 is pressed it swaps to the spell
        else if (Input.GetKeyDown("3") == true)
        {
            Debug.Log("spell");
        }
    }
}

