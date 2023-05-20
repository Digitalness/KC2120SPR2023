using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class PlayerHUD : MonoBehaviour
{
    public Slider healthSlider;
    public Slider staminaSlider;
    public GameObject player;
    private PlayerHealth playerHealth;
    private PlayerStamina playerStamina; 



    void Start()
    {
        playerHealth = player.GetComponent<PlayerHealth>();
        playerStamina = player.GetComponent<PlayerStamina>(); 
    }

    // Update is called once per frame
    void Update()
    {
        healthSlider.value = playerHealth.health;
        staminaSlider.value = playerStamina.stamina; 
    }
}
