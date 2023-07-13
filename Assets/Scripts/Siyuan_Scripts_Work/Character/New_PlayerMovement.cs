using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class New_PlayerMovement : MonoBehaviour
{
    [SerializeField]
    public float moveSpeed = 5f;

    void Start()
    {
        
    }

    void Update()
    {
        movementInput();
    }

    void movementInput()
    {
        float _horizontal = Input.GetAxis("Horizontal");
        float _vertical = Input.GetAxis("Vertical");

        Vector3 _movement = new Vector3(_horizontal, 0, _vertical);
        transform.Translate(_movement * -1 * moveSpeed * Time.deltaTime, Space.World);
    }
}
