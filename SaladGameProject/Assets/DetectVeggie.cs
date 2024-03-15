using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectVeggie : MonoBehaviour
{
    public Transform targetObject; // The specific object to reach
    public float lockDistance = 0.1f; // The distance within which the object is considered to have reached the target

    private bool isLocked = false;

    void Update()
    {
        if (!isLocked)
        {
            // Calculate the distance between this object and the target object
            float distance = Vector3.Distance(transform.position, targetObject.position);

            // If the distance is less than the lock distance, lock the position
            if (distance < lockDistance)
            {
                // Lock the position
                transform.position = targetObject.position;
                isLocked = true;
            }
        }
    }
}
