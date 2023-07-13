using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UI_HP_test : MonoBehaviour
{
    public TextMeshProUGUI healthPointUI;
    public PlayerHealthPoint HPCheck;

    void Start()
    {
        healthPointUI.text = "HP:" + HPCheck.HP;
    }

    // Update is called once per frame
    void Update()
    {
        healthPointUI.text = "HP:" + HPCheck.HP;
    }
}
