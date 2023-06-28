
using UnityEngine;
using UnityEngine.Events;
using TMPro;

//This script component will give health behavior to any object it is applied to. 
//Use the inspector to set the object starting health. 
//Call the TakeDamage function to take damage from the health.
//When the object dies it will call the objectHasDied Event.
//Use the inspector to have this event call other function on other scripts. 

public class Health : MonoBehaviour
{
    public int health;
    public UnityEvent objectHasDied;
    public HealthCounter healthCounter; 


    public void TakeDamage(int damageToTake)
    {
        // Debug.Log("You took " + damageToTake + "damage! " + health + "health remaining!");
        health -= damageToTake;
        string healthString = health.ToString();
        healthCounter.UpdateText(healthString);

        // this calls the game statistics screen, comment it out if it isn’t in your scene!
        // GameStatisticsScreen.TookDamageEvent(damageToTake);

        if (health <= 0)
        {
            objectHasDied.Invoke();
            Destroy(this.gameObject);
        }
    }

    // You can create multiple methods below, add them to the objectHasDied slot in the Inspector,
    // and they all will be called when the Invoke() method above is used!
    
}



