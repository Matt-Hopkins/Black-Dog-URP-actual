using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_StunAttack : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float bulletForce = 20f;
    public float timer;
    public float coolingDownTime = 0.9f;
    void Start()
    {
        timer = 0; 
    }
    void Update()
    {
        if (Input.GetButton("Fire2") && timer == 0)
        {
            Shoot();
            timer = 0.1f;
        }

        timerUpdate();
        
    }
    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        //rb.AddForce(firePoint.up * bulletForce, ForceMode.Impulse);
    }
    void timerUpdate()
    {
        if (timer >= 0.1f)
        {
            timer += Time.deltaTime;
        }

        if (timer >= coolingDownTime)
        {
            timer = 0;
        }

    }
}
