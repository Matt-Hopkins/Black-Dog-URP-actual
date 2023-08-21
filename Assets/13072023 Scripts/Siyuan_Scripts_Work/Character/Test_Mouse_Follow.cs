using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Mouse_Follow : MonoBehaviour
{
    [SerializeField]

    void Start()
    {
        
    }
    public void Update()
    {
       HandleRotation ();
    }

void HandleRotation ()
{
    RaycastHit _hit;
    Ray _ray = Camera.main.ScreenPointToRay(Input.mousePosition);

    if (Physics.Raycast(_ray, out _hit))
    {
        transform.LookAt(new Vector3(_hit.point.x, transform.position.y, _hit.point.z));
    }
}

}
