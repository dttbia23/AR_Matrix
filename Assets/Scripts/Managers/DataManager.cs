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
    public static string playerDataFile = "PlayerData.json";
    public static string playerDataInitFile = "PlayerData_Init.json";
    public static void Save()
    {



    }


    public static void Load() { }


    public static void SavePlayerData()
    {
        //직렬화
        string toJsonData = JsonConvert.SerializeObject(GameManager.Instance.playerData);

        filePath = Path.Combine(Application.persistentDataPath, playerDataFile);

        File.WriteAllText(filePath, toJsonData);
        Debug.Log($"로컬에 playerData 저장 완료");

    }


    public static void LoadPlayerData()
    {
        filePath = Path.Combine(Application.persistentDataPath, playerDataFile);

        if (File.Exists(filePath))
        {
            string jsonString = File.ReadAllText(filePath);
            Debug.Log("플레이어 데이터 불러오기");

            GameManager.Instance.playerData = JsonConvert.DeserializeObject<PlayerData>(jsonString);
        }
        else
        {
            Debug.Log($"로컬에 저장된 데이터 없음. 초기화 메소드 호출");
            InitializePlayerData();
        }
    }

    public static void InitializePlayerData()
    {
        string initFilePath = Path.Combine(Application.dataPath, "Data", playerDataInitFile);
        if (File.Exists(initFilePath))
        {
            string jsonString = File.ReadAllText(initFilePath);
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

    public static void Reset()
    {
        filePath = Path.Combine(Application.persistentDataPath, playerDataFile);
        File.Delete(filePath);

        InitializePlayerData();
    }

}
