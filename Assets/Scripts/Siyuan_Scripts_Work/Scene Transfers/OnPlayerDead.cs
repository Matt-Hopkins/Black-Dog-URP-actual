using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnPlayerDead : MonoBehaviour
{
    public int GameOverSceneCheck;

    void Start()
    {
        GameOverSceneCheck = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameOverSceneCheck == 1)
        {
            SceneManager.LoadScene(3);
        }
    }
}
