using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_GraphicAssets_HP_Controller : MonoBehaviour
{
    public PlayerHealthPoint currentHP;
    public GameObject FirstPoint;
    public GameObject SecondPoint;
    public GameObject ThirdPoint;
    public GameObject FourthPoint;
    public GameObject FifthPoint;
    public GameObject SixthPoint;
    public GameObject SeventhPoint;
    public GameObject EighthPoint;
    public GameObject NinthPoint;
    public GameObject TenththPoint;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UI_HP();
    }

    public void UI_HP()
    {
        if (currentHP.HP == 0)
        {
            FirstPoint.SetActive(true);
            SecondPoint.SetActive(true);
            ThirdPoint.SetActive(true);
            FourthPoint.SetActive(true);
            FifthPoint.SetActive(true);
            SixthPoint.SetActive(true);
            SeventhPoint.SetActive(true);
            EighthPoint.SetActive(true);
            NinthPoint.SetActive(true);
            TenththPoint.SetActive(true);
        }
        else if (currentHP.HP == 1)
        {
            FirstPoint.SetActive(true);
            SecondPoint.SetActive(true);
            ThirdPoint.SetActive(true);
            FourthPoint.SetActive(true);
            FifthPoint.SetActive(true);
            SixthPoint.SetActive(true);
            SeventhPoint.SetActive(true);
            EighthPoint.SetActive(true);
            NinthPoint.SetActive(true);
        }
        else if (currentHP.HP == 2)
        {
            FirstPoint.SetActive(true);
            SecondPoint.SetActive(true);
            ThirdPoint.SetActive(true);
            FourthPoint.SetActive(true);
            FifthPoint.SetActive(true);
            SixthPoint.SetActive(true);
            SeventhPoint.SetActive(true);
            EighthPoint.SetActive(true);
        }
        else if (currentHP.HP == 3)
        {
            FirstPoint.SetActive(true);
            SecondPoint.SetActive(true);
            ThirdPoint.SetActive(true);
            FourthPoint.SetActive(true);
            FifthPoint.SetActive(true);
            SixthPoint.SetActive(true);
            SeventhPoint.SetActive(true);
        }
        else if (currentHP.HP == 4)
        {
            FirstPoint.SetActive(true);
            SecondPoint.SetActive(true);
            ThirdPoint.SetActive(true);
            FourthPoint.SetActive(true);
            FifthPoint.SetActive(true);
            SixthPoint.SetActive(true);
            
        }
        else if (currentHP.HP == 5)
        { 
            FirstPoint.SetActive(true);
            SecondPoint.SetActive(true);
            ThirdPoint.SetActive(true);
            FourthPoint.SetActive(true);
            FifthPoint.SetActive(true);

        }
        else if (currentHP.HP == 6)
        { 
            FirstPoint.SetActive(true);
            SecondPoint.SetActive(true);
            ThirdPoint.SetActive(true);
            FourthPoint.SetActive(true);
            
        }
        else if (currentHP.HP == 7)
        { 
            FirstPoint.SetActive(true);
            SecondPoint.SetActive(true);
            ThirdPoint.SetActive(true);
            
        }
        else if (currentHP.HP == 8)
        { 
            FirstPoint.SetActive(true);
            SecondPoint.SetActive(true);
            
        }
        else if (currentHP.HP == 9)
        { 
            FirstPoint.SetActive(true);
        }
    }
}
