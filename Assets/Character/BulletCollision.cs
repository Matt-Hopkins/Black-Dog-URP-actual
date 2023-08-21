using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour
{
    public float destroyItselfTime = 3f;
    public float bulletTimer;
    void Start()
    {
        bulletTimer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        bulletTimer += Time.deltaTime;
        if (bulletTimer >= destroyItselfTime)
        {
            Destroy(this.gameObject);
        }
    }
    void OnTriggerEnter(Collider other)
    {
            Destroy(this.gameObject);
    }
}
