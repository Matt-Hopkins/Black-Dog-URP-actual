using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HH_Shooting : MonoBehaviour
{
    public Transform firePoint_HH;
    public GameObject bulletPrefab_HH;
    public float bulletForce = 20f;
    public float timer;
    public float coolingDownTime = 1.1f;
    void Start()
    {
        timer = 0;
    }
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= coolingDownTime)
        {
            Shoot();
            timer = 0;
        }
    }
    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab_HH, firePoint_HH.position, firePoint_HH.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.AddForce(firePoint_HH.forward * bulletForce, ForceMode.Impulse);
    }
}
