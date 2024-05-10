using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Helloworld_co : MonoBehaviour
{
    private Coroutine SayHello;
    void Start()
    {

        StartCoroutine(SayHiForeal()); 

    }

     
    
    IEnumerator SayHiForeal()
    {
        
        while (true)
        {
            yield return null;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Hello World");
            }
        }
        
        

    }
}
