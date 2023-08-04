using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BD_CS_Enemy_AI : MonoBehaviour
{
    public Vector3 destination;
    public Transform target;
    public GameObject player;
    public Vector2 spawnRange;
    public GameObject enemyPrefab;
    public float stunTimmer;
    public Transform CuSithThisOne;
    public float stunTimeLength = 2f;
    public int CuSith_Statement;
    public float CuSith_WaitingTime = 30.1f;
    public GameObject The30s_Asset;
    public GameObject The20s_Asset;
    public GameObject The10s_Asset;
    public GameObject AttackWarning;

    private void Start()
    {
        destination = player.transform.position;
        //NavigateToDestination(destination);
        stunTimmer = 0;
        CuSith_WaitingTime = -1 * CuSith_WaitingTime;
        CuSith_Statement = 0;
    }

    public void NavigateToDestination(Vector3 destination)
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = destination;
    }

    void Update()
    {
        destination = player.transform.position;
        CuSith_strategy();
        if (CuSith_Statement == 1 & stunTimmer == 0)
        {
            NavigateToDestination(destination);
        }
        else if (stunTimmer >= 0.1f)
        {
            NavigateToDestination(CuSithThisOne.position);
            StunTimeChange();
        }
    }

    public void CuSith_strategy()
    {
        if (CuSith_WaitingTime <= 0)
        {
            CuSith_WaitingTime += Time.deltaTime;
        }
        else if (CuSith_WaitingTime > 0)
        {
            CuSith_Statement = 1;
            gameObject.tag = "Enemy_CS";
        }

        //Below are the assets control, by SetActive() from the hierachy,
        if (CuSith_WaitingTime <= -28 & CuSith_WaitingTime >= -30)
        {
            The30s_Asset.SetActive(true);
        }
        else
        { 
            The30s_Asset.SetActive(false);
        }

        if (CuSith_WaitingTime <= -19 & CuSith_WaitingTime >= -21)
        {
            The20s_Asset.SetActive(true);
        }
        else
        {
            The20s_Asset.SetActive(false);
        }

        if (CuSith_WaitingTime <= -9 & CuSith_WaitingTime >= -11)
        {
            The10s_Asset.SetActive(true);
        }
        else
        {
            The10s_Asset.SetActive(false);
        }

        if (CuSith_WaitingTime < 0 & CuSith_WaitingTime >= -2)
        {
            AttackWarning.SetActive(true);
        }
        else
        {
            AttackWarning.SetActive(false);
        }


    }

    public void StunTimeChange()
    {
        if (stunTimmer >= stunTimeLength)
        {
            stunTimmer = 0;
        }
        else if (stunTimmer >= 0.1f)
        {
            stunTimmer += Time.deltaTime;
        }
    }
}