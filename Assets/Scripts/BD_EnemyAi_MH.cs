using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class BD_EnemyAi_MH : MonoBehaviour
{
    public Vector3 destination;
    public Transform target;
    public GameObject player;
    public Vector2 spawnRange;
    public GameObject enemyPrefab;

    private void Start()
    {
        destination = player.transform.position;
        NavigateToDestination(destination);
    }

    public void NavigateToDestination(Vector3 destination)
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = destination;
    }

    void Update()
    {
         destination = player.transform.position;
         NavigateToDestination(destination);
    }

    /*void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Sword")
        {
            Debug.Log ("The enemy hit the the sword");

            //EnemyDeath();

            Destroy (this.gameObject);
        }
    }
    */

    public void EnemyDeath()
    {
        // on enemy destruction spawn two enemies

        // Create two random position vectors using spawnRange
        Vector3 randomOffsetOne = new Vector3(Random.Range(spawnRange.x,spawnRange.y), transform.position.y, Random.Range(spawnRange.x,spawnRange.y));
        Vector3 randomOffsetTwo = new Vector3(Random.Range(spawnRange.x,spawnRange.y), transform.position.y, Random.Range(spawnRange.x,spawnRange.y));
        Vector3 spawnPointOne = transform.position + randomOffsetOne;
        Vector3 spawnPointTwo = transform.position + randomOffsetTwo;

        //TODO is check that the enemies are on top of one another

        // Instantiate an enemy prefab at both position vectors
        Instantiate(enemyPrefab,spawnPointOne,Quaternion.identity);
        Instantiate(enemyPrefab,spawnPointTwo,Quaternion.identity);

        // Destroy this enemy (handled by weapon script)
    
    }
}