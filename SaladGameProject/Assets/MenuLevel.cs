using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuLevel : MonoBehaviour
{
    DataManager dataManager;
    SeneManagement sceneMangament;

    private GameData gameData;

    [SerializeField] private Button NewgameButton;
    [SerializeField] private Button LoadGameButton;
    

    private void Start()
    {
        sceneMangament = GetComponent<SeneManagement>();
        dataManager = GetComponent<DataManager>();
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
        SceneManager.LoadScene("Level2");
    }

    public void NewPgame()
    {
        DataManager.instance.NewGame();
        SceneManager.LoadSceneAsync("Level1");
    }
    public void SavePgame()
    {
        DataManager.instance.SaveGame();
    }

    public void LoadPgame()
    {
        DataManager.instance.LoadGame();
        SceneManager.LoadSceneAsync("Level1");
    }

    private void Disablebutton()
    {
        NewgameButton.interactable = false;
        LoadGameButton.interactable = false;
    }
}
