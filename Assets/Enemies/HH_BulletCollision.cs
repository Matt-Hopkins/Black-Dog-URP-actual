using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HH_BulletCollision : MonoBehaviour
{
    public float destroyItselfTime = 2f;
    public float bulletTimer;
    public PlayerHealthPoint HHAttack;
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
    void OnCollisionEnter(Collision collision)
    {
            Destroy(this.gameObject);
    }
}
