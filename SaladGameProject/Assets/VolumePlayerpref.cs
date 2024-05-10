using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumePlayerpref : MonoBehaviour
{
    /*Load = Get, Save = Set*/
    public static VolumePlayerpref instance { get; private set; }
    
    [SerializeField] private Slider MusciVolumeChanger;
    [SerializeField] private string Music_volume;
    

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        LoadingSetting();
    }


    public void LoadingSetting()
    {
        float volumeMusic = PlayerPrefs.GetFloat("Music_Volume");
        MusciVolumeChanger.value = volumeMusic;
        AudioListener.volume = volumeMusic;
    }

    public void SaveSetting()
    {
        
        float volumeMusic = MusciVolumeChanger.value;
        PlayerPrefs.SetFloat("Music_Volume", volumeMusic);
        PlayerPrefs.Save();
        LoadingSetting();


    }
}
