using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStamina : MonoBehaviour
{

    public GameObject player;
    private FlyBehaviour flyBehaviour;

    public float staminaRate = 1.0f; // reduce by 1 per second.
    public float stamina = 100f; 

    // Start is called before the first frame update
    void Start()
    {
        flyBehaviour = player.GetComponent<FlyBehaviour>();
        if (flyBehaviour == null)
            Debug.LogError("Player does not have a FlyBehavior component.");
    }



    // Update is called once per frame
    void Update()
    {
        if(flyBehaviour.fly)
        {
            // Reduce stamina
            stamina -= staminaRate * Time.deltaTime; 

        }
        else
        {
            // Charge stamina
            stamina += staminaRate * Time.deltaTime;

        }


    }
}
