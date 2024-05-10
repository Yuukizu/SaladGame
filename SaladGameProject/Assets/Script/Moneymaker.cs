using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneymaker : MonoBehaviour
{
    SeneManagement scenemanagent;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoneyGenerate()
    {
        SeneManagement.instance.Money += 1;
        

    }
}
