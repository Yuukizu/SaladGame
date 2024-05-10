using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helloworld_ : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Hello World");
        }
    }
}
