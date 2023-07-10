using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Mouse_Follow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Update()
    {
        //Aim player at mouse
        //which direction is up
        Vector3 upAxis = new Vector3(0, -1, 0);
        Vector3 mouseScreenPosition = Input.mousePosition;
        //set mouses z to your targets
        mouseScreenPosition.y = transform.position.y;
        Vector3 mouseWorldSpace = Camera.main.ScreenToWorldPoint(mouseScreenPosition);
        transform.LookAt(mouseWorldSpace, upAxis);
        //zero out all rotations except the axis I want
        transform.eulerAngles = new Vector3(0, -transform.eulerAngles.y, 0);
    }


    /*public void FixedUpdate()
    {
        //Aim player at mouse
        //which direction is up
        Vector3 upAxis = new Vector3(-1, -1, -1);
        Vector3 mouseScreenPosition = Input.mousePosition;
        //set mouses z to your targets
        mouseScreenPosition.x = transform.position.x;
        mouseScreenPosition.y = transform.position.y;
        mouseScreenPosition.z = transform.position.z;
        Vector3 mouseWorldSpace = Camera.main.ScreenToWorldPoint(mouseScreenPosition);
        transform.LookAt(mouseWorldSpace, upAxis);
        //zero out all rotations except the axis I want
        transform.eulerAngles = new Vector3(-transform.eulerAngles.x, -transform.eulerAngles.y, -transform.eulerAngles.z);
    }*/
}
