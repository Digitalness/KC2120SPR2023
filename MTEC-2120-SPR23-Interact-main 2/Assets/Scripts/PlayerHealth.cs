using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{

    public int health = 100;

    public UnityEvent OnDeath; 

    private void OnCollisionEnter(Collision collision)
    {

        if(collision.gameObject.GetComponent<Damage>())
        {
            Debug.Log("Player collided with object.");
            health -= collision.gameObject.GetComponent<Damage>().damage; 
        }

    }

    private void CheckDeath()
    {
        if (health < 0)
            Die(); 
    }
    private void Die()
    {
        OnDeath.Invoke(); 
        Destroy(this.gameObject); 
    }

    private void Update()
    {
        CheckDeath(); 
    }

}
