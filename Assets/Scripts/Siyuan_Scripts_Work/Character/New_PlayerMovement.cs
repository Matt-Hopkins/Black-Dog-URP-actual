using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class New_PlayerMovement : MonoBehaviour
{
    [SerializeField]
    public float moveSpeed = 5f;
    public float moveSpeed1;
    public float moveSpeed2;
    public float speedUpTimer;
    public float speedUpPeriod = 1f;
    public float speedUpCoolingTime = 3f;

    void Start()
    {
        speedUpTimer = 0;
        moveSpeed1 = moveSpeed;
        moveSpeed2 = 2f * moveSpeed;
    }

    void Update()
    {
        movementInput();
    }

    void movementInput()
    {
        float _horizontal = Input.GetAxis("Horizontal");
        float _vertical = Input.GetAxis("Vertical");

        SpeedUpFunction();

        Vector3 _movement = new Vector3(_horizontal, 0, _vertical);
        transform.Translate(_movement * -1 * moveSpeed * Time.deltaTime, Space.World);
    }

    void SpeedUpFunction()
    {
        if (Input.GetKeyDown("space") && speedUpTimer == 0)
        {
            speedUpTimer += Time.deltaTime;
            moveSpeed = moveSpeed2;
        }
        else
        {

        }

        if (speedUpTimer <= speedUpPeriod && speedUpTimer > 0)
        {
            speedUpTimer += Time.deltaTime;
        }
        else
        {

        }

        if(speedUpTimer > speedUpPeriod)
        {
            speedUpTimer = -speedUpCoolingTime;
            moveSpeed = moveSpeed1;
        }
        else if (speedUpTimer < 0 )
        {
            speedUpTimer += Time.deltaTime; 
        }
        else
        {

        }

        if (speedUpTimer < 0 && speedUpTimer >= -0.1f)
        {
            speedUpTimer = 0;
        }
        else
        {

        }
    }
}
