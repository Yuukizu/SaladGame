using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeneManagement : MonoBehaviour, IDataPersistance
{
    // Start is called before the first frame update
    //if player finish level-> save the progress that they finish this and the unlock item that they get

    public static SeneManagement instance { get; private set; }
    
    public bool isChnagingScene = false;
    public int Money;
    
    
    private bool iswin = false;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if(instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void LoadData(GameData data)
    {
        this.Money = data.Money;
    }
    public void SaveData(GameData data)
    {
        data.Money = this.Money;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
