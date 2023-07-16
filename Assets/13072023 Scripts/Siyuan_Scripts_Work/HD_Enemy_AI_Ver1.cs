using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class HD_Enemy_AI_Ver1 : MonoBehaviour
{
    public Vector3 destination1;
    public Vector3 destination2;
    public Vector3 destination3;
    public float distanceToKeep;
    public Transform target;
    public GameObject player;
    public Vector2 spawnRange;
    public GameObject enemyPrefab;
    public GameObject HiddenOrigin1;
    public Transform HellHoundThisOne;
    public float HHdistance;
    Animator animator;

    private void Start()
    {
        destination1 = player.transform.position;
        NavigateToDestination(destination1);

        destination2 = enemyPrefab.transform.position;
        NavigateToDestination(destination2);

        destination3 = HiddenOrigin1.transform.position;
        NavigateToDestination(destination3);

        distanceToKeep = 3.4f;

        animator = GetComponentInChildren<Animator>();
    }

    public void NavigateToDestination(Vector3 destination)
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = destination;
    }

    public void CheckDistance()
    {
     // Calculate the distance between the two objects
        HHdistance = Vector3.Distance(target.position, HellHoundThisOne.position);
        //Debug.Log("Distance between objects: " + distance);
    }

    void Update()
    {
        destination1 = player.transform.position;
        CheckDistance();
        if (HHdistance >= distanceToKeep)
        {
            NavigateToDestination(destination1);
            animator.SetBool("IsMoving", true);
        }
        else if (HHdistance < distanceToKeep && HHdistance >3.2f)
        {
            NavigateToDestination(HellHoundThisOne.position);
            animator.SetBool("IsMoving", false);
        }

        if (HHdistance <= 3.2f)
        {
            NavigateToDestination(destination3);
            animator.SetBool("IsMoving", true);
        }
        else
        { 

        }

    }

    /*void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Sword")
        {
            Debug.Log("The enemy hit the the sword");

            //EnemyDeath(); Do not touch this atm.

            Destroy(this.gameObject);
        }
    }
    */

    /*public void EnemyDeath()
    {
        // on enemy destruction spawn two enemies

        // Create two random position vectors using spawnRange
        Vector3 randomOffsetOne = new Vector3(Random.Range(spawnRange.x, spawnRange.y), transform.position.y, Random.Range(spawnRange.x, spawnRange.y));
        Vector3 randomOffsetTwo = new Vector3(Random.Range(spawnRange.x, spawnRange.y), transform.position.y, Random.Range(spawnRange.x, spawnRange.y));
        Vector3 spawnPointOne = transform.position + randomOffsetOne;
        Vector3 spawnPointTwo = transform.position + randomOffsetTwo;

        //TODO is check that the enemies are on top of one another

        // Instantiate an enemy prefab at both position vectors
        Instantiate(enemyPrefab, spawnPointOne, Quaternion.identity);
        Instantiate(enemyPrefab, spawnPointTwo, Quaternion.identity);

        // Destroy this enemy (handled by weapon script)

    }*/
}
