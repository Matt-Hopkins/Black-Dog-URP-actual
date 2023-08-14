using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_GameOver_controller : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        InputKeyR();
        InputKeyEsc();
    }

    void InputKeyR()
    {
        if(Input.GetKeyDown("r")) 
        {
             SceneManager.LoadScene(1);
        }

    }

    void InputKeyEsc()
    {
        if(Input.GetKeyDown("escape")) 
        {
          Application.Quit();
        }
    }
}
