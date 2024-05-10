using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class FileDataHandler
{
    private string GameDirectoryPath = "";
    private string GameFileName="";

    public FileDataHandler(string GameDirectoryPath, string GameFileName)
    {
        this.GameDirectoryPath = GameDirectoryPath;
        this.GameFileName = GameFileName;   
    }
    public GameData Load()
    {
        string fullPath = Path.Combine(GameDirectoryPath, GameFileName);
        GameData loadedData = null;
        if(File.Exists(fullPath))
        {
            try
            {
                string DataToLoad = "";

                using (FileStream stream = new FileStream(fullPath, FileMode.Open))
                {
                    using (StreamReader reader = new StreamReader (stream))
                    {
                        DataToLoad = reader.ReadToEnd();
                    }

                }
                loadedData = JsonUtility.FromJson<GameData>(DataToLoad); //,true
            }
            catch(Exception e)
            {
                Debug.Log("Error" + fullPath + "\n" + e);
            }
        }

        return loadedData;
    }
    public void Save(GameData data)
    {
        string fullPath = Path.Combine(GameDirectoryPath, GameFileName);

        try
        {
            Directory.CreateDirectory(Path.GetDirectoryName(fullPath));

            string DataToKeep = JsonUtility.ToJson(data, true); //,true

            using (FileStream stream = new FileStream(fullPath, FileMode.Create))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.Write(DataToKeep);
                }

            }
        }
        catch (Exception e)
        {
            Debug.Log("Error" + fullPath + "\n" + e);
        }
    }
}
