using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitFunction : MonoBehaviour
{
    public void QuitGame()
    {
           Application.Quit();
            Debug.Log("The game has quit!");
    }
}
