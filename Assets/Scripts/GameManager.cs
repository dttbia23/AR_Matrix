using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Status
{
    public int grade;
    public int intelligence;
    public int attractiveness;
    public int health;
}
[Serializable]
public class PlayerData
{
    public Status status;
    public List<string> clearMisionList;
}



public class GameManager : MonoBehaviour
{
    #region Singleton
    private static GameManager instance = null;
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GameManager>();
                if (instance == null)
                {
                    GameObject go = new GameObject();
                    go.name = "SingletonController";
                    instance = go.AddComponent<GameManager>();
                    DontDestroyOnLoad(go);
                }
            }
            return instance;
        }
    }
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
            Destroy(gameObject);
    }
    #endregion

    public string nowMissionCode; // 현재 미션 정보
    public PlayerData playerData;




    #region Status Up and Down
    /// <summary>
    /// num으로 학년 바꾸기 (1~4)
    /// </summary>
    /// <param name="num"></param>
    public void ChangeGrade(int num)
    {
        playerData.status.grade = num;
    }

    public void IntelligenceStatusUpDown(int num)
    {
        playerData.status.intelligence += num;
    }
    public void AttractivenessStatusUpDown(int num)
    {
        playerData.status.attractiveness += num;
    }
    public void HealthStatusUpDown(int num)
    {
        playerData.status.health += num;
    }
    #endregion
}
