using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderDetect : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.TryGetComponent(out Veggie veggie))
        {
            Debug.Log("Veggie is on plate");
        }
    }


    
}
