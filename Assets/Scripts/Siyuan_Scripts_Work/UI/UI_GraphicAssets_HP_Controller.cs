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
            FirstPoint.SetActive(false);
            SecondPoint.SetActive(false);
            ThirdPoint.SetActive(false);
            FourthPoint.SetActive(false);
            FifthPoint.SetActive(false);
        }
        else if (currentHP.HP == 1)
        {
            FifthPoint.SetActive(true);
            SecondPoint.SetActive(true);
            ThirdPoint.SetActive(true);
            FourthPoint.SetActive(true);
        }
        else if (currentHP.HP == 2)
        {
            FourthPoint.SetActive(true);
            SecondPoint.SetActive(true);
            ThirdPoint.SetActive(true);
        }
        else if (currentHP.HP == 3)
        {
            ThirdPoint.SetActive(true);
            SecondPoint.SetActive(true);
        }
        else if (currentHP.HP == 4)
        {
            SecondPoint.SetActive(true);
        }
        else
        { 
        }
    }
}
