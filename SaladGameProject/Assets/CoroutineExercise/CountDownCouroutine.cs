using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountDownCouroutine : MonoBehaviour
{
    private int _counttime = 6;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountDown());
    }

    IEnumerator CountDown()
    {

        while(_counttime > 0)
        {
            _counttime--;
            Debug.Log(_counttime);
            yield return new WaitForSeconds(1);
        }
    }
}
