using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using Newtonsoft.Json;


// 저장/불러오기 처리
public static class DataManager
{
    public static string filePath;
    public static void Save()
    {



    }


    public static void Load() { }


    public static void SavePlayerData()
    {
        //직렬화
        string toJsonData = JsonConvert.SerializeObject(GameManager.Instance.playerData);

        filePath = Path.Combine(Application.persistentDataPath, "PlayerData.json");

        File.WriteAllText(filePath, toJsonData);
        Debug.Log($"{filePath}에 playerData 저장 완료");

    }


    public static void LoadPlayerData()
    {
        filePath = Path.Combine(Application.persistentDataPath, "PlayerData.json");

        if (File.Exists(filePath))
        {
            string jsonString = File.ReadAllText(filePath);

            GameManager.Instance.playerData = JsonConvert.DeserializeObject<PlayerData>(jsonString);
        }
        else
        {
            Debug.Log($"Can't find playerData : {filePath}");
        }
    }

    public static void InitializePlayerData()
    {
        string initFilePath = Path.Combine(Application.dataPath, "Data", "PlayerData_Init.json");
        if (File.Exists(filePath))
        {
            string jsonString = File.ReadAllText(filePath);
            //객체 역직렬화 직접 불가능. 라이브러리 사용
            GameManager.Instance.playerData = JsonConvert.DeserializeObject<PlayerData>(jsonString);


            //장치에 저장
            SavePlayerData();

        }
        else
        {
            Debug.Log($"Can't find init file : {initFilePath}");
        }

    }

}
