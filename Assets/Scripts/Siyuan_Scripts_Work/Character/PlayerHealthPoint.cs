using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthPoint : MonoBehaviour
{
    public int HP;
    public float damageCooler;
    public int damageCoolingTimeLength = 1;


    void Start()
    {
        HP = 5;
        damageCooler = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (HP == 0)
        {
            Destroy(this.gameObject);
        }

        if (damageCooler >= 0.1f)
        {
            damageCooler += Time.deltaTime;
        }

        if (damageCooler >= damageCoolingTimeLength)
        {
          damageCooler = 0;
        }
    }

     void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy" && damageCooler == 0)
        {
           
          HP = HP - 1;
          damageCooler = 0.1f;
        }


    }

}
