using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public float speed = 5.0f; // Adjustable speed in the Inspector
    private Transform player; // Reference to the player's transform

    void Start()
    {
        // Find the player object by tag at the start of the game
        GameObject playerObject = GameObject.FindWithTag("Player");
        if (playerObject != null)
        {
            player = playerObject.transform;
        }
    }

    void Update()
    {
        if (player != null)
        {
            // Calculate the direction and distance to the player
            Vector3 direction = player.position - transform.position;
            
            // Optional: Make the enemy look at the player
            transform.LookAt(player);

            // Move the enemy towards the player
            transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
    }
}
