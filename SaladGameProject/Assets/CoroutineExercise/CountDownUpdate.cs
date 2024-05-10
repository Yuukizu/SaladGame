using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Rendering;

public class CountDownUpdate : MonoBehaviour
{
    // Start is called before the first frame update
    private float _timer = 1;
    private int _count = 5;
    void Update()
    {
        _timer -= Time.deltaTime;
        if( _timer <= 0 && _count >= 0)
        {
            Debug.Log(_count);
            _count--;
            
            _timer = 1;
            
        }

        
    }
}
