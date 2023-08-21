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

    public float DodgeTimer;
    public float DodgePeriod = 1f;
    public float DodgeCoolingTime = 3f;
    public int DodgeCondition;

    void Start()
    {
        speedUpTimer = 0;
        DodgeTimer = 0;
        DodgeCondition = 0;
        moveSpeed1 = moveSpeed;
        moveSpeed2 = 1.5f * moveSpeed;
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
        DodgeFunction();

        Vector3 _movement = new Vector3(_horizontal, 0, _vertical);
        transform.Translate(_movement * -1 * moveSpeed * Time.deltaTime, Space.World);
    }


    public void DodgeFunction()
    {
         if (Input.GetKeyDown("q") && DodgeTimer == 0)
        {
            DodgeTimer += Time.deltaTime;
            DodgeCondition = 1;
        }
        else
        {

        }

        if (DodgeTimer <= DodgePeriod && DodgeTimer > 0)
        {
            DodgeTimer += Time.deltaTime;
        }
        else
        {

        }

        if(DodgeTimer > DodgePeriod)
        {
            DodgeTimer = -DodgeCoolingTime;
            DodgeCondition = 0;
        }
        else if (DodgeTimer < 0 )
        {
            DodgeTimer += Time.deltaTime; 
        }
        else
        {

        }

        if (DodgeTimer < 0 && DodgeTimer >= -0.1f)
        {
            DodgeTimer = 0;
        }
        else
        {

        }
    }

    void SpeedUpFunction()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift) && speedUpTimer == 0)
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
