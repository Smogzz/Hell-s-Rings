using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    // The target the object will follow
    private Transform target;

    // The movement speed of the follower
    public float speed = 3f;

    // The distance at which the follower should stop (optional)
    public float stoppingDistance = 1.5f;

    void Start()
    {
        // Find the player object using its tag and get its Transform component
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
        if (playerObject != null)
        {
            target = playerObject.transform;
        }
        else
        {
            Debug.LogError("Player object not found! Make sure it has the 'Player' tag.");
        }
    }

    void Update()
    {
        // Only follow if a target is found
        if (target != null)
        {
            // Check the distance between the follower and the target
            if (Vector3.Distance(transform.position, target.position) >= stoppingDistance)
            {
                // Move towards the target's position
                transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            }
        }
    }
}