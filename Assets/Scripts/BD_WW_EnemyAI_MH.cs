using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BD_WW_EnemyAI_MH : MonoBehaviour
{
    public Vector3 destination;
    public Transform target;
    public GameObject player;
    public Vector2 spawnRange;
    public GameObject enemyPrefab;
    Animator animator;

    private void Start()
    {
        destination = player.transform.position;
        NavigateToDestination(destination);

        animator = GetComponentInChildren<Animator>();
    }

    public void NavigateToDestination(Vector3 destination)
    {
        UnityEngine.AI.NavMeshAgent agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        agent.destination = destination;
    }

    void Update()
    {
         destination = player.transform.position;
         NavigateToDestination(destination);

         animator.SetBool("IsMoving", true);
    }
}
