using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_DodgeIcon_Controller : MonoBehaviour
{
    public New_PlayerMovement DodgeCheck;
    public GameObject RedCross;
    public GameObject Shining;

    void Start()
    {
        RedCross.SetActive(false);
        Shining.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        checkSpeedUp();
    }

    public void checkSpeedUp()
    {
        if(DodgeCheck.DodgeTimer > 0)
        {
            RedCross.SetActive(false);
            Shining.SetActive(true);
        }
        else
        {
            if (DodgeCheck.DodgeTimer == 0)
            {
                RedCross.SetActive(false);
                Shining.SetActive(false);
            }
            else
            {
                 RedCross.SetActive(true);
                 Shining.SetActive(false);
            }
        }
    }
}
