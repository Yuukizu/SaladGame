using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeLevel()
    {
        SceneManager.LoadScene("Level_Selector");
    }

    public void Level1()
    {
        SceneManager.LoadScene("Level1");  
    }

    public void Level2()
    {
        SceneManager.LoadScene("Leve2");
    }
}
