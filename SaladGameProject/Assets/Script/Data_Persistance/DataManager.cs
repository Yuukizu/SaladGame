using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;
using System.Runtime.InteropServices.WindowsRuntime;

public class DataManager : MonoBehaviour
{
    [SerializeField] private string FileName;
    private GameData gameData;
    private FileDataHandler datahander;
    public static DataManager instance { get; private set; }
    private List<IDataPersistance> dataPersistances;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            InitializeComponents();
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }
    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
        SceneManager.sceneUnloaded += OnSceneUnLoaded;

    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
        SceneManager.sceneUnloaded -= OnSceneUnLoaded;
    }


    private void InitializeComponents()
    {
        
        this.datahander = new FileDataHandler(Application.persistentDataPath, FileName);
    }

    
    public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        this.dataPersistances = FindAllDataPersistance();
        LoadGame();

        
    }
    public void OnSceneUnLoaded(Scene scene)
    {
        SaveGame();
        


    }

    public void NewGame()
    {
        this.gameData = new GameData();
    }

    public void LoadGame()
    {
        this.gameData = datahander.Load();
        if (this.gameData == null)
        {
            return;
        }

        foreach (IDataPersistance dataPersistenceObj in dataPersistances)
        {
            dataPersistenceObj.LoadData(gameData);
        }
    }

    public void SaveGame()
    {
        if (this.gameData == null)
        {
            return;
        }
        foreach (IDataPersistance dataPersistenceObj in dataPersistances)
        {
            dataPersistenceObj.SaveData(gameData);
        }

        datahander.Save(gameData);
    }

    private void OnApplicationQuit()
    {
        SaveGame();
    }

    private List<IDataPersistance> FindAllDataPersistance()
    {
        return FindObjectsOfType<MonoBehaviour>().OfType<IDataPersistance>().ToList();
    }
}
