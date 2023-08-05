using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_SpeedUpIcon_Controller : MonoBehaviour
{
    public New_PlayerMovement ConditionCheck;
    //public GameObject SpeedUpIcon;
    public GameObject RedCross;
    public GameObject Shining;

    void Start()
    {
        //SpeedUpIcon.SetActive(true);
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
        if(ConditionCheck.speedUpTimer > 0)
        {
            //SpeedUpIcon.SetActive(true);
            RedCross.SetActive(false);
            Shining.SetActive(true);
        }
        else
        {
            if (ConditionCheck.speedUpTimer == 0)
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
