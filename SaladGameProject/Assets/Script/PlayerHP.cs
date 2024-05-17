using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    public int maxHealth = 3;
    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void DecreaseHealth()
    {
        currentHealth--;
        if (currentHealth <= 0)
        {
            // Handle player defeat (e.g., game over)
            Debug.Log("Game Over!");
        }
        else
        {
            Debug.Log("Player health: " + currentHealth);
        }
    }
}
