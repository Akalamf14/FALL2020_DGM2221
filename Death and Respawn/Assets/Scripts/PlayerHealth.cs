using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
   /* THINGS NEEDED FOR PLAYER HEALTH

   VARIABLES - CURRENT HEALTH, MAX HEALTH, SPAWNPOINT

   FUNCTION - TRIGGER, COLLISION, TAKEDAMAGE

   */

   public FloatData currentHealth, maxHealth;
   public Vector3Data spawnPoint;


   private void Start()
   {
       currentHealth.value = maxHealth.value;
       
    }

    public void TakeDamage(FloatData amount)
    {
        currentHealth.value -= amount.value;

        if(currentHealth.value <= 0)
        {
            currentHealth.value = 0;
            print("Game Over!");


            currentHealth.value = maxHealth.value;
        }
    }

}
