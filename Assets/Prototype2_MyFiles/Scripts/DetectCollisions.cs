using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        // Instead of destroying the projectile when it collides with an animal
        //Destroy(other.gameObject); 

        // Just deactivate the food and destroy the animal
        if (other.gameObject.CompareTag("Food"))
        {
         other.gameObject.SetActive(false);
         Destroy(gameObject);
        }
    }

}
