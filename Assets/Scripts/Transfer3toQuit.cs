using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transfer3toQuit : MonoBehaviour
{
    public int counter_BD;
    public int counter_HD;
    public int counter_WW;
    public int EndLevel1;
    public float timerWave1to2;
    public float timerWave2to3;
    public float transferWaiting;

    public float Wave2WaitingTime = 3f;
    public float Wave3WaitingTime = 3f;
    public float transferWaitingTime = 3f;
    
    public GameObject EnemyGroup_2;
    public GameObject EnemyGroup_3;
    public GameObject EnemyGroup_4;

    void Start()
    {
        counter_BD = 0;
        counter_HD = 0;
        EndLevel1 = 0;
        timerWave1to2 = 0;
        timerWave2to3 = 0;
        transferWaiting = 0;
    }

    // Update is called once per frame
    void Update()
    {
        NumCounter_Lv1();
        SceneTransfer1to2();
    }

    void NumCounter_Lv1()
    {
       if (counter_BD == 15 && counter_HD == 9 && counter_WW == 1)
       {
            transferWaiting += Time.deltaTime;
       }
       
       if (counter_BD == 15 && counter_HD == 9 && counter_WW == 1 && transferWaiting >= transferWaitingTime)
       {
            EndLevel1 = 1;
       }
       
       if (counter_BD == 5 && counter_HD == 3)
       {
            timerWave1to2 += Time.deltaTime;
       }

       if (counter_BD == 5 && counter_HD == 3 && timerWave1to2 >= Wave2WaitingTime)
       {
        EnemyGroup_2.SetActive(true);
       }

       if (counter_BD == 10 && counter_HD == 6)
       {
            timerWave2to3 += Time.deltaTime;
       }

       if (counter_BD == 10 && counter_HD == 6 && timerWave2to3 >= Wave3WaitingTime)
       {
            EnemyGroup_3.SetActive(true);
       }

       if (counter_BD == 15 && counter_HD == 9)
       {
            timerWave2to3 += Time.deltaTime;
       }

       if (counter_BD == 15 && counter_HD == 9 && timerWave2to3 >= Wave3WaitingTime)
       {
            EnemyGroup_4.SetActive(true);
       }

    }

    void SceneTransfer1to2()
    {
       if(EndLevel1 == 1)
       {
        Quitgame();
       }
    }
    void Quitgame()
    {
        Application.Quit();

        Debug.Log ("The game has quit!");
    }

}
