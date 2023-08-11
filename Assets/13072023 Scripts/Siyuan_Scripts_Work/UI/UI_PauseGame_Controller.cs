using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_PauseGame_Controller : MonoBehaviour
{
    public GameObject Pause_menu;
    public int pauseChecker;

     void Start()
    {
        pauseChecker = 0;
    }

    void Update()
    {
        PauseGame();
    }


    public void PauseGame()
    {
            if(Input.GetKeyUp("escape")) 
            {
                if (pauseChecker == 0)
                {
                    Time.timeScale = 0;
                    Pause_menu.SetActive(true); //display Pause menu
                    pauseChecker = 1;
                }
                else
                {
                    Time.timeScale = 1;
                    Pause_menu.SetActive(false); 
                    pauseChecker = 0;
                }
             
            }
    }
    
    /*public void ResumeGame() 
    {
        if (Pause_menu.SetActive(true))
        {
            if(Input.GetKeyDown("escape"))
            { 
                if (pauseChecker == 1)
                {
                    Time.timeScale = 1;
                    Pause_menu.SetActive(false); 
                    pauseChecker = 0;
                }
            }
        }
    }*/

    public void QuitGame()
    {
           Application.Quit();
            Debug.Log("The game has quit!");
    }
}
