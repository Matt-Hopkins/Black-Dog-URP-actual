using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_Rotation_Only : MonoBehaviour
{
    public Vector2 turn;
    public float RotationSpeed = 850;
  
    void Start()
    {
        
    }
    void Update()
    {
        turn.x = Input.GetAxis("Mouse X");
        turn.y = Input.GetAxis("Mouse Y");

       if(turn.y >= 0 && turn.x >0)
        {
            transform.Rotate(0, (RotationSpeed * Time.deltaTime), 0, Space.Self);

        }

        else if (turn.y <= 0 && turn.x <0)

        {
            transform.Rotate(0, -(RotationSpeed * Time.deltaTime), 0, Space.Self);
        }
        

        if(turn.y < 0 && turn.x >= 0)
        {
            transform.Rotate(0, (RotationSpeed * Time.deltaTime), 0, Space.Self);

        }

        else if (turn.y > 0 && turn.x <= 0)

        {
            transform.Rotate(0, -(RotationSpeed * Time.deltaTime), 0, Space.Self);
        }

        
      


    }
}
