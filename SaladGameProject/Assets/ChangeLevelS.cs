using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevelS : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ChangeLevel ()
    {
        SceneManager.LoadScene("Level_Selector");
    }

    void Level1()
    {
        SceneManager.LoadScene("Level1");
    }

    void Level2()
    {
        SceneManager.LoadScene("Leve2");
    }

    
}
